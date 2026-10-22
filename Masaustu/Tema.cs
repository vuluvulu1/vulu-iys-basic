using System.Runtime.InteropServices;
using Modeller;

namespace Masaustu
{
    // Programın renkleri. vulu İYS'nin koyu kahve paletiyle aynıdır.
    // Her form kurucusunda InitializeComponent()'ten sonra Tema.Uygula(this) çağrılır;
    // böylece tasarımcıda renkleri tek tek seçmek gerekmez, hepsi buradan değişir.
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
            form.BackColor = Arka;
            form.ForeColor = Yazi;
            form.Icon = Logo();
            form.HandleCreated += KoyuBaslikCubugu;

            foreach (Control kontrol in form.Controls)
            {
                KontroluBoya(kontrol);
            }
        }

        // Pencere simgesi ve menüdeki logo için. Dosya programın yanına kopyalanır (bkz. Masaustu.csproj).
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
            if (durum == ServisDurumlari.OnayBekliyor) return VurguAcik;
            if (durum == ServisDurumlari.DevamEdiyor) return Mavi;
            if (durum == ServisDurumlari.Tamamlandi) return Yesil;
            if (durum == ServisDurumlari.IptalEdildi) return Kirmizi;
            return Yazi;
        }

        private static void KontroluBoya(Control kontrol)
        {
            if (kontrol is Button buton)
            {
                ButonuBoya(buton);
            }
            else if (kontrol is TextBox yaziKutusu)
            {
                yaziKutusu.BackColor = Yuzey;
                yaziKutusu.ForeColor = Yazi;
                yaziKutusu.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (kontrol is ComboBox acilirListe)
            {
                acilirListe.FlatStyle = FlatStyle.Flat;
                acilirListe.BackColor = Yuzey;
                acilirListe.ForeColor = Yazi;
            }
            else if (kontrol is NumericUpDown sayiKutusu)
            {
                sayiKutusu.BackColor = Yuzey;
                sayiKutusu.ForeColor = Yazi;
                sayiKutusu.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (kontrol is DateTimePicker tarihKutusu)
            {
                tarihKutusu.CalendarMonthBackground = Yuzey;
                tarihKutusu.CalendarForeColor = Yazi;
            }
            else if (kontrol is DataGridView tablo)
            {
                TabloyuBoya(tablo);
            }
            else if (kontrol is Label menuOgesi && menuOgesi.Tag as string == "menu")
            {
                // Ana penceredeki sol menü: fare üstüne gelince öğenin zemini açılır.
                menuOgesi.MouseEnter += MenuOgesiUzerinde;
                menuOgesi.MouseLeave += MenuOgesiDisinda;
            }
            else if (kontrol is Label etiket && etiket.ForeColor == SystemColors.GrayText)
            {
                // Tasarımcıda gri seçilen açıklama yazıları.
                etiket.ForeColor = SolukYazi;
            }
            else if (kontrol is Panel panel && panel.Tag != null)
            {
                // Tag'i "kart" ya da "menu" olan paneller zeminden biraz açık durur.
                panel.BackColor = Yuzey;
            }

            // Kutu ve panellerin içindeki kontrolleri de boya.
            foreach (Control icerdeki in kontrol.Controls)
            {
                KontroluBoya(icerdeki);
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

        // Tag ile butonun türü seçilir: "ana" = öne çıkan buton, boş = normal buton.
        private static void ButonuBoya(Button buton)
        {
            // Buton pasif olunca soluk görünsün diye; iki kere bağlanmasın diye önce çıkarılır.
            buton.EnabledChanged -= ButonEtkinligiDegisti;
            buton.EnabledChanged += ButonEtkinligiDegisti;

            if (!buton.Enabled)
            {
                buton.BackColor = Yuzey;
                buton.ForeColor = PasifYazi;
                return;
            }

            buton.FlatStyle = FlatStyle.Flat;
            buton.Cursor = Cursors.Hand;
            buton.FlatAppearance.BorderSize = 1;
            string tur = buton.Tag as string ?? "";

            if (tur == "ana")
            {
                buton.BackColor = Vurgu;
                buton.ForeColor = Arka;
                buton.FlatAppearance.BorderColor = Vurgu;
                buton.FlatAppearance.MouseOverBackColor = VurguAcik;
                buton.FlatAppearance.MouseDownBackColor = VurguAcik;
            }
            else
            {
                buton.BackColor = Kutu;
                buton.ForeColor = Yazi;
                buton.FlatAppearance.BorderColor = Kutu;
                buton.FlatAppearance.MouseOverBackColor = Cizgi;
                buton.FlatAppearance.MouseDownBackColor = Vurgu;
            }
        }

        private static void ButonEtkinligiDegisti(object? sender, EventArgs e)
        {
            if (sender is Button buton)
            {
                ButonuBoya(buton);
            }
        }

        private static void TabloyuBoya(DataGridView tablo)
        {
            tablo.BackgroundColor = Arka;
            tablo.BorderStyle = BorderStyle.None;
            tablo.GridColor = Cizgi;
            tablo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablo.RowTemplate.Height = 28;

            // Başlık satırının Windows görünümü yerine bizim renklerimizi kullanması için.
            tablo.EnableHeadersVisualStyles = false;
            tablo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tablo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tablo.ColumnHeadersHeight = 32;
            tablo.ColumnHeadersDefaultCellStyle.BackColor = Yuzey;
            tablo.ColumnHeadersDefaultCellStyle.ForeColor = SolukYazi;
            tablo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Yuzey;
            tablo.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 0, 4, 0);

            tablo.DefaultCellStyle.BackColor = Arka;
            tablo.DefaultCellStyle.ForeColor = Yazi;
            tablo.DefaultCellStyle.SelectionBackColor = Cizgi;
            tablo.DefaultCellStyle.SelectionForeColor = Yazi;
            tablo.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            tablo.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#211509");
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
