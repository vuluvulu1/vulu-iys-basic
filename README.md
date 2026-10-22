# vulu İYS (basit sürüm)

Servis ve onarım işletmeleri için küçük bir yönetim programı: müşteriler, servis kayıtları, stok, personel ve rapor.

```text
Masaüstü (WinForms)  --HTTPS-->  Api (Render, Docker)  -->  MongoDB Atlas
```

Masaüstü programı veritabanına hiç bağlanmaz; her şeyi API'den ister. Veritabanının şifresi yalnızca API'nin
çalıştığı yerde (Render) durur, işletmelere verilen pakette yoktur. Her işletmenin kendi Render servisi ve kendi
veritabanı vardır.

## Projeler

- `Modeller`: iki tarafın da kullandığı sınıflar (Musteri, ServisKaydi, Parca, Kullanici ...)
- `Api`: MongoDB'ye bağlanan web API. Her ekranın bir controller'ı var (`Api/Controllers`).
- `Masaustu`: WinForms programı. Her ekran bir form; API ile konuşan tek dosya `Api.cs`.
  Renkler (vulu İYS'nin koyu kahve paleti) formların tasarımında verilir, yani Visual Studio tasarımcısında da
  aynı görünür ve Özellikler penceresinden değiştirilebilir. `Tema.cs` aynı renkleri kodda kullanmak için sabit
  olarak tutar ve tasarımcının yapamadığı birkaç işi yapar (pencere simgesi, koyu başlık çubuğu, menü üzerine
  gelme rengi, pasif butonların soluk görünmesi).

## Bu bilgisayarda çalıştırma (geliştirme)

1. Varsayılan olarak bu bilgisayardaki MongoDB kullanılır (`mongodb://localhost:27017`). Atlas'a bağlanmak için
   `Api/appsettings.Local.ornek.json` dosyasını aynı klasöre `appsettings.Local.json` adıyla kopyalayıp Atlas
   bağlantı dizesini yazın. Bu dosya git'e girmez ve yayımlanan dosyalara konmaz.
2. Önce API'yi başlatın:

   ```bash
   dotnet run --project Api --launch-profile http
   ```

3. Sonra masaüstü programını:

   ```bash
   dotnet run --project Masaustu
   ```

   Programın bağlandığı API adresi `Masaustu/ayarlar.json` içindedir (varsayılan `http://localhost:5050/`).

Visual Studio'da: çözüme sağ tık → "Configure Startup Projects" → "Multiple startup projects" ile `Api` ve
`Masaustu` birlikte başlatılabilir.

İlk açılışta veritabanında hiç kullanıcı yoksa `admin` / `admin1234` hesabı oluşturulur
(`Api/appsettings.json` içindeki `IlkYonetici`). İlk girişten sonra şifreyi "Şifre değiştir" ile değiştirin.

## Bulut kurulumu (her işletme için bir kez)

**Veritabanı (MongoDB Atlas):** bir küme ve bir veritabanı kullanıcısı oluşturulur. "Network Access" listesine
`0.0.0.0/0` eklenir (Render'ın ücretsiz planında sabit çıkış adresi yoktur; veritabanını koruyan şey kullanıcı
şifresidir, uzun ve rastgele olmalıdır). Aynı küme birden çok işletme için kullanılabilir; her işletmeye ayrı
veritabanı adı verilir.

**API (Render):** "New → Blueprint" ile bu depo seçilir; `render.yaml` servisi tanımlar ve şunları ister:

- `Mongo__BaglantiDizesi`: Atlas bağlantı dizesi
- `Mongo__VeritabaniAdi`: bu işletmenin veritabanı, örn. `vulu_yildiz_teknik_servis`
- `Isletme__Ad`: giriş ekranında, menüde ve formlarda görünen ad
- `IlkYonetici__Sifre`: ilk yönetici hesabının şifresi (kullanıcı adı `admin`)

Adres, telefon ve servis koşulları için Render panelinden `Isletme__Adres`, `Isletme__Telefon` ve
`Isletme__ServisKosullari` eklenebilir. Ücretsiz planda servis 15 dakika istek almayınca uyur; sonraki ilk istek
bir dakika kadar sürebilir.

## İşletmeye özel paket hazırlama

`Paketleyici` projesini çalıştırın, işletmenin Render adresini (örn. `https://yildiz-servis.onrender.com`) yazıp
"Paketi hazırla"ya basın. Paketleyici işletmenin adını o API'den öğrenir, masaüstü programını derler ve
`Dagitim/<işletme adı>/` klasörüne koyar; programın yanındaki `ayarlar.json` dosyasına API adresini yazar.
Klasör işletmeye olduğu gibi verilir ve `Masaustu.exe` ile açılır. .NET pakete dahildir (yaklaşık 120 MB), karşı
bilgisayarda bir şey kurmak gerekmez. "vulu İYS" yalnızca giriş ekranının altında küçük olarak yazar.

## Kurallar

- Yönetici: personel ekler/düzenler, raporları görür, stoğu düzenler.
- Teknisyen: müşteri ve servis kayıtlarıyla çalışır, stoğu görür. "Stok yetkisi" verilirse stoğu da düzenler.
- Servis kaydına eklenen parça stoktan düşer, çıkarılırsa stoğa geri döner. Stok eksiye inmez.
- Servis kaydı olan müşteri silinemez; parçası olan servis kaydı, parçalar çıkarılmadan silinemez.
- Kaydı kimin, ne zaman, nasıl değiştirdiği işlem geçmişine yazılır (`islemGecmisi` koleksiyonu); personel not da ekler.
- Servis kabul formu ve teslim formu PDF olarak açılır (API'de QuestPDF ile üretilir; Community lisansı yıllık
  geliri 1 milyon doların altındaki işletmeler için ücretsizdir).
- "WhatsApp ile bildir" kaydın durumuna uygun mesajı WhatsApp'ta hazır açar; mesajı personel gönderir.
- Giriş tokenları API'nin belleğinde tutulur; API yeniden başlarsa herkes tekrar giriş yapar.
