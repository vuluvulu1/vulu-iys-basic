using System.Diagnostics;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Paketleyici
{
    // İşletme adını alır, API'yi ve masaüstü programını o işletmeye özel olarak Dagitim klasörüne hazırlar.
    // Hazırlanan klasör başka bir bilgisayara kopyalanabilir; .NET kurulu olması gerekmez (yalnızca MongoDB).
    public partial class PaketleyiciFormu : Form
    {
        public PaketleyiciFormu()
        {
            InitializeComponent();
        }

        private async void btnHazirla_Click(object sender, EventArgs e)
        {
            string isletmeAdi = txtIsletmeAdi.Text.Trim();
            if (isletmeAdi == "")
            {
                MessageBox.Show("İşletme adını yazın.");
                return;
            }

            string? cozumKlasoru = CozumKlasorunuBul();
            if (cozumKlasoru == null)
            {
                MessageBox.Show("vulu-iys-basic.slnx bulunamadı. Paketleyiciyi çözüm klasörünün içinden çalıştırın.");
                return;
            }

            string hedef = Path.Combine(cozumKlasoru, "Dagitim", DosyaAdi(isletmeAdi));
            if (Directory.Exists(hedef))
            {
                var cevap = MessageBox.Show(isletmeAdi + " için bir paket zaten var. Silinip yeniden hazırlansın mı?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap != DialogResult.Yes)
                {
                    return;
                }
                Directory.Delete(hedef, true);
            }

            btnHazirla.Enabled = false;
            try
            {
                lblDurum.Text = "API hazırlanıyor... (ilk seferde birkaç dakika sürebilir)";
                await Yayinla(Path.Combine(cozumKlasoru, "Api"), Path.Combine(hedef, "Api"));

                lblDurum.Text = "Masaüstü programı hazırlanıyor...";
                await Yayinla(Path.Combine(cozumKlasoru, "Masaustu"), Path.Combine(hedef, "Masaustu"));

                AyarlariYaz(Path.Combine(hedef, "Api", "appsettings.json"), isletmeAdi);
                BaslatmaDosyasiYaz(hedef);

                lblDurum.Text = "Hazır: " + hedef;
                Process.Start("explorer.exe", hedef);
            }
            catch (Exception hata)
            {
                lblDurum.Text = "";
                MessageBox.Show(hata.Message, "Paket hazırlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnHazirla.Enabled = true;
        }

        // "dotnet publish" ile projeyi derleyip çalışmaya hazır dosyaları çıkış klasörüne koyar.
        // --self-contained: .NET'in kendisi de pakete girer, böylece karşı bilgisayarda .NET kurulu olmasa da çalışır.
        private static async Task Yayinla(string projeKlasoru, string cikisKlasoru)
        {
            var bilgi = new ProcessStartInfo("dotnet")
            {
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            bilgi.ArgumentList.Add("publish");
            bilgi.ArgumentList.Add(projeKlasoru);
            bilgi.ArgumentList.Add("-c");
            bilgi.ArgumentList.Add("Release");
            bilgi.ArgumentList.Add("-r");
            bilgi.ArgumentList.Add("win-x64");
            bilgi.ArgumentList.Add("--self-contained");
            bilgi.ArgumentList.Add("-o");
            bilgi.ArgumentList.Add(cikisKlasoru);

            using Process islem = Process.Start(bilgi)!;
            string cikti = await islem.StandardOutput.ReadToEndAsync();
            await islem.WaitForExitAsync();

            if (islem.ExitCode != 0)
            {
                throw new Exception("Derleme başarısız oldu:\n\n" + cikti);
            }
        }

        // Paketteki API ayarlarına işletmenin adını ve ona ayrılan veritabanının adını yazar.
        // Adres ve telefon boş bırakılır; gerekirse paketteki Api\appsettings.json dosyasından doldurulur.
        private static void AyarlariYaz(string ayarDosyasi, string isletmeAdi)
        {
            JsonNode ayarlar = JsonNode.Parse(File.ReadAllText(ayarDosyasi))!;
            ayarlar["Isletme"]!["Ad"] = isletmeAdi;
            ayarlar["Isletme"]!["Adres"] = "";
            ayarlar["Isletme"]!["Telefon"] = "";
            ayarlar["Mongo"]!["VeritabaniAdi"] = "vulu_" + VeritabaniAdi(isletmeAdi);

            // Türkçe harfler dosyada ç gibi değil, olduğu gibi yazılsın.
            var secenekler = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            File.WriteAllText(ayarDosyasi, ayarlar.ToJsonString(secenekler));
        }

        // Çift tıklanınca önce API'yi (küçültülmüş pencerede), birkaç saniye sonra masaüstü programını açar.
        private static void BaslatmaDosyasiYaz(string hedef)
        {
            string[] satirlar =
            [
                "@echo off",
                "start \"API\" /min /D \"%~dp0Api\" \"%~dp0Api\\Api.exe\"",
                "timeout /t 3 /nobreak >nul",
                "start \"\" \"%~dp0Masaustu\\Masaustu.exe\""
            ];
            File.WriteAllLines(Path.Combine(hedef, "Baslat.bat"), satirlar);
        }

        // Paketleyicinin bulunduğu klasörden yukarı doğru çıkıp vulu-iys-basic.slnx dosyasını arar.
        private static string? CozumKlasorunuBul()
        {
            DirectoryInfo? klasor = new DirectoryInfo(AppContext.BaseDirectory);
            while (klasor != null)
            {
                if (File.Exists(Path.Combine(klasor.FullName, "vulu-iys-basic.slnx")))
                {
                    return klasor.FullName;
                }
                klasor = klasor.Parent;
            }
            return null;
        }

        // Klasör adında kullanılamayan karakterleri (\ / : * ? " < > |) boşlukla değiştirir.
        private static string DosyaAdi(string isletmeAdi)
        {
            string sonuc = isletmeAdi;
            foreach (char karakter in Path.GetInvalidFileNameChars())
            {
                sonuc = sonuc.Replace(karakter, ' ');
            }
            return sonuc.Trim();
        }

        // "Yıldız Teknik Servis" -> "yildiz_teknik_servis"
        private static string VeritabaniAdi(string isletmeAdi)
        {
            string sonuc = "";
            foreach (char harf in isletmeAdi.ToLower(new CultureInfo("tr-TR")))
            {
                if (harf == 'ç') sonuc += 'c';
                else if (harf == 'ğ') sonuc += 'g';
                else if (harf == 'ı') sonuc += 'i';
                else if (harf == 'ö') sonuc += 'o';
                else if (harf == 'ş') sonuc += 's';
                else if (harf == 'ü') sonuc += 'u';
                else if (char.IsAsciiLetterOrDigit(harf)) sonuc += harf;
                else if (!sonuc.EndsWith('_')) sonuc += '_';
            }

            // MongoDB veritabanı adları kısa olmalı.
            if (sonuc.Length > 40)
            {
                sonuc = sonuc.Substring(0, 40);
            }
            return sonuc.Trim('_');
        }
    }
}
