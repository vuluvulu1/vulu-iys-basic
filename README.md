# vulu İYS (basit sürüm)

Servis ve onarım işletmeleri için küçük bir yönetim programı: müşteriler, servis kayıtları, stok, personel ve rapor.

```text
Masaüstü (WinForms)  --HTTP-->  Api (ASP.NET Core)  -->  MongoDB
```

Masaüstü programı veritabanına hiç bağlanmaz; her şeyi API'den ister.

## Projeler

- `Modeller`: iki tarafın da kullandığı sınıflar (Musteri, ServisKaydi, Parca, Kullanici ...)
- `Api`: MongoDB'ye bağlanan web API. Her ekranın bir controller'ı var (`Api/Controllers`).
- `Masaustu`: WinForms programı. Her ekran bir form; API ile konuşan tek dosya `Api.cs`.

## Çalıştırma

1. Bilgisayarda MongoDB çalışıyor olmalı (`mongodb://localhost:27017`). Başka bir adres için
   `Api/appsettings.json` içindeki `Mongo:BaglantiDizesi` değiştirilir.
2. Önce API'yi başlatın:

   ```bash
   dotnet run --project Api --launch-profile http
   ```

3. Sonra masaüstü programını:

   ```bash
   dotnet run --project Masaustu
   ```

Visual Studio'da: çözüme sağ tık → "Configure Startup Projects" → "Multiple startup projects" ile `Api` ve
`Masaustu` birlikte başlatılabilir.

İlk açılışta veritabanında hiç kullanıcı yoksa `admin` / `admin1234` hesabı oluşturulur
(`Api/appsettings.json` içindeki `IlkYonetici`). İlk girişten sonra şifreyi "Şifre değiştir" ile değiştirin.

## Kurallar

- Yönetici: personel ekler/düzenler, raporları görür, stoğu düzenler.
- Teknisyen: müşteri ve servis kayıtlarıyla çalışır, stoğu görür. "Stok yetkisi" verilirse stoğu da düzenler.
- Servis kaydına eklenen parça stoktan düşer, çıkarılırsa stoğa geri döner. Stok eksiye inmez.
- Servis kaydı olan müşteri silinemez; parçası olan servis kaydı, parçalar çıkarılmadan silinemez.
- Giriş tokenları API'nin belleğinde tutulur; API yeniden başlarsa herkes tekrar giriş yapar.
