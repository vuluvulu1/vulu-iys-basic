using Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

// Veritabanına bağlan ve hiç kullanıcı yoksa ilk yöneticiyi oluştur.
await Veritabani.Baslat(builder.Configuration);

app.MapControllers();
app.Run();
