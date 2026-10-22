using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api/kimlik")]
public class KimlikController : ControllerBase
{
    [HttpPost("giris")]
    public async Task<IActionResult> Giris(GirisIstegi istek)
    {
        string kullaniciAdi = istek.KullaniciAdi.Trim().ToLower();
        var kullanici = await Veritabani.Kullanicilar.Find(k => k.KullaniciAdi == kullaniciAdi).FirstOrDefaultAsync();

        // Kullanıcı adı mı şifre mi yanlış, bilerek söylemiyoruz.
        if (kullanici == null || !BCrypt.Net.BCrypt.Verify(istek.Sifre, kullanici.SifreHash))
        {
            return BadRequest("Kullanıcı adı ya da şifre yanlış.");
        }
        if (!kullanici.AktifMi)
        {
            return BadRequest("Bu hesap pasif durumda.");
        }

        var cevap = new GirisCevabi
        {
            Token = Oturumlar.Ac(kullanici.Id),
            Kullanici = kullanici
        };
        return Ok(cevap);
    }

    [HttpPost("cikis")]
    public IActionResult Cikis()
    {
        Oturumlar.Kapat(Request);
        return Ok();
    }

    [HttpPost("sifre-degistir")]
    public async Task<IActionResult> SifreDegistir(SifreDegistirIstegi istek)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        if (!BCrypt.Net.BCrypt.Verify(istek.EskiSifre, ben.SifreHash))
        {
            return BadRequest("Eski şifre yanlış.");
        }
        if (istek.YeniSifre.Length < 8)
        {
            return BadRequest("Yeni şifre en az 8 karakter olmalı.");
        }

        string yeniHash = BCrypt.Net.BCrypt.HashPassword(istek.YeniSifre);
        await Veritabani.Kullanicilar.UpdateOneAsync(
            k => k.Id == ben.Id,
            Builders<Kullanici>.Update.Set(k => k.SifreHash, yeniHash));
        return Ok();
    }
}
