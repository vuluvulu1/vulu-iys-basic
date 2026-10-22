using Api;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Atlas bağlantı dizesi gibi gizli ayarlar git'e girmez. Bu bilgisayarda appsettings.Local.json dosyasından,
// Render'da ortam değişkenlerinden (Mongo__BaglantiDizesi gibi) okunur. Örnek: appsettings.Local.ornek.json
builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true);

builder.Services.AddControllers();

// QuestPDF'in ücretsiz lisansı: yıllık geliri 1 milyon doların altındaki işletmeler için.
QuestPDF.Settings.License = LicenseType.Community;
Isletme.AyarlariOku(builder.Configuration);

var app = builder.Build();

// Veritabanına bağlan ve hiç kullanıcı yoksa ilk yöneticiyi oluştur.
await Veritabani.Baslat(builder.Configuration);

app.MapControllers();
app.Run();
