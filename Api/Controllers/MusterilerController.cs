using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api/musteriler")]
public class MusterilerController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Listele(string? arama)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var filtre = Builders<Musteri>.Filter.Empty;
        if (!string.IsNullOrWhiteSpace(arama))
        {
            var aranan = Arama.IcindeGecen(arama);
            filtre = Builders<Musteri>.Filter.Or(
                Builders<Musteri>.Filter.Regex(m => m.AdSoyad, aranan),
                Builders<Musteri>.Filter.Regex(m => m.Telefon, aranan));
        }

        var musteriler = await Veritabani.Musteriler.Find(filtre).SortBy(m => m.AdSoyad).ToListAsync();
        return Ok(musteriler);
    }

    [HttpPost]
    public async Task<IActionResult> Ekle(Musteri musteri)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        if (string.IsNullOrWhiteSpace(musteri.AdSoyad))
        {
            return BadRequest("Ad soyad boş olamaz.");
        }

        musteri.Id = Veritabani.YeniId();
        musteri.AdSoyad = musteri.AdSoyad.Trim();
        await Veritabani.Musteriler.InsertOneAsync(musteri);
        return Ok(musteri);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Guncelle(string id, Musteri musteri)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        if (string.IsNullOrWhiteSpace(musteri.AdSoyad))
        {
            return BadRequest("Ad soyad boş olamaz.");
        }

        var guncelleme = Builders<Musteri>.Update
            .Set(m => m.AdSoyad, musteri.AdSoyad.Trim())
            .Set(m => m.Telefon, musteri.Telefon)
            .Set(m => m.Email, musteri.Email)
            .Set(m => m.Adres, musteri.Adres);
        var sonuc = await Veritabani.Musteriler.UpdateOneAsync(m => m.Id == id, guncelleme);
        if (sonuc.MatchedCount == 0)
        {
            return NotFound("Müşteri bulunamadı.");
        }

        // Servis kayıtlarındaki ad ve telefon kopyalarını da yenile.
        await Veritabani.ServisKayitlari.UpdateManyAsync(
            s => s.MusteriId == id,
            Builders<ServisKaydi>.Update
                .Set(s => s.MusteriAdi, musteri.AdSoyad.Trim())
                .Set(s => s.MusteriTelefon, musteri.Telefon));
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Sil(string id)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        long kayitSayisi = await Veritabani.ServisKayitlari.CountDocumentsAsync(s => s.MusteriId == id);
        if (kayitSayisi > 0)
        {
            return BadRequest("Bu müşterinin servis kayıtları var, silinemez.");
        }

        await Veritabani.Musteriler.DeleteOneAsync(m => m.Id == id);
        return Ok();
    }
}
