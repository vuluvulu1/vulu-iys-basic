using Modeller;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Api;

// Servis kabul formu (cihaz alınırken) ve teslim formu (cihaz verilirken) PDF olarak üretilir.
// İşletmenin adı, adresi ve kabul koşulları Isletme sınıfından gelir.
public static class ServisFormu
{
    private const string Kahve = "#5a3923";
    private const string Bakir = "#b5804f";
    private const string Gri = "#777777";

    public static byte[] Olustur(ServisKaydi kayit, bool teslimFormu)
    {
        string baslik = teslimFormu ? "CİHAZ TESLİM FORMU" : "SERVİS KABUL FORMU";

        var belge = Document.Create(belgeIcerigi =>
        {
            belgeIcerigi.Page(sayfa =>
            {
                sayfa.Size(PageSizes.A4);
                sayfa.Margin(40);
                sayfa.DefaultTextStyle(yazi => yazi.FontSize(10));

                sayfa.Header().Element(ust => UstKisim(ust, baslik, kayit));

                sayfa.Content().PaddingVertical(10).Column(sutun =>
                {
                    sutun.Spacing(4);

                    Bolum(sutun, "Müşteri");
                    Satir(sutun, "Ad soyad", kayit.MusteriAdi);
                    Satir(sutun, "Telefon", kayit.MusteriTelefon);

                    Bolum(sutun, "Cihaz");
                    Satir(sutun, "Cihaz", kayit.Cihaz);
                    Satir(sutun, "Seri no / IMEI", kayit.SeriNo);
                    Satir(sutun, "Aksesuarlar", kayit.Aksesuarlar);
                    Satir(sutun, "Bildirilen sorun", kayit.Sorun);

                    if (teslimFormu)
                    {
                        TeslimBilgileri(sutun, kayit);
                    }
                    else
                    {
                        KabulBilgileri(sutun, kayit);
                    }

                    sutun.Item().PaddingTop(30).Element(alt => ImzaAlanlari(alt, teslimFormu));
                });

                sayfa.Footer().AlignCenter().Text(yazi =>
                {
                    yazi.Span(Isletme.Ad + "  •  " + kayit.No).FontSize(8).FontColor(Gri);
                });
            });
        });

        return belge.GeneratePdf();
    }

    private static void UstKisim(IContainer alan, string baslik, ServisKaydi kayit)
    {
        alan.BorderBottom(2).BorderColor(Bakir).PaddingBottom(8).Row(satir =>
        {
            satir.RelativeItem().Column(sol =>
            {
                sol.Item().Text(Isletme.Ad).FontSize(16).Bold().FontColor(Kahve);
                sol.Item().Text(Isletme.Adres).FontSize(9).FontColor(Gri);
                sol.Item().Text(Isletme.Telefon).FontSize(9).FontColor(Gri);
            });

            satir.ConstantItem(200).AlignRight().Column(sag =>
            {
                sag.Item().AlignRight().Text(baslik).FontSize(13).Bold().FontColor(Bakir);
                sag.Item().AlignRight().Text("Kayıt no: " + kayit.No).SemiBold();
                sag.Item().AlignRight().Text("Tarih: " + TurkiyeSaati(DateTime.UtcNow)).FontSize(9);
            });
        });
    }

    private static void KabulBilgileri(ColumnDescriptor sutun, ServisKaydi kayit)
    {
        Satir(sutun, "Kabul tarihi", TurkiyeSaati(kayit.AcilisTarihi));

        Bolum(sutun, "Servis koşulları");
        sutun.Item().Text(Isletme.ServisKosullari).FontSize(9).FontColor(Gri);
    }

    private static void TeslimBilgileri(ColumnDescriptor sutun, ServisKaydi kayit)
    {
        Bolum(sutun, "Yapılan işlem");
        sutun.Item().Text(Bosluksuz(kayit.YapilanIslem));

        if (kayit.Parcalar.Count > 0)
        {
            Bolum(sutun, "Kullanılan parçalar");
            sutun.Item().Table(tablo =>
            {
                tablo.ColumnsDefinition(sutunlar =>
                {
                    sutunlar.RelativeColumn(4);
                    sutunlar.RelativeColumn(1);
                    sutunlar.RelativeColumn(2);
                    sutunlar.RelativeColumn(2);
                });

                tablo.Header(baslik =>
                {
                    baslik.Cell().Element(BaslikHucresi).Text("Parça");
                    baslik.Cell().Element(BaslikHucresi).AlignRight().Text("Adet");
                    baslik.Cell().Element(BaslikHucresi).AlignRight().Text("Birim fiyat");
                    baslik.Cell().Element(BaslikHucresi).AlignRight().Text("Tutar");
                });

                foreach (KullanilanParca parca in kayit.Parcalar)
                {
                    tablo.Cell().Element(Hucre).Text(parca.Ad);
                    tablo.Cell().Element(Hucre).AlignRight().Text(parca.Adet.ToString());
                    tablo.Cell().Element(Hucre).AlignRight().Text(Para(parca.BirimFiyat));
                    tablo.Cell().Element(Hucre).AlignRight().Text(Para(parca.Tutar()));
                }
            });
        }

        Bolum(sutun, "Ücret");
        Satir(sutun, "İşçilik", Para(kayit.IscilikUcreti));
        Satir(sutun, "Parçalar", Para(kayit.ParcaToplami()));
        sutun.Item().Row(satir =>
        {
            satir.ConstantItem(120).Text("Toplam").Bold();
            satir.RelativeItem().Text(Para(kayit.ToplamTutar())).Bold().FontSize(12);
        });
        Satir(sutun, "Ödeme", kayit.OdendiMi ? "Ödendi" : "Ödenmedi");
    }

    private static void ImzaAlanlari(IContainer alan, bool teslimFormu)
    {
        string sol = teslimFormu ? "Cihazı teslim alan (müşteri)" : "Cihazı teslim eden (müşteri)";
        string sag = teslimFormu ? "Cihazı teslim eden (işletme)" : "Cihazı teslim alan (işletme)";

        alan.Row(satir =>
        {
            satir.Spacing(40);
            satir.RelativeItem().Element(kutu => ImzaKutusu(kutu, sol));
            satir.RelativeItem().Element(kutu => ImzaKutusu(kutu, sag));
        });
    }

    private static void ImzaKutusu(IContainer alan, string baslik)
    {
        alan.Column(sutun =>
        {
            sutun.Item().Text(baslik).SemiBold();
            sutun.Item().Text("Ad soyad / imza").FontSize(8).FontColor(Gri);
            sutun.Item().Height(60).BorderBottom(1).BorderColor(Gri);
        });
    }

    private static void Bolum(ColumnDescriptor sutun, string baslik)
    {
        sutun.Item().PaddingTop(10).BorderBottom(1).BorderColor(Bakir).PaddingBottom(2)
            .Text(baslik).FontSize(11).SemiBold().FontColor(Kahve);
    }

    private static void Satir(ColumnDescriptor sutun, string baslik, string deger)
    {
        sutun.Item().Row(satir =>
        {
            satir.ConstantItem(120).Text(baslik).FontColor(Gri);
            satir.RelativeItem().Text(Bosluksuz(deger));
        });
    }

    private static IContainer BaslikHucresi(IContainer hucre)
    {
        return hucre.BorderBottom(1).BorderColor(Gri).PaddingVertical(3).DefaultTextStyle(yazi => yazi.SemiBold());
    }

    private static IContainer Hucre(IContainer hucre)
    {
        return hucre.BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(3);
    }

    private static string Bosluksuz(string metin)
    {
        if (string.IsNullOrWhiteSpace(metin))
        {
            return "-";
        }
        return metin;
    }

    private static string Para(decimal tutar)
    {
        return tutar.ToString("N2", new System.Globalization.CultureInfo("tr-TR")) + " TL";
    }

    // API başka ülkedeki bir sunucuda çalışsa da formdaki saat Türkiye saati olsun.
    private static string TurkiyeSaati(DateTime utc)
    {
        var turkiye = TimeZoneInfo.FindSystemTimeZoneById("Europe/Istanbul");
        return TimeZoneInfo.ConvertTimeFromUtc(DateTime.SpecifyKind(utc, DateTimeKind.Utc), turkiye).ToString("dd.MM.yyyy HH:mm");
    }
}
