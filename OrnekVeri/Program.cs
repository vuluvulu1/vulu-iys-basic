using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Modeller;

// Sunum için bir işletmenin veritabanını API üzerinden örnek bilgilerle doldurur:
// personel, stok, müşteriler ve farklı durumlarda servis kayıtları (parçaları, notları ve geçmişiyle).
// Çalıştırmak için: dotnet run --project OrnekVeri

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

string adres = Sor("API adresi", "https://vulu-iys-basic.onrender.com");
string kullaniciAdi = Sor("Yönetici kullanıcı adı", "admin");
string sifre = SifreSor("Yönetici şifresi");

Console.WriteLine("API'ye bağlanılıyor... (Render uyuyorsa bir dakika kadar sürebilir)");
Istemci yonetici;
try
{
    yonetici = await Istemci.GirisYap(adres, kullaniciAdi, sifre);
}
catch (Exception hata)
{
    Console.WriteLine("Giriş yapılamadı: " + hata.Message);
    return;
}

List<Musteri> mevcutMusteriler = await yonetici.Getir<List<Musteri>>("api/musteriler");
if (mevcutMusteriler.Count > 0)
{
    Console.Write("Veritabanında zaten " + mevcutMusteriler.Count + " müşteri var. Örnek bilgiler yine de eklensin mi? (e/h): ");
    if (Console.ReadLine()?.Trim().ToLower() != "e")
    {
        return;
    }
}

// --- Personel ---
// Hepsinin şifresi aynı; sunumda teknisyen olarak da giriş yapılabilsin diye.
const string PersonelSifresi = "Sunum2026";
var personelListesi = new[]
{
    new PersonelIstegi { KullaniciAdi = "emre", AdSoyad = "Emre Yılmaz", Telefon = "0555 101 01 01", Rol = Roller.Teknisyen },
    new PersonelIstegi { KullaniciAdi = "selin", AdSoyad = "Selin Aydın", Telefon = "0555 101 01 02", Rol = Roller.Teknisyen, StokYetkisi = true },
    new PersonelIstegi { KullaniciAdi = "burak", AdSoyad = "Burak Kaya", Telefon = "0555 101 01 03", Rol = Roller.Teknisyen },
    new PersonelIstegi { KullaniciAdi = "oguz", AdSoyad = "Oğuz Demir", Telefon = "0555 101 01 04", Rol = Roller.Teknisyen },
};

Console.WriteLine("Personel ekleniyor...");
var teknisyenler = new Dictionary<string, Kullanici>();
var teknisyenIstemcileri = new Dictionary<string, Istemci>();
List<Kullanici> mevcutPersonel = await yonetici.Getir<List<Kullanici>>("api/personel");
foreach (PersonelIstegi istek in personelListesi)
{
    istek.Sifre = PersonelSifresi;
    Kullanici? kisi = mevcutPersonel.FirstOrDefault(k => k.KullaniciAdi == istek.KullaniciAdi);
    if (kisi == null)
    {
        kisi = await yonetici.Gonder<Kullanici>("api/personel", istek);
        // Kayıtlardaki işlemler o teknisyenin hesabıyla yapılır; işlem geçmişinde onun adı görünür.
        teknisyenIstemcileri[kisi.KullaniciAdi] = await Istemci.GirisYap(adres, kisi.KullaniciAdi, PersonelSifresi);
    }
    else
    {
        // Hesap zaten varsa şifresini bilmiyoruz; onun işlemlerini yönetici yapar.
        teknisyenIstemcileri[kisi.KullaniciAdi] = yonetici;
    }
    teknisyenler[kisi.KullaniciAdi] = kisi;
}

// --- Stok ---
Console.WriteLine("Stok kartları ekleniyor...");
var parcaListesi = new[]
{
    new Parca { Ad = "iPhone 11 Ekran (Orijinal)", Kod = "IP11-EKR", BirimFiyat = 3250, StokAdedi = 6, KritikSeviye = 2 },
    new Parca { Ad = "iPhone 13 Batarya", Kod = "IP13-BAT", BirimFiyat = 1450, StokAdedi = 8, KritikSeviye = 3 },
    new Parca { Ad = "Samsung Galaxy A54 Ekran", Kod = "SM-A54-EKR", BirimFiyat = 2850, StokAdedi = 4, KritikSeviye = 2 },
    new Parca { Ad = "Samsung Şarj Soketi (Type-C)", Kod = "SM-SOKET", BirimFiyat = 180, StokAdedi = 15, KritikSeviye = 5 },
    new Parca { Ad = "Redmi Note 12 Ekran", Kod = "XR12-EKR", BirimFiyat = 1650, StokAdedi = 3, KritikSeviye = 2 },
    new Parca { Ad = "Samsung 870 EVO SSD 500 GB", Kod = "SSD-500", BirimFiyat = 2100, StokAdedi = 10, KritikSeviye = 3 },
    new Parca { Ad = "Kingston 8 GB DDR4 RAM", Kod = "RAM-8GB", BirimFiyat = 950, StokAdedi = 12, KritikSeviye = 4 },
    new Parca { Ad = "Lenovo Laptop Klavyesi", Kod = "KLV-LNV", BirimFiyat = 850, StokAdedi = 3, KritikSeviye = 2 },
    new Parca { Ad = "Arctic MX-4 Termal Macun", Kod = "TRM-MX4", BirimFiyat = 220, StokAdedi = 20, KritikSeviye = 5 },
    new Parca { Ad = "HP Laptop Fanı", Kod = "FAN-HP", BirimFiyat = 480, StokAdedi = 2, KritikSeviye = 2 },
    new Parca { Ad = "65W Laptop Adaptörü", Kod = "ADP-65W", BirimFiyat = 690, StokAdedi = 5, KritikSeviye = 2 },
    new Parca { Ad = "Laptop HDMI Portu", Kod = "HDMI-PRT", BirimFiyat = 150, StokAdedi = 1, KritikSeviye = 3 },
};
var parcalar = new Dictionary<string, Parca>();
foreach (Parca parca in parcaListesi)
{
    Parca eklenen = await yonetici.Gonder<Parca>("api/parcalar", parca);
    parcalar[eklenen.Kod] = eklenen;
}

// --- Müşteriler ---
Console.WriteLine("Müşteriler ekleniyor...");
var musteriListesi = new[]
{
    new Musteri { AdSoyad = "Ahmet Şahin", Telefon = "0555 201 11 01", Email = "ahmet.sahin@ornek.com", Adres = "Cumhuriyet Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Ayşe Kaplan", Telefon = "0555 201 11 02", Email = "ayse.kaplan@ornek.com", Adres = "Kültür Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Mehmet Öztürk", Telefon = "0555 201 11 03", Adres = "Akçakoca / Düzce" },
    new Musteri { AdSoyad = "Fatma Arslan", Telefon = "0555 201 11 04", Email = "fatma.arslan@ornek.com", Adres = "Gölyaka / Düzce" },
    new Musteri { AdSoyad = "Mustafa Koç", Telefon = "0555 201 11 05", Adres = "Cedidiye Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Zeynep Doğan", Telefon = "0555 201 11 06", Email = "zeynep.dogan@ornek.com", Adres = "Kaynaşlı / Düzce" },
    new Musteri { AdSoyad = "Hüseyin Aksoy", Telefon = "0555 201 11 07", Adres = "Çilimli / Düzce" },
    new Musteri { AdSoyad = "Elif Yıldırım", Telefon = "0555 201 11 08", Email = "elif.yildirim@ornek.com", Adres = "Konuralp, Merkez / Düzce" },
    new Musteri { AdSoyad = "Ali Kılıç", Telefon = "0555 201 11 09", Adres = "Gümüşova / Düzce" },
    new Musteri { AdSoyad = "Hatice Çetin", Telefon = "0555 201 11 10", Adres = "Cumayeri / Düzce" },
    new Musteri { AdSoyad = "Murat Aslan", Telefon = "0555 201 11 11", Email = "murat.aslan@ornek.com", Adres = "Yörük Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Emine Kurt", Telefon = "0555 201 11 12", Adres = "Azmimilli Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Can Özdemir", Telefon = "0555 201 11 13", Email = "can.ozdemir@ornek.com", Adres = "Konuralp Yerleşkesi, Düzce" },
    new Musteri { AdSoyad = "Deniz Tekin", Telefon = "0555 201 11 14", Adres = "Şerefiye Mah., Merkez / Düzce" },
    new Musteri { AdSoyad = "Okan Polat", Telefon = "0555 201 11 15", Adres = "Akçakoca / Düzce" },
};
var musteriler = new Dictionary<string, Musteri>();
foreach (Musteri musteri in musteriListesi)
{
    Musteri eklenen = await yonetici.Gonder<Musteri>("api/musteriler", musteri);
    musteriler[eklenen.AdSoyad] = eklenen;
}

// --- Servis kayıtları ---
// Teknisyeni boş olan kayıt henüz kimseye atanmamıştır. Parçalar "kod" ya da "kod*adet" biçiminde yazılır.
var kayitListesi = new[]
{
    new OrnekKayit("Ahmet Şahin", "emre", "iPhone 11", "356789104455221", "Ekran kırık, dokunmatik çalışmıyor.", "Kılıf",
        "Ekran değiştirildi, dokunmatik ve Face ID test edildi.", ServisDurumlari.TeslimEdildi, 500, true, ["IP11-EKR"],
        ["Müşteri arandı, cihazın hazır olduğu bildirildi."]),
    new OrnekKayit("Ayşe Kaplan", "burak", "Lenovo IdeaPad 3", "PF3K8Z21", "Çok ısınıyor, kendi kendine kapanıyor.", "Adaptör",
        "Fan ve soğutucu temizlendi, termal macun yenilendi.", ServisDurumlari.TeslimEdildi, 600, true, ["TRM-MX4"], []),
    new OrnekKayit("Mehmet Öztürk", "emre", "Samsung Galaxy A54", "R58T30XK2LM", "Şarj olmuyor.", "",
        "Şarj soketi değiştirildi.", ServisDurumlari.Tamamlandi, 350, false, ["SM-SOKET"],
        ["Müşteri cuma günü gelip alacak."]),
    new OrnekKayit("Fatma Arslan", "burak", "HP Pavilion 15", "5CD1234XYZ", "Açılıyor ama çok yavaş çalışıyor.", "Adaptör, çanta",
        "SSD takıldı, RAM 16 GB'a çıkarıldı, Windows kuruldu ve veriler aktarıldı.", ServisDurumlari.TeslimEdildi, 750, true,
        ["SSD-500", "RAM-8GB"], ["Müşteri yedeklenecek klasörleri listeledi: Masaüstü ve Belgeler."]),
    new OrnekKayit("Mustafa Koç", "selin", "iPhone 13", "353912110987654", "Batarya çabuk bitiyor, pil sağlığı %72.", "",
        "Batarya değiştirildi.", ServisDurumlari.TeslimEdildi, 400, false, ["IP13-BAT"],
        ["Ödeme ay sonunda yapılacak."]),
    new OrnekKayit("Zeynep Doğan", "emre", "Redmi Note 12", "86542301239876", "Düştü, ekranda çizgiler var.", "Kılıf",
        "", ServisDurumlari.DevamEdiyor, 300, false, ["XR12-EKR"], ["Parça geldi, montaj yapılıyor."]),
    new OrnekKayit("Hüseyin Aksoy", "burak", "Casper Excalibur G770", "G770-2203-1188", "Oyun açarken mavi ekran veriyor.", "Adaptör",
        "", ServisDurumlari.DevamEdiyor, 0, false, [], ["Bellek testi yapılıyor."]),
    new OrnekKayit("Elif Yıldırım", "", "Samsung Galaxy S21", "R5CR20ABC12", "Kamera bulanık çekiyor.", "",
        "", ServisDurumlari.Beklemede, 0, false, [], ["Ön kamera mı arka kamera mı olduğu müşteriye soruldu."]),
    new OrnekKayit("Ali Kılıç", "selin", "Lenovo ThinkPad E14", "PF2ABC34", "Klavyeye çay döküldü, bazı tuşlar basmıyor.", "Adaptör",
        "Klavye değiştirildi, anakart temizlendi.", ServisDurumlari.Tamamlandi, 450, false, ["KLV-LNV"], []),
    new OrnekKayit("Hatice Çetin", "oguz", "HP 250 G8", "5CG0987ABC", "Fan çok ses yapıyor.", "",
        "Fan değiştirildi.", ServisDurumlari.TeslimEdildi, 300, true, ["FAN-HP"], []),
    new OrnekKayit("Murat Aslan", "oguz", "Asus VivoBook 15", "M1NRKD012345", "Adaptör bozuldu, şarj olmuyor.", "",
        "Yeni adaptör verildi, şarj test edildi.", ServisDurumlari.TeslimEdildi, 0, true, ["ADP-65W"], []),
    new OrnekKayit("Emine Kurt", "emre", "iPhone 11", "356789109988776", "Ekran kırık.", "Kılıf, şarj kablosu",
        "", ServisDurumlari.DevamEdiyor, 500, false, ["IP11-EKR"], []),
    new OrnekKayit("Can Özdemir", "", "MSI Modern 14", "K2104N0012345", "HDMI çıkışı görüntü vermiyor.", "Adaptör",
        "", ServisDurumlari.Beklemede, 0, false, [], ["Stokta HDMI portu az, sipariş edildi."]),
    new OrnekKayit("Deniz Tekin", "selin", "Samsung Galaxy A54", "R58T30AB9QW", "Ekran ara ara kararıyor.", "",
        "Ekran değiştirildi.", ServisDurumlari.Tamamlandi, 400, false, ["SM-A54-EKR"], []),
    new OrnekKayit("Okan Polat", "burak", "Toshiba Satellite C55", "1F123456Q", "Hiç açılmıyor.", "Adaptör",
        "Anakart arızası tespit edildi; onarım ekonomik değil.", ServisDurumlari.IptalEdildi, 0, false, [],
        ["Müşteri onarım istemedi, cihaz iade edilecek."]),
    new OrnekKayit("Ahmet Şahin", "", "Lenovo Tab M10", "HA1B2C3D", "Şarj soketi gevşek.", "",
        "", ServisDurumlari.Beklemede, 0, false, [], []),
    new OrnekKayit("Ayşe Kaplan", "selin", "iPhone 13", "353912119876543", "Batarya şişti.", "",
        "Batarya değiştirildi.", ServisDurumlari.TeslimEdildi, 400, true, ["IP13-BAT"], []),
    new OrnekKayit("Fatma Arslan", "emre", "Samsung Galaxy A54", "R58T30CD7ZX", "Şarj kablosu takılınca gevşek duruyor.", "",
        "", ServisDurumlari.DevamEdiyor, 350, false, ["SM-SOKET"], []),
    new OrnekKayit("Mehmet Öztürk", "burak", "HP Pavilion 15", "5CD5678QWE", "Bellek yetersiz, programlar donuyor.", "",
        "RAM 8 GB'tan 24 GB'a çıkarıldı.", ServisDurumlari.TeslimEdildi, 200, true, ["RAM-8GB*2"], []),
    new OrnekKayit("Zeynep Doğan", "oguz", "Casper Nirvana C350", "C350-1911-7744", "Windows açılmıyor.", "Adaptör",
        "Windows yeniden kuruldu, sürücüler yüklendi.", ServisDurumlari.Tamamlandi, 400, false, [], []),
};

Console.WriteLine("Servis kayıtları ekleniyor...");
foreach (OrnekKayit ornek in kayitListesi)
{
    // İşlemleri kayda atanan teknisyen yapar; atanmamış kaydı yönetici açar.
    Istemci kim = yonetici;
    string teknisyenId = "";
    if (ornek.Teknisyen != "")
    {
        kim = teknisyenIstemcileri[ornek.Teknisyen];
        teknisyenId = teknisyenler[ornek.Teknisyen].Id;
    }

    var kayit = new ServisKaydi
    {
        MusteriId = musteriler[ornek.Musteri].Id,
        TeknisyenId = teknisyenId,
        Cihaz = ornek.Cihaz,
        SeriNo = ornek.SeriNo,
        Sorun = ornek.Sorun,
        Aksesuarlar = ornek.Aksesuarlar,
        Durum = ServisDurumlari.Beklemede
    };
    kayit = await kim.Gonder<ServisKaydi>("api/servis-kayitlari", kayit);

    // Parçalar teslimden önce eklenir; teslim edilmiş kayda parça eklenemez.
    foreach (string yazi in ornek.Parcalar)
    {
        string[] bolumler = yazi.Split('*');
        int adet = bolumler.Length > 1 ? int.Parse(bolumler[1]) : 1;
        var istek = new ParcaKullanIstegi { ParcaId = parcalar[bolumler[0]].Id, Adet = adet };
        await kim.Gonder<KullanilanParca>("api/servis-kayitlari/" + kayit.Id + "/parcalar", istek);
    }

    // Kayıt son durumuna gerçekteki gibi adım adım gelir; her adım işlem geçmişine yazılır.
    var adimlar = new List<string>();
    if (ornek.Durum == ServisDurumlari.DevamEdiyor) adimlar.Add(ServisDurumlari.DevamEdiyor);
    if (ornek.Durum == ServisDurumlari.Tamamlandi) adimlar.AddRange([ServisDurumlari.DevamEdiyor, ServisDurumlari.Tamamlandi]);
    if (ornek.Durum == ServisDurumlari.TeslimEdildi)
        adimlar.AddRange([ServisDurumlari.DevamEdiyor, ServisDurumlari.Tamamlandi, ServisDurumlari.TeslimEdildi]);
    if (ornek.Durum == ServisDurumlari.IptalEdildi) adimlar.Add(ServisDurumlari.IptalEdildi);

    foreach (string durum in adimlar)
    {
        kayit.Durum = durum;
        // Yapılan işlem, ücret ve ödeme bilgisi son adımda girilir.
        if (durum == ornek.Durum)
        {
            kayit.YapilanIslem = ornek.YapilanIslem;
            kayit.IscilikUcreti = ornek.Iscilik;
            kayit.OdendiMi = ornek.Odendi;
        }
        await kim.Guncelle("api/servis-kayitlari/" + kayit.Id, kayit);
    }

    foreach (string not in ornek.Notlar)
    {
        await kim.Gonder("api/servis-kayitlari/" + kayit.Id + "/notlar", new NotIstegi { Metin = not });
    }
    Console.WriteLine("  " + kayit.No + "  " + ornek.Musteri + " - " + ornek.Cihaz + " (" + ornek.Durum + ")");
}

// Oğuz işten ayrılmış gibi pasif yapılır: eski kayıtlarında adı kalır, yeni iş atanamaz, giriş yapamaz.
Kullanici oguz = teknisyenler["oguz"];
await yonetici.Guncelle("api/personel/" + oguz.Id, new PersonelIstegi
{
    KullaniciAdi = oguz.KullaniciAdi,
    AdSoyad = oguz.AdSoyad,
    Telefon = oguz.Telefon,
    Rol = oguz.Rol,
    StokYetkisi = oguz.StokYetkisi,
    AktifMi = false
});

Console.WriteLine();
Console.WriteLine("Bitti. " + personelListesi.Length + " personel, " + parcaListesi.Length + " parça, "
    + musteriListesi.Length + " müşteri ve " + kayitListesi.Length + " servis kaydı eklendi.");
Console.WriteLine("Teknisyenler (emre, selin, burak) \"" + PersonelSifresi + "\" şifresiyle giriş yapabilir; oguz pasif.");


static string Sor(string soru, string varsayilan)
{
    Console.Write(soru + " [" + varsayilan + "]: ");
    string cevap = Console.ReadLine()?.Trim() ?? "";
    return cevap == "" ? varsayilan : cevap;
}

// Şifre yazılırken ekranda görünmesin diye her harfin yerine * yazılır.
static string SifreSor(string soru)
{
    Console.Write(soru + ": ");
    if (Console.IsInputRedirected)
    {
        // Girdi bir dosyadan geliyorsa tuş tuş okunamaz.
        return Console.ReadLine() ?? "";
    }

    string sifre = "";
    while (true)
    {
        ConsoleKeyInfo tus = Console.ReadKey(true);
        if (tus.Key == ConsoleKey.Enter)
        {
            break;
        }
        if (tus.Key == ConsoleKey.Backspace)
        {
            if (sifre.Length > 0)
            {
                sifre = sifre.Substring(0, sifre.Length - 1);
                Console.Write("\b \b");
            }
            continue;
        }
        sifre += tus.KeyChar;
        Console.Write("*");
    }
    Console.WriteLine();
    return sifre;
}

// Bir servis kaydının örnek bilgileri.
record OrnekKayit(string Musteri, string Teknisyen, string Cihaz, string SeriNo, string Sorun, string Aksesuarlar,
    string YapilanIslem, string Durum, decimal Iscilik, bool Odendi, string[] Parcalar, string[] Notlar);

// Bir kullanıcının oturumuyla API'ye istek gönderir.
class Istemci
{
    private readonly HttpClient istemci;

    private Istemci(HttpClient istemci)
    {
        this.istemci = istemci;
    }

    public static async Task<Istemci> GirisYap(string adres, string kullaniciAdi, string sifre)
    {
        var http = new HttpClient { BaseAddress = new Uri(adres.TrimEnd('/') + "/"), Timeout = TimeSpan.FromSeconds(120) };
        var cevap = await http.PostAsJsonAsync("api/kimlik/giris", new GirisIstegi { KullaniciAdi = kullaniciAdi, Sifre = sifre });
        await HataVarsaBildir(cevap);
        GirisCevabi giris = (await cevap.Content.ReadFromJsonAsync<GirisCevabi>())!;
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", giris.Token);
        return new Istemci(http);
    }

    public async Task<T> Getir<T>(string yol)
    {
        var cevap = await istemci.GetAsync(yol);
        await HataVarsaBildir(cevap);
        return (await cevap.Content.ReadFromJsonAsync<T>())!;
    }

    public async Task<T> Gonder<T>(string yol, object veri)
    {
        var cevap = await istemci.PostAsJsonAsync(yol, veri);
        await HataVarsaBildir(cevap);
        return (await cevap.Content.ReadFromJsonAsync<T>())!;
    }

    public async Task Gonder(string yol, object veri)
    {
        await HataVarsaBildir(await istemci.PostAsJsonAsync(yol, veri));
    }

    public async Task Guncelle(string yol, object veri)
    {
        await HataVarsaBildir(await istemci.PutAsJsonAsync(yol, veri));
    }

    private static async Task HataVarsaBildir(HttpResponseMessage cevap)
    {
        if (!cevap.IsSuccessStatusCode)
        {
            string mesaj = await cevap.Content.ReadAsStringAsync();
            throw new Exception(mesaj == "" ? "İstek başarısız (" + (int)cevap.StatusCode + ")" : mesaj);
        }
    }
}
