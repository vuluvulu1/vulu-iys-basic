using Api;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// QuestPDF'in ücretsiz lisansı: yıllık geliri 1 milyon doların altındaki işletmeler için.
QuestPDF.Settings.License = LicenseType.Community;
ServisFormu.AyarlariOku(builder.Configuration);

var app = builder.Build();

// Veritabanına bağlan ve hiç kullanıcı yoksa ilk yöneticiyi oluştur.
await Veritabani.Baslat(builder.Configuration);

app.MapControllers();
app.Run();
