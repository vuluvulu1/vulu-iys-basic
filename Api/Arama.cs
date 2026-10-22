using System.Text.RegularExpressions;
using MongoDB.Bson;

namespace Api;

public static class Arama
{
    // Kullanıcının yazdığı metni "içinde geçiyor mu" aramasına çevirir, büyük/küçük harfe bakmaz.
    // Regex.Escape sayesinde ".*" gibi özel karakterler düz metin olarak aranır.
    public static BsonRegularExpression IcindeGecen(string metin)
    {
        return new BsonRegularExpression(Regex.Escape(metin.Trim()), "i");
    }
}
