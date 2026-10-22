using System.Diagnostics;
using System.Text.Json.Nodes;

namespace Paketleyici
{
    // Bir işletmenin Render'daki API adresini alır, işletmenin adını o API'den öğrenir ve masaüstü programını
    // bu adrese bağlı tek bir exe olarak hazırlar: Dagitim\<işletme adı>.exe. Exe işletmeye olduğu gibi verilir;
    // karşı bilgisayarda .NET kurulu olması gerekmez.
    public partial class PaketleyiciFormu : Form
    {
        public PaketleyiciFormu()
        {
            InitializeComponent();
        }

        private async void btnHazirla_Click(object sender, EventArgs e)
        {
            string apiAdresi = txtApiAdresi.Text.Trim().TrimEnd('/');
            if (!apiAdresi.StartsWith("http://") && !apiAdresi.StartsWith("https://"))
            {
                MessageBox.Show("API adresini https:// ile başlayarak yazın.");
                return;
            }

            string? cozumKlasoru = CozumKlasorunuBul();
            if (cozumKlasoru == null)
            {
                MessageBox.Show("vulu-iys-basic.slnx bulunamadı. Paketleyiciyi çözüm klasörünün içinden çalıştırın.");
                return;
            }

            btnHazirla.Enabled = false;
            try
            {
                // Paket yanlış işletmenin API'sine bağlanmasın diye adı API'nin kendisinden alıyoruz.
                lblDurum.Text = "API'ye bağlanılıyor... (Render uyuyorsa bir dakika kadar sürebilir)";
                string isletmeAdi = await IsletmeAdiniGetir(apiAdresi);

                string hedef = Path.Combine(cozumKlasoru, "Dagitim", DosyaAdi(isletmeAdi) + ".exe");
                if (File.Exists(hedef))
                {
                    var cevap = MessageBox.Show(isletmeAdi + " için bir program zaten var. Yenisiyle değiştirilsin mi?",
                        "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap != DialogResult.Yes)
                    {
                        lblDurum.Text = "";
                        btnHazirla.Enabled = true;
                        return;
                    }
                }

                lblDurum.Text = isletmeAdi + " için program hazırlanıyor... (ilk seferde birkaç dakika sürebilir)";

                // Önce geçici bir klasöre yayımlanır, oradan yalnızca exe işletmenin adıyla Dagitim'e alınır.
                string geciciKlasor = Path.Combine(Path.GetTempPath(), "vulu-paket-" + Guid.NewGuid().ToString("N"));
                try
                {
                    await Yayinla(Path.Combine(cozumKlasoru, "Masaustu"), geciciKlasor, apiAdresi + "/");
                    Directory.CreateDirectory(Path.GetDirectoryName(hedef)!);
                    File.Copy(Path.Combine(geciciKlasor, "Masaustu.exe"), hedef, true);
                }
                finally
                {
                    if (Directory.Exists(geciciKlasor))
                    {
                        Directory.Delete(geciciKlasor, true);
                    }
                }

                lblDurum.Text = "Hazır: " + hedef;
                // Gezgin'i açıp hazırlanan exe'yi seçili gösterir.
                Process.Start("explorer.exe", "/select,\"" + hedef + "\"");
            }
            catch (Exception hata)
            {
                lblDurum.Text = "";
                MessageBox.Show(hata.Message, "Paket hazırlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnHazirla.Enabled = true;
        }

        private static async Task<string> IsletmeAdiniGetir(string apiAdresi)
        {
            using var istemci = new HttpClient { Timeout = TimeSpan.FromSeconds(120) };
            string cevap;
            try
            {
                cevap = await istemci.GetStringAsync(apiAdresi + "/api/isletme");
            }
            catch (Exception)
            {
                throw new Exception("API'ye ulaşılamadı. Adresi ve Render'daki servisin çalıştığını kontrol edin.\n(" + apiAdresi + ")");
            }

            string ad = JsonNode.Parse(cevap)?["ad"]?.GetValue<string>() ?? "";
            if (ad == "")
            {
                throw new Exception("API'de işletme adı ayarlanmamış. Render'da Isletme__Ad değerini girin.");
            }
            return ad;
        }

        // "dotnet publish" ile masaüstü programını tek bir exe olarak derler.
        // --self-contained: .NET'in kendisi de exe'ye girer, böylece karşı bilgisayarda .NET kurulu olmasa da çalışır.
        private static async Task Yayinla(string projeKlasoru, string cikisKlasoru, string apiAdresi)
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

            // Programın bağlanacağı adres exe'nin içine yazılır (bkz. Masaustu.csproj, ApiAdresi).
            bilgi.ArgumentList.Add("-p:ApiAdresi=" + apiAdresi);
            // Her şey tek bir exe'de toplanır ve sıkıştırılır.
            bilgi.ArgumentList.Add("-p:PublishSingleFile=true");
            bilgi.ArgumentList.Add("-p:IncludeNativeLibrariesForSelfExtract=true");
            bilgi.ArgumentList.Add("-p:EnableCompressionInSingleFile=true");
            // .NET'in başka diller için getirdiği çeviri klasörleri (de, fr, ja ...) ve hata ayıklama dosyası alınmaz.
            bilgi.ArgumentList.Add("-p:SatelliteResourceLanguages=tr");
            bilgi.ArgumentList.Add("-p:DebugType=none");

            using Process islem = Process.Start(bilgi)!;
            string cikti = await islem.StandardOutput.ReadToEndAsync();
            await islem.WaitForExitAsync();

            if (islem.ExitCode != 0)
            {
                throw new Exception("Derleme başarısız oldu:\n\n" + cikti);
            }
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
    }
}
