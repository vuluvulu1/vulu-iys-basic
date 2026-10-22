namespace Modeller;

// Masaüstü ile API arasında giden gelen küçük paketler.

public class GirisIstegi
{
    public string KullaniciAdi { get; set; } = "";
    public string Sifre { get; set; } = "";
}

public class GirisCevabi
{
    public string Token { get; set; } = "";
    public Kullanici Kullanici { get; set; } = new();
}

public class SifreDegistirIstegi
{
    public string EskiSifre { get; set; } = "";
    public string YeniSifre { get; set; } = "";
}

// Personel eklerken ve düzenlerken gönderilir. Düzenlemede Sifre boş bırakılırsa şifre değişmez.
public class PersonelIstegi
{
    public string KullaniciAdi { get; set; } = "";
    public string AdSoyad { get; set; } = "";
    public string Telefon { get; set; } = "";
    public string Rol { get; set; } = Roller.Teknisyen;
    public bool StokYetkisi { get; set; }
    public bool AktifMi { get; set; } = true;
    public string Sifre { get; set; } = "";
}

// Artı adet stoğa ekler, eksi adet stoktan düşer (sayım düzeltmesi gibi).
public class StokGirisIstegi
{
    public int Adet { get; set; }
}

public class ParcaKullanIstegi
{
    public string ParcaId { get; set; } = "";
    public int Adet { get; set; }
}

public class TeklifIstegi
{
    public decimal Tutar { get; set; }
    public string Aciklama { get; set; } = "";
}

public class TeklifYanitIstegi
{
    public bool Onaylandi { get; set; }
    public string Not { get; set; } = "";
}

// İşlem geçmişine elle eklenen not, örn. "Müşteri yarın gelip alacak."
public class NotIstegi
{
    public string Metin { get; set; } = "";
}
