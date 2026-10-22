namespace Modeller;

public class ServisKaydi
{
    public string Id { get; set; } = "";

    // Yıl içinde sıralı kayıt numarası, örn. SK-2026-00042.
    public string No { get; set; } = "";

    public string MusteriId { get; set; } = "";
    // Listede her seferinde müşteriyi ayrıca aramamak için adı ve telefonu kayda da yazılır.
    public string MusteriAdi { get; set; } = "";
    public string MusteriTelefon { get; set; } = "";

    public string TeknisyenId { get; set; } = "";
    public string TeknisyenAdi { get; set; } = "";

    public string Cihaz { get; set; } = "";
    public string SeriNo { get; set; } = "";
    public string Sorun { get; set; } = "";
    public string Aksesuarlar { get; set; } = "";
    public string YapilanIslem { get; set; } = "";
    public string Durum { get; set; } = ServisDurumlari.Beklemede;

    public decimal IscilikUcreti { get; set; }
    public bool OdendiMi { get; set; }

    public List<KullanilanParca> Parcalar { get; set; } = [];

    public DateTime AcilisTarihi { get; set; } = DateTime.UtcNow;
    public DateTime? TamamlanmaTarihi { get; set; }
    public DateTime? TeslimTarihi { get; set; }

    public decimal ParcaToplami()
    {
        decimal toplam = 0;
        foreach (KullanilanParca parca in Parcalar)
        {
            toplam += parca.Tutar();
        }
        return toplam;
    }

    public decimal ToplamTutar()
    {
        return IscilikUcreti + ParcaToplami();
    }
}

// Servis kaydında kullanılan parça. Adı ve fiyatı kullanıldığı andaki değerdir;
// stok kartı sonradan değişse de eski kaydın tutarı değişmez.
public class KullanilanParca
{
    public string Id { get; set; } = "";
    public string ParcaId { get; set; } = "";
    public string Ad { get; set; } = "";
    public int Adet { get; set; }
    public decimal BirimFiyat { get; set; }

    public decimal Tutar()
    {
        return Adet * BirimFiyat;
    }
}

// Servis kaydının işlem geçmişindeki bir satır: kim, ne zaman, ne yaptı. Yalnızca eklenir, değiştirilmez.
public class IslemKaydi
{
    public string Id { get; set; } = "";
    public string ServisKaydiId { get; set; } = "";
    public DateTime Tarih { get; set; } = DateTime.UtcNow;
    public string KullaniciAdi { get; set; } = "";
    public string Aciklama { get; set; } = "";
}

public static class ServisDurumlari
{
    public const string Beklemede = "Beklemede";
    public const string DevamEdiyor = "Devam ediyor";
    public const string Tamamlandi = "Tamamlandı";
    public const string TeslimEdildi = "Teslim edildi";
    public const string IptalEdildi = "İptal edildi";

    public static readonly string[] Hepsi = [Beklemede, DevamEdiyor, Tamamlandi, TeslimEdildi, IptalEdildi];
}
