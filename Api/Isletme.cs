namespace Api;

// Programı kullanan işletmenin bilgileri. Her işletmeye kendi API'si kurulur;
// bilgiler o API'nin appsettings.json dosyasındaki "Isletme" bölümünden okunur.
// Formların başlığında ve masaüstü programının menüsünde bu ad görünür.
public static class Isletme
{
    public static string Ad = "";
    public static string Adres = "";
    public static string Telefon = "";
    public static string ServisKosullari = "";

    public static void AyarlariOku(IConfiguration ayarlar)
    {
        Ad = ayarlar["Isletme:Ad"] ?? "";
        Adres = ayarlar["Isletme:Adres"] ?? "";
        Telefon = ayarlar["Isletme:Telefon"] ?? "";
        ServisKosullari = ayarlar["Isletme:ServisKosullari"] ?? "";
    }
}
