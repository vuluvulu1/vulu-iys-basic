using Modeller;

namespace Masaustu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            Kullanici ben = Api.Ben!;
            lblHosgeldin.Text = "Hoş geldin, " + ben.AdSoyad + " (" + ben.Rol + ")";

            // Personel ve rapor ekranlarını yalnızca yönetici görür.
            btnPersonel.Visible = ben.YoneticiMi();
            btnRapor.Visible = ben.YoneticiMi();

            // Gizlenen iki butonun yeri boş kalmasın; alttaki butonları o kadar yukarı kaydır.
            if (!ben.YoneticiMi())
            {
                int bosluk = btnRapor.Bottom - btnStok.Bottom;
                btnSifre.Top -= bosluk;
                btnCikis.Top -= bosluk;
            }

            await OzetiYukle();
        }

        private async Task OzetiYukle()
        {
            try
            {
                Ozet ozet = await Api.Getir<Ozet>("api/ozet");
                lblAcikIs.Text = "Açık iş: " + ozet.AcikIsSayisi;
                lblTeslimBekleyen.Text = "Teslim bekleyen: " + ozet.TeslimBekleyenSayisi;
                lblBugunAcilan.Text = "Bugün açılan: " + ozet.BugunAcilanSayisi;
                lblKritikStok.Text = "Kritik stoktaki parça: " + ozet.KritikStokSayisi;
                lblOdenmemis.Text = "Ödenmemiş tutar: " + Yardimci.Para(ozet.OdenmemisTutar);
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        // Her ekran ayrı bir pencerede açılır; kapanınca özet yenilenir.
        private async void btnMusteriler_Click(object sender, EventArgs e)
        {
            new MusterilerFormu().ShowDialog();
            await OzetiYukle();
        }

        private async void btnServis_Click(object sender, EventArgs e)
        {
            new ServisKayitlariFormu().ShowDialog();
            await OzetiYukle();
        }

        private async void btnStok_Click(object sender, EventArgs e)
        {
            new StokFormu().ShowDialog();
            await OzetiYukle();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            new PersonelFormu().ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            new RaporFormu().ShowDialog();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            new SifreDegistirFormu().ShowDialog();
        }

        private async void btnCikis_Click(object sender, EventArgs e)
        {
            await Api.CikisYap();
            // Programı baştan başlatır, yani giriş ekranına döner.
            Application.Restart();
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            await OzetiYukle();
        }
    }
}
