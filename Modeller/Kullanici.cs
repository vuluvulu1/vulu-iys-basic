using System.Text.Json.Serialization;

namespace Modeller;

// Personel hesabı. Sisteme giriş yapan kişi ile servis kaydının atandığı teknisyen aynı kayıttır.
public class Kullanici
{
    public string Id { get; set; } = "";
    public string KullaniciAdi { get; set; } = "";

    // Şifrenin kendisi değil, BCrypt ile karıştırılmış hali saklanır.
    // JsonIgnore sayesinde API bu alanı masaüstüne hiç göndermez.
    [JsonIgnore]
    public string SifreHash { get; set; } = "";

    public string AdSoyad { get; set; } = "";
    public string Telefon { get; set; } = "";
    public string Rol { get; set; } = Roller.Teknisyen;

    // Yönetici olmayan personelin de stok kartlarını düzenleyebilmesi için.
    public bool StokYetkisi { get; set; }

    // Pasif hesap giriş yapamaz ve yeni iş atanamaz.
    public bool AktifMi { get; set; } = true;

    public bool YoneticiMi()
    {
        return Rol == Roller.Yonetici;
    }

    public bool StokDuzenleyebilirMi()
    {
        return Rol == Roller.Yonetici || StokYetkisi;
    }
}

public static class Roller
{
    public const string Yonetici = "Yönetici";
    public const string Teknisyen = "Teknisyen";

    public static readonly string[] Hepsi = [Yonetici, Teknisyen];
}
