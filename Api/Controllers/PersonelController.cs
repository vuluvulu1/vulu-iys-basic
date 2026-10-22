using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api/personel")]
public class PersonelController : ControllerBase
{
    // Herkes listeyi görebilir; servis kaydına teknisyen seçerken gerekiyor.
    [HttpGet]
    public async Task<IActionResult> Listele()
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var personel = await Veritabani.Kullanicilar.Find(_ => true).SortBy(k => k.AdSoyad).ToListAsync();
        return Ok(personel);
    }

    [HttpPost]
    public async Task<IActionResult> Ekle(PersonelIstegi istek)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.YoneticiMi()) return BadRequest("Bu işlem için yönetici olmalısınız.");

        string? hata = Dogrula(istek);
        if (hata != null) return BadRequest(hata);
        if (istek.Sifre.Length < 8) return BadRequest("Şifre en az 8 karakter olmalı.");

        string kullaniciAdi = istek.KullaniciAdi.Trim().ToLower();
        long ayniAdli = await Veritabani.Kullanicilar.CountDocumentsAsync(k => k.KullaniciAdi == kullaniciAdi);
        if (ayniAdli > 0) return BadRequest("Bu kullanıcı adı zaten kullanılıyor.");

        var kullanici = new Kullanici
        {
            Id = Veritabani.YeniId(),
            KullaniciAdi = kullaniciAdi,
            SifreHash = BCrypt.Net.BCrypt.HashPassword(istek.Sifre),
            AdSoyad = istek.AdSoyad.Trim(),
            Telefon = istek.Telefon,
            Rol = istek.Rol,
            StokYetkisi = istek.StokYetkisi,
            AktifMi = istek.AktifMi
        };
        await Veritabani.Kullanicilar.InsertOneAsync(kullanici);
        return Ok(kullanici);
    }

    // Kullanıcı adı açıldıktan sonra değişmez. Sifre boş gelirse şifreye dokunulmaz.
    [HttpPut("{id}")]
    public async Task<IActionResult> Guncelle(string id, PersonelIstegi istek)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.YoneticiMi()) return BadRequest("Bu işlem için yönetici olmalısınız.");

        string? hata = Dogrula(istek);
        if (hata != null) return BadRequest(hata);

        // Yönetici kendini pasif yapıp ya da yetkisini alıp sistemi yöneticisiz bırakmasın.
        if (id == ben.Id && (!istek.AktifMi || istek.Rol != Roller.Yonetici))
        {
            return BadRequest("Kendi hesabınızı pasif yapamaz ya da yöneticilikten çıkaramazsınız.");
        }

        var guncelleme = Builders<Kullanici>.Update
            .Set(k => k.AdSoyad, istek.AdSoyad.Trim())
            .Set(k => k.Telefon, istek.Telefon)
            .Set(k => k.Rol, istek.Rol)
            .Set(k => k.StokYetkisi, istek.StokYetkisi)
            .Set(k => k.AktifMi, istek.AktifMi);

        if (istek.Sifre != "")
        {
            if (istek.Sifre.Length < 8) return BadRequest("Şifre en az 8 karakter olmalı.");
            guncelleme = guncelleme.Set(k => k.SifreHash, BCrypt.Net.BCrypt.HashPassword(istek.Sifre));
        }

        var sonuc = await Veritabani.Kullanicilar.UpdateOneAsync(k => k.Id == id, guncelleme);
        if (sonuc.MatchedCount == 0) return NotFound("Personel bulunamadı.");

        // Adı değiştiyse servis kayıtlarındaki kopyayı da yenile.
        await Veritabani.ServisKayitlari.UpdateManyAsync(
            s => s.TeknisyenId == id,
            Builders<ServisKaydi>.Update.Set(s => s.TeknisyenAdi, istek.AdSoyad.Trim()));
        return Ok();
    }

    private static string? Dogrula(PersonelIstegi istek)
    {
        if (string.IsNullOrWhiteSpace(istek.KullaniciAdi)) return "Kullanıcı adı boş olamaz.";
        if (string.IsNullOrWhiteSpace(istek.AdSoyad)) return "Ad soyad boş olamaz.";
        if (!Roller.Hepsi.Contains(istek.Rol)) return "Geçersiz rol.";
        return null;
    }
}
