using Modeller;
using MongoDB.Driver;

namespace Api;

// MongoDB'ye erişen tek yer. Her koleksiyon burada bir kere açılır, controller'lar buradan kullanır.
public static class Veritabani
{
    public static IMongoCollection<Kullanici> Kullanicilar = null!;
    public static IMongoCollection<Musteri> Musteriler = null!;
    public static IMongoCollection<ServisKaydi> ServisKayitlari = null!;
    public static IMongoCollection<Parca> Parcalar = null!;
    public static IMongoCollection<Sayac> Sayaclar = null!;
    public static IMongoCollection<IslemKaydi> IslemGecmisi = null!;

    public static async Task Baslat(IConfiguration ayarlar)
    {
        string baglantiDizesi = ayarlar["Mongo:BaglantiDizesi"] ?? "mongodb://localhost:27017";
        string veritabaniAdi = ayarlar["Mongo:VeritabaniAdi"] ?? "vulu_basic";

        var istemci = new MongoClient(baglantiDizesi);
        var veritabani = istemci.GetDatabase(veritabaniAdi);

        Kullanicilar = veritabani.GetCollection<Kullanici>("kullanicilar");
        Musteriler = veritabani.GetCollection<Musteri>("musteriler");
        ServisKayitlari = veritabani.GetCollection<ServisKaydi>("servisKayitlari");
        Parcalar = veritabani.GetCollection<Parca>("parcalar");
        Sayaclar = veritabani.GetCollection<Sayac>("sayaclar");
        IslemGecmisi = veritabani.GetCollection<IslemKaydi>("islemGecmisi");

        // Aynı kullanıcı adıyla iki hesap açılamasın.
        var kullaniciAdiIndexi = new CreateIndexModel<Kullanici>(
            Builders<Kullanici>.IndexKeys.Ascending(k => k.KullaniciAdi),
            new CreateIndexOptions { Unique = true });
        await Kullanicilar.Indexes.CreateOneAsync(kullaniciAdiIndexi);

        long kullaniciSayisi = await Kullanicilar.CountDocumentsAsync(_ => true);
        if (kullaniciSayisi == 0)
        {
            var yonetici = new Kullanici
            {
                Id = YeniId(),
                KullaniciAdi = ayarlar["IlkYonetici:KullaniciAdi"] ?? "admin",
                SifreHash = BCrypt.Net.BCrypt.HashPassword(ayarlar["IlkYonetici:Sifre"] ?? "admin1234"),
                AdSoyad = "Yönetici",
                Rol = Roller.Yonetici
            };
            await Kullanicilar.InsertOneAsync(yonetici);
        }
    }

    // Servis kaydının geçmişine bir satır ekler: "Ahmet, 12.10 14:30, Durum: Beklemede → Devam ediyor"
    public static async Task GecmiseYaz(string servisKaydiId, Kullanici kim, string aciklama)
    {
        var satir = new IslemKaydi
        {
            Id = YeniId(),
            ServisKaydiId = servisKaydiId,
            Tarih = DateTime.UtcNow,
            KullaniciAdi = kim.AdSoyad,
            Aciklama = aciklama
        };
        await IslemGecmisi.InsertOneAsync(satir);
    }

    public static string YeniId()
    {
        return Guid.NewGuid().ToString("N");
    }

    // Servis kaydı numarası için yıllık sayaç: SK-2026-00001, SK-2026-00002, ...
    // Sayaç tek bir işlemde artırılıp okunur; aynı anda açılan iki kayıt aynı numarayı alamaz.
    public static async Task<string> YeniServisNo()
    {
        int yil = DateTime.Now.Year;
        string sayacAdi = "servis-" + yil;

        var sayac = await Sayaclar.FindOneAndUpdateAsync(
            Builders<Sayac>.Filter.Eq(s => s.Id, sayacAdi),
            Builders<Sayac>.Update.Inc(s => s.Deger, 1),
            new FindOneAndUpdateOptions<Sayac> { IsUpsert = true, ReturnDocument = ReturnDocument.After });

        return "SK-" + yil + "-" + sayac.Deger.ToString("00000");
    }
}

public class Sayac
{
    public string Id { get; set; } = "";
    public int Deger { get; set; }
}
