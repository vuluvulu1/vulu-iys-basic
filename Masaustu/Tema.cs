using System.Runtime.InteropServices;
using Modeller;

namespace Masaustu
{
    // Programın renkleri. vulu İYS'nin koyu kahve paletiyle aynıdır.
    // Formlardaki renkler tasarımcıda (Designer.cs) verilir; buradaki sabitler kodun içinde renk
    // gerektiğinde kullanılır (örn. kritik stok satırı). Tasarımcıda bir rengi değiştirirsen burada da değiştir.
    //
    // Her form kurucusunda InitializeComponent()'ten sonra Tema.Uygula(this) çağrılır.
    // Uygula yalnızca tasarımcının yapamadığı işleri yapar: pencere simgesi, koyu başlık çubuğu,
    // sol menüde fare üstüne gelince renk değişimi ve pasif butonların soluk görünmesi.
    public static class Tema
    {
        public static readonly Color Arka = ColorTranslator.FromHtml("#1a110a");
        public static readonly Color Yuzey = ColorTranslator.FromHtml("#2b1a10");
        public static readonly Color Kutu = ColorTranslator.FromHtml("#3a2416");
        public static readonly Color Cizgi = ColorTranslator.FromHtml("#4a2e1c");
        public static readonly Color Yazi = ColorTranslator.FromHtml("#f3e6d6");
        public static readonly Color SolukYazi = ColorTranslator.FromHtml("#b89a7c");
        public static readonly Color PasifYazi = ColorTranslator.FromHtml("#6e5442");
        public static readonly Color Vurgu = ColorTranslator.FromHtml("#b5804f");
        public static readonly Color VurguAcik = ColorTranslator.FromHtml("#e9c699");
        public static readonly Color Kirmizi = ColorTranslator.FromHtml("#e5604d");
        public static readonly Color Yesil = ColorTranslator.FromHtml("#8bc48a");
        public static readonly Color Mavi = ColorTranslator.FromHtml("#8fb3d9");
        public static readonly Color UyariSatiri = ColorTranslator.FromHtml("#3d1a12");

        private static Icon? logo;

        public static void Uygula(Form form)
        {
            form.Icon = Logo();
            form.HandleCreated += KoyuBaslikCubugu;

            foreach (Control kontrol in form.Controls)
            {
                OlaylariBagla(kontrol);
            }
        }

        // Pencere simgesi ve giriş ekranındaki küçük logo için. Dosya programın yanına kopyalanır (bkz. Masaustu.csproj).
        public static Icon Logo()
        {
            if (logo == null)
            {
                logo = new Icon(Path.Combine(AppContext.BaseDirectory, "logo.ico"));
            }
            return logo;
        }

        public static Image LogoResmi(int boyut)
        {
            return new Icon(Logo(), boyut, boyut).ToBitmap();
        }

        // Servis kaydının durumunu listede renkli göstermek için.
        public static Color DurumRengi(string durum)
        {
            if (durum == ServisDurumlari.DevamEdiyor) return Mavi;
            if (durum == ServisDurumlari.Tamamlandi) return Yesil;
            if (durum == ServisDurumlari.IptalEdildi) return Kirmizi;
            return Yazi;
        }

        private static void OlaylariBagla(Control kontrol)
        {
            if (kontrol is Button buton)
            {
                buton.EnabledChanged += ButonEtkinligiDegisti;
            }
            else if (kontrol is Label menuOgesi && menuOgesi.Tag as string == "menu")
            {
                menuOgesi.MouseEnter += MenuOgesiUzerinde;
                menuOgesi.MouseLeave += MenuOgesiDisinda;
            }

            // Panellerin içindeki kontrollere de bak.
            foreach (Control icerdeki in kontrol.Controls)
            {
                OlaylariBagla(icerdeki);
            }
        }

        // Windows koyu modda pasif butonu da aktif gibi çizdiği için rengini biz soldururuz.
        // Buton yeniden aktif olunca Tag'ine göre rengi geri verilir: "ana" = bakır buton, boş = normal buton.
        private static void ButonEtkinligiDegisti(object? sender, EventArgs e)
        {
            if (sender is not Button buton)
            {
                return;
            }

            if (!buton.Enabled)
            {
                buton.BackColor = Yuzey;
                buton.ForeColor = PasifYazi;
            }
            else if (buton.Tag as string == "ana")
            {
                buton.BackColor = Vurgu;
                buton.ForeColor = Arka;
            }
            else
            {
                buton.BackColor = Kutu;
                buton.ForeColor = Yazi;
            }
        }

        private static void MenuOgesiUzerinde(object? sender, EventArgs e)
        {
            if (sender is Label menuOgesi)
            {
                menuOgesi.BackColor = Kutu;
            }
        }

        private static void MenuOgesiDisinda(object? sender, EventArgs e)
        {
            if (sender is Label menuOgesi)
            {
                menuOgesi.BackColor = Yuzey;
            }
        }

        // Windows 10/11'de pencerenin başlık çubuğunu da koyu yapar. Eski Windows'ta etkisi olmaz.
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr pencere, int ozellik, ref int deger, int boyut);

        private static void KoyuBaslikCubugu(object? sender, EventArgs e)
        {
            if (sender is Form form)
            {
                int acik = 1;
                DwmSetWindowAttribute(form.Handle, 20, ref acik, sizeof(int));
            }
        }
    }
}
