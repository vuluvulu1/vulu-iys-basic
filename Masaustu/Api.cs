using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Modeller;

namespace Masaustu
{
    // API ile konuşan tek yer. Formlar veritabanını hiç bilmez, her şeyi buradaki metotlarla ister.
    // Bir şey ters giderse kullanıcıya gösterilecek mesajla birlikte hata fırlatılır;
    // formlar bunu try/catch ile yakalayıp MessageBox ile gösterir.
    public static class Api
    {
        // API başka bir bilgisayardaysa bu adres değiştirilir.
        private const string ApiAdresi = "http://localhost:5050/";

        private static readonly HttpClient istemci = new HttpClient { BaseAddress = new Uri(ApiAdresi) };

        // Giriş yapan kullanıcı. Giriş yapılmadan önce null'dır.
        public static Kullanici? Ben { get; private set; }

        // Programı kullanan işletmenin adı; giriş ekranında ve menüde görünür.
        public static string IsletmeAdi { get; private set; } = "";

        // İşletmenin adını API'den öğrenir. API'ye ulaşılamazsa boş kalır, hata göstermez;
        // bağlantı sorunu kullanıcı "Giriş yap"a basınca söylenir.
        public static async Task IsletmeAdiniGetir()
        {
            try
            {
                IsletmeBilgisi bilgi = await Getir<IsletmeBilgisi>("api/isletme");
                IsletmeAdi = bilgi.Ad;
            }
            catch
            {
                IsletmeAdi = "";
            }
        }

        public static async Task GirisYap(string kullaniciAdi, string sifre)
        {
            var istek = new GirisIstegi { KullaniciAdi = kullaniciAdi, Sifre = sifre };
            GirisCevabi cevap = await Gonder<GirisCevabi>("api/kimlik/giris", istek);

            // Bundan sonraki her istekte token otomatik olarak gönderilir.
            istemci.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", cevap.Token);
            Ben = cevap.Kullanici;
        }

        public static async Task CikisYap()
        {
            try
            {
                await Gonder("api/kimlik/cikis", new { });
            }
            catch
            {
                // API'ye ulaşılamasa da program kapanabilir.
            }
            istemci.DefaultRequestHeaders.Authorization = null;
            Ben = null;
        }

        public static async Task<T> Getir<T>(string adres)
        {
            HttpResponseMessage cevap = await Istek(() => istemci.GetAsync(adres));
            return (await cevap.Content.ReadFromJsonAsync<T>())!;
        }

        // PDF gibi dosyaları olduğu gibi indirir.
        public static async Task<byte[]> DosyaGetir(string adres)
        {
            HttpResponseMessage cevap = await Istek(() => istemci.GetAsync(adres));
            return await cevap.Content.ReadAsByteArrayAsync();
        }

        public static async Task<T> Gonder<T>(string adres, object veri)
        {
            HttpResponseMessage cevap = await Istek(() => istemci.PostAsJsonAsync(adres, veri));
            return (await cevap.Content.ReadFromJsonAsync<T>())!;
        }

        public static async Task Gonder(string adres, object veri)
        {
            await Istek(() => istemci.PostAsJsonAsync(adres, veri));
        }

        public static async Task Guncelle(string adres, object veri)
        {
            await Istek(() => istemci.PutAsJsonAsync(adres, veri));
        }

        public static async Task Sil(string adres)
        {
            await Istek(() => istemci.DeleteAsync(adres));
        }

        // İsteği gönderir; bağlantı kurulamazsa ya da API hata dönerse anlaşılır bir mesajla hata fırlatır.
        private static async Task<HttpResponseMessage> Istek(Func<Task<HttpResponseMessage>> gonder)
        {
            HttpResponseMessage cevap;
            try
            {
                cevap = await gonder();
            }
            catch (HttpRequestException)
            {
                throw new Exception("API'ye bağlanılamadı. API çalışıyor mu?\n(" + ApiAdresi + ")");
            }

            if (cevap.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new Exception("Oturumunuz kapanmış. Programı kapatıp yeniden giriş yapın.");
            }
            if (!cevap.IsSuccessStatusCode)
            {
                // API hata mesajını düz metin olarak gönderir, örn. "Ad soyad boş olamaz."
                string mesaj = await cevap.Content.ReadAsStringAsync();
                if (mesaj == "")
                {
                    mesaj = "İşlem yapılamadı (" + (int)cevap.StatusCode + ").";
                }
                throw new Exception(mesaj);
            }
            return cevap;
        }
    }
}
