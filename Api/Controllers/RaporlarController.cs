using Microsoft.AspNetCore.Mvc;
using Modeller;
using MongoDB.Driver;

namespace Api.Controllers;

[ApiController]
[Route("api")]
public class RaporlarController : ControllerBase
{
    // Ana sayfadaki sayılar. Kayıtlar okunup hesap C# tarafında yapılır.
    [HttpGet("ozet")]
    public async Task<IActionResult> Ozet()
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();

        var kayitlar = await Veritabani.ServisKayitlari.Find(_ => true).ToListAsync();
        var parcalar = await Veritabani.Parcalar.Find(_ => true).ToListAsync();
        DateTime bugununBasi = DateTime.Today.ToUniversalTime();

        var ozet = new Ozet();
        foreach (ServisKaydi kayit in kayitlar)
        {
            if (kayit.Durum == ServisDurumlari.Beklemede || kayit.Durum == ServisDurumlari.OnayBekliyor
                || kayit.Durum == ServisDurumlari.DevamEdiyor)
            {
                ozet.AcikIsSayisi++;
            }
            if (kayit.Durum == ServisDurumlari.Tamamlandi)
            {
                ozet.TeslimBekleyenSayisi++;
            }
            if (kayit.AcilisTarihi >= bugununBasi)
            {
                ozet.BugunAcilanSayisi++;
            }
            if (kayit.Durum == ServisDurumlari.TeslimEdildi && !kayit.OdendiMi)
            {
                ozet.OdenmemisTutar += kayit.ToplamTutar();
            }
        }
        foreach (Parca parca in parcalar)
        {
            if (parca.StokAdedi <= parca.KritikSeviye)
            {
                ozet.KritikStokSayisi++;
            }
        }
        return Ok(ozet);
    }

    // Tarih aralığında açılan kayıtların dökümü. bitis tarihi dahil değildir.
    [HttpGet("rapor")]
    public async Task<IActionResult> Rapor(DateTime baslangic, DateTime bitis)
    {
        var ben = await Oturumlar.KullaniciyiBul(Request);
        if (ben == null) return Unauthorized();
        if (!ben.YoneticiMi()) return BadRequest("Raporları yalnızca yönetici görebilir.");

        DateTime bas = baslangic.ToUniversalTime();
        DateTime bit = bitis.ToUniversalTime();
        var kayitlar = await Veritabani.ServisKayitlari
            .Find(s => s.AcilisTarihi >= bas && s.AcilisTarihi < bit)
            .ToListAsync();

        var rapor = new Rapor();
        var teknisyenler = new Dictionary<string, TeknisyenSatiri>();
        var parcalar = new Dictionary<string, ParcaSatiri>();

        foreach (ServisKaydi kayit in kayitlar)
        {
            rapor.AcilanIs++;

            if (kayit.Durum == ServisDurumlari.IptalEdildi)
            {
                rapor.IptalEdilenIs++;
                continue;
            }
            if (kayit.Durum == ServisDurumlari.Tamamlandi || kayit.Durum == ServisDurumlari.TeslimEdildi)
            {
                rapor.TamamlananIs++;
            }

            decimal tutar = kayit.ToplamTutar();
            rapor.ToplamTutar += tutar;
            if (kayit.OdendiMi)
            {
                rapor.TahsilEdilen += tutar;
            }

            string teknisyenAdi = kayit.TeknisyenAdi;
            if (teknisyenAdi == "")
            {
                teknisyenAdi = "(Atanmamış)";
            }
            if (!teknisyenler.ContainsKey(teknisyenAdi))
            {
                teknisyenler[teknisyenAdi] = new TeknisyenSatiri { TeknisyenAdi = teknisyenAdi };
            }
            teknisyenler[teknisyenAdi].IsSayisi++;
            teknisyenler[teknisyenAdi].Tutar += tutar;

            foreach (KullanilanParca parca in kayit.Parcalar)
            {
                if (!parcalar.ContainsKey(parca.Ad))
                {
                    parcalar[parca.Ad] = new ParcaSatiri { ParcaAdi = parca.Ad };
                }
                parcalar[parca.Ad].Adet += parca.Adet;
            }
        }

        rapor.Teknisyenler = teknisyenler.Values.OrderByDescending(t => t.IsSayisi).ToList();
        rapor.EnCokKullanilanParcalar = parcalar.Values.OrderByDescending(p => p.Adet).Take(10).ToList();
        return Ok(rapor);
    }
}
