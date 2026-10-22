using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api/servis-kayitlari")]
public class ServisKayitlariController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Listele(string? arama, string? durum)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var filtre = Builders<ServisKaydi>.Filter.Empty;
        if (!string.IsNullOrWhiteSpace(arama))
        {
            var aranan = Arama.IcindeGecen(arama);
            filtre = Builders<ServisKaydi>.Filter.Or(
                Builders<ServisKaydi>.Filter.Regex(s => s.No, aranan),
                Builders<ServisKaydi>.Filter.Regex(s => s.MusteriAdi, aranan),
                Builders<ServisKaydi>.Filter.Regex(s => s.MusteriTelefon, aranan),
                Builders<ServisKaydi>.Filter.Regex(s => s.Cihaz, aranan),
                Builders<ServisKaydi>.Filter.Regex(s => s.SeriNo, aranan));
        }
        if (!string.IsNullOrWhiteSpace(durum))
        {
            filtre = filtre & Builders<ServisKaydi>.Filter.Eq(s => s.Durum, durum);
        }

        var kayitlar = await Veritabani.ServisKayitlari.Find(filtre).SortByDescending(s => s.AcilisTarihi).ToListAsync();
        return Ok(kayitlar);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Getir(string id)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var kayit = await Veritabani.ServisKayitlari.Find(s => s.Id == id).FirstOrDefaultAsync();
        if (kayit == null) return NotFound("Servis kaydı bulunamadı.");
        return Ok(kayit);
    }

    [HttpPost]
    public async Task<IActionResult> Ekle(ServisKaydi kayit)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        string? hata = Dogrula(kayit);
        if (hata != null) return BadRequest(hata);

        var musteri = await Veritabani.Musteriler.Find(m => m.Id == kayit.MusteriId).FirstOrDefaultAsync();
        if (musteri == null) return BadRequest("Müşteri bulunamadı.");

        hata = await TeknisyeniYaz(kayit);
        if (hata != null) return BadRequest(hata);

        kayit.Id = Veritabani.YeniId();
        kayit.No = await Veritabani.YeniServisNo();
        kayit.MusteriAdi = musteri.AdSoyad;
        kayit.MusteriTelefon = musteri.Telefon;
        kayit.AcilisTarihi = DateTime.UtcNow;
        // Parçalar kayıt açıldıktan sonra tek tek eklenir, çünkü her biri stoktan düşülmeli.
        kayit.Parcalar = [];
        TarihleriAyarla(kayit);

        await Veritabani.ServisKayitlari.InsertOneAsync(kayit);
        return Ok(kayit);
    }

    // Müşteri, numara ve parçalar burada değişmez; parçalar için aşağıdaki ayrı adresler kullanılır.
    [HttpPut("{id}")]
    public async Task<IActionResult> Guncelle(string id, ServisKaydi kayit)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        string? hata = Dogrula(kayit);
        if (hata != null) return BadRequest(hata);

        var eski = await Veritabani.ServisKayitlari.Find(s => s.Id == id).FirstOrDefaultAsync();
        if (eski == null) return NotFound("Servis kaydı bulunamadı.");

        // Teknisyen değişmediyse pasif olsa bile eski atama kalabilir.
        if (kayit.TeknisyenId != eski.TeknisyenId)
        {
            hata = await TeknisyeniYaz(kayit);
            if (hata != null) return BadRequest(hata);
        }
        else
        {
            kayit.TeknisyenAdi = eski.TeknisyenAdi;
        }

        kayit.TamamlanmaTarihi = eski.TamamlanmaTarihi;
        kayit.TeslimTarihi = eski.TeslimTarihi;
        TarihleriAyarla(kayit);

        var guncelleme = Builders<ServisKaydi>.Update
            .Set(s => s.TeknisyenId, kayit.TeknisyenId)
            .Set(s => s.TeknisyenAdi, kayit.TeknisyenAdi)
            .Set(s => s.Cihaz, kayit.Cihaz.Trim())
            .Set(s => s.SeriNo, kayit.SeriNo)
            .Set(s => s.Sorun, kayit.Sorun)
            .Set(s => s.Aksesuarlar, kayit.Aksesuarlar)
            .Set(s => s.YapilanIslem, kayit.YapilanIslem)
            .Set(s => s.Durum, kayit.Durum)
            .Set(s => s.IscilikUcreti, kayit.IscilikUcreti)
            .Set(s => s.OdendiMi, kayit.OdendiMi)
            .Set(s => s.TamamlanmaTarihi, kayit.TamamlanmaTarihi)
            .Set(s => s.TeslimTarihi, kayit.TeslimTarihi);
        await Veritabani.ServisKayitlari.UpdateOneAsync(s => s.Id == id, guncelleme);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Sil(string id)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var kayit = await Veritabani.ServisKayitlari.Find(s => s.Id == id).FirstOrDefaultAsync();
        if (kayit == null) return NotFound("Servis kaydı bulunamadı.");
        if (kayit.Parcalar.Count > 0)
        {
            return BadRequest("Önce kayıttaki parçaları çıkarın; böylece stoğa geri dönerler.");
        }

        await Veritabani.ServisKayitlari.DeleteOneAsync(s => s.Id == id);
        return Ok();
    }

    [HttpPost("{id}/parcalar")]
    public async Task<IActionResult> ParcaEkle(string id, ParcaKullanIstegi istek)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (istek.Adet <= 0) return BadRequest("Adet en az 1 olmalı.");

        var kayit = await Veritabani.ServisKayitlari.Find(s => s.Id == id).FirstOrDefaultAsync();
        if (kayit == null) return NotFound("Servis kaydı bulunamadı.");
        if (kayit.Durum == ServisDurumlari.TeslimEdildi || kayit.Durum == ServisDurumlari.IptalEdildi)
        {
            return BadRequest("Teslim edilmiş ya da iptal edilmiş kayda parça eklenemez.");
        }

        var parca = await Veritabani.Parcalar.Find(p => p.Id == istek.ParcaId).FirstOrDefaultAsync();
        if (parca == null) return BadRequest("Parça bulunamadı.");

        // Stoktan düş. Stok yetmiyorsa filtre eşleşmez ve hiçbir şey değişmez.
        var stokSonucu = await Veritabani.Parcalar.UpdateOneAsync(
            p => p.Id == parca.Id && p.StokAdedi >= istek.Adet,
            Builders<Parca>.Update.Inc(p => p.StokAdedi, -istek.Adet));
        if (stokSonucu.MatchedCount == 0)
        {
            return BadRequest("Stokta yeterli " + parca.Ad + " yok.");
        }

        var satir = new KullanilanParca
        {
            Id = Veritabani.YeniId(),
            ParcaId = parca.Id,
            Ad = parca.Ad,
            Adet = istek.Adet,
            BirimFiyat = parca.BirimFiyat
        };
        await Veritabani.ServisKayitlari.UpdateOneAsync(
            s => s.Id == id,
            Builders<ServisKaydi>.Update.Push(s => s.Parcalar, satir));
        return Ok(satir);
    }

    [HttpDelete("{id}/parcalar/{satirId}")]
    public async Task<IActionResult> ParcaCikar(string id, string satirId)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var kayit = await Veritabani.ServisKayitlari.Find(s => s.Id == id).FirstOrDefaultAsync();
        if (kayit == null) return NotFound("Servis kaydı bulunamadı.");

        var satir = kayit.Parcalar.FirstOrDefault(p => p.Id == satirId);
        if (satir == null) return NotFound("Parça satırı bulunamadı.");

        // Önce satırı kayıttan çıkar; satır gerçekten çıktıysa stoğa geri ekle.
        // Böylece iki kişi aynı anda "çıkar"a basarsa parça stoğa iki kere dönmez.
        var sonuc = await Veritabani.ServisKayitlari.UpdateOneAsync(
            s => s.Id == id,
            Builders<ServisKaydi>.Update.PullFilter(s => s.Parcalar, p => p.Id == satirId));
        if (sonuc.ModifiedCount > 0)
        {
            await Veritabani.Parcalar.UpdateOneAsync(
                p => p.Id == satir.ParcaId,
                Builders<Parca>.Update.Inc(p => p.StokAdedi, satir.Adet));
        }
        return Ok();
    }

    private static string? Dogrula(ServisKaydi kayit)
    {
        if (string.IsNullOrWhiteSpace(kayit.Cihaz)) return "Cihaz bilgisi boş olamaz.";
        if (string.IsNullOrWhiteSpace(kayit.Sorun)) return "Sorun boş olamaz.";
        if (!ServisDurumlari.Hepsi.Contains(kayit.Durum)) return "Geçersiz durum.";
        if (kayit.IscilikUcreti < 0) return "Ücret eksi olamaz.";
        return null;
    }

    // Seçilen teknisyenin adını kayda yazar. Teknisyen seçilmemesi de serbesttir.
    private static async Task<string?> TeknisyeniYaz(ServisKaydi kayit)
    {
        if (string.IsNullOrEmpty(kayit.TeknisyenId))
        {
            kayit.TeknisyenId = "";
            kayit.TeknisyenAdi = "";
            return null;
        }

        var teknisyen = await Veritabani.Kullanicilar.Find(k => k.Id == kayit.TeknisyenId).FirstOrDefaultAsync();
        if (teknisyen == null) return "Teknisyen bulunamadı.";
        if (!teknisyen.AktifMi) return "Pasif personele iş atanamaz.";

        kayit.TeknisyenAdi = teknisyen.AdSoyad;
        return null;
    }

    // Kayıt "Tamamlandı" ya da "Teslim edildi" olduğu anı not eder; geri alınırsa tarihi temizler.
    private static void TarihleriAyarla(ServisKaydi kayit)
    {
        if (kayit.Durum == ServisDurumlari.Beklemede || kayit.Durum == ServisDurumlari.DevamEdiyor)
        {
            kayit.TamamlanmaTarihi = null;
            kayit.TeslimTarihi = null;
        }
        if (kayit.Durum == ServisDurumlari.Tamamlandi)
        {
            kayit.TamamlanmaTarihi ??= DateTime.UtcNow;
            kayit.TeslimTarihi = null;
        }
        if (kayit.Durum == ServisDurumlari.TeslimEdildi)
        {
            kayit.TamamlanmaTarihi ??= DateTime.UtcNow;
            kayit.TeslimTarihi ??= DateTime.UtcNow;
        }
    }
}
