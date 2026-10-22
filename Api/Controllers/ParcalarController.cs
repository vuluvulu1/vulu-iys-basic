using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api/parcalar")]
public class ParcalarController : ControllerBase
{
    // Stoğu herkes görür; kartları yalnızca yönetici ve stok yetkisi olan personel düzenler.
    [HttpGet]
    public async Task<IActionResult> Listele(string? arama)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var filtre = Builders<Parca>.Filter.Empty;
        if (!string.IsNullOrWhiteSpace(arama))
        {
            var aranan = Arama.IcindeGecen(arama);
            filtre = Builders<Parca>.Filter.Or(
                Builders<Parca>.Filter.Regex(p => p.Ad, aranan),
                Builders<Parca>.Filter.Regex(p => p.Kod, aranan));
        }

        var parcalar = await Veritabani.Parcalar.Find(filtre).SortBy(p => p.Ad).ToListAsync();
        return Ok(parcalar);
    }

    [HttpPost]
    public async Task<IActionResult> Ekle(Parca parca)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.StokDuzenleyebilirMi()) return BadRequest("Stok düzenleme yetkiniz yok.");

        string? hata = Dogrula(parca);
        if (hata != null) return BadRequest(hata);
        if (parca.StokAdedi < 0) return BadRequest("Stok adedi eksi olamaz.");

        parca.Id = Veritabani.YeniId();
        parca.Ad = parca.Ad.Trim();
        await Veritabani.Parcalar.InsertOneAsync(parca);
        return Ok(parca);
    }

    // Stok adedi burada değişmez, onun için stok girişi kullanılır.
    [HttpPut("{id}")]
    public async Task<IActionResult> Guncelle(string id, Parca parca)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.StokDuzenleyebilirMi()) return BadRequest("Stok düzenleme yetkiniz yok.");

        string? hata = Dogrula(parca);
        if (hata != null) return BadRequest(hata);

        var guncelleme = Builders<Parca>.Update
            .Set(p => p.Ad, parca.Ad.Trim())
            .Set(p => p.Kod, parca.Kod)
            .Set(p => p.BirimFiyat, parca.BirimFiyat)
            .Set(p => p.KritikSeviye, parca.KritikSeviye);
        var sonuc = await Veritabani.Parcalar.UpdateOneAsync(p => p.Id == id, guncelleme);
        if (sonuc.MatchedCount == 0) return NotFound("Parça bulunamadı.");
        return Ok();
    }

    // Servis kayıtları parçanın adını ve fiyatını kendi içinde tuttuğu için kart silinse de eski kayıtlar bozulmaz.
    [HttpDelete("{id}")]
    public async Task<IActionResult> Sil(string id)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.StokDuzenleyebilirMi()) return BadRequest("Stok düzenleme yetkiniz yok.");

        await Veritabani.Parcalar.DeleteOneAsync(p => p.Id == id);
        return Ok();
    }

    [HttpPost("{id}/stok-giris")]
    public async Task<IActionResult> StokGirisi(string id, StokGirisIstegi istek)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.StokDuzenleyebilirMi()) return BadRequest("Stok düzenleme yetkiniz yok.");
        if (istek.Adet == 0) return BadRequest("Adet sıfır olamaz.");

        // Filtrede "stok, düşülecek adetten az değil" şartı da var; böylece stok hiçbir zaman eksiye inmez.
        // Kontrol ve güncelleme tek komutta yapıldığı için aynı anda gelen iki istek de bu kuralı bozamaz.
        int dusulecek = 0;
        if (istek.Adet < 0)
        {
            dusulecek = -istek.Adet;
        }

        var sonuc = await Veritabani.Parcalar.UpdateOneAsync(
            p => p.Id == id && p.StokAdedi >= dusulecek,
            Builders<Parca>.Update.Inc(p => p.StokAdedi, istek.Adet));
        if (sonuc.MatchedCount == 0) return BadRequest("Parça bulunamadı ya da stok yetersiz.");
        return Ok();
    }

    private static string? Dogrula(Parca parca)
    {
        if (string.IsNullOrWhiteSpace(parca.Ad)) return "Parça adı boş olamaz.";
        if (parca.BirimFiyat < 0) return "Fiyat eksi olamaz.";
        if (parca.KritikSeviye < 0) return "Kritik seviye eksi olamaz.";
        return null;
    }
}
