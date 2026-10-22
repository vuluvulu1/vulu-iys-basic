using System.Collections.Concurrent;
using System.Security.Cryptography;
using Modeller;
using MongoDB.Driver;

namespace Api;

// Giriş yapan her kullanıcıya rastgele bir token verilir ve burada hangi kullanıcıya ait olduğu tutulur.
// Masaüstü her istekte bu tokenı "Authorization: Bearer <token>" başlığıyla gönderir.
// Tokenlar bellekte durur: API yeniden başlarsa herkesin tekrar giriş yapması gerekir.
public static class Oturumlar
{
    private static readonly ConcurrentDictionary<string, string> tokenlar = new();

    public static string Ac(string kullaniciId)
    {
        string token = Convert.ToHexString(RandomNumberGenerator.GetBytes(32));
        tokenlar[token] = kullaniciId;
        return token;
    }

    public static void Kapat(HttpRequest istek)
    {
        tokenlar.TryRemove(TokeniOku(istek), out _);
    }

    // İsteği gönderen kullanıcıyı döner; token yoksa, geçersizse ya da hesap pasifse null döner.
    // Kullanıcı her seferinde veritabanından okunur, böylece rolü değişen ya da pasif yapılan hesap hemen etkilenir.
    public static async Task<Kullanici?> KullaniciyiBul(HttpRequest istek)
    {
        string token = TokeniOku(istek);
        if (!tokenlar.TryGetValue(token, out string? kullaniciId))
        {
            return null;
        }

        var kullanici = await Veritabani.Kullanicilar.Find(k => k.Id == kullaniciId).FirstOrDefaultAsync();
        if (kullanici == null || !kullanici.AktifMi)
        {
            return null;
        }
        return kullanici;
    }

    private static string TokeniOku(HttpRequest istek)
    {
        string baslik = istek.Headers.Authorization.ToString();
        if (baslik.StartsWith("Bearer "))
        {
            return baslik.Substring("Bearer ".Length);
        }
        return "";
    }
}
