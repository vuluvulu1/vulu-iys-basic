using Modeller;

namespace Masaustu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            Tema.Uygula(this);
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            Kullanici ben = Api.Ben!;
            lblIsletmeAdi.Text = Api.IsletmeAdi;
            Text = Api.IsletmeAdi;
            lblHosgeldin.Text = "Hoş geldin, " + ben.AdSoyad + " (" + ben.Rol + ")";

            // Personel ve rapor ekranlarını yalnızca yönetici görür.
            mnuPersonel.Visible = ben.YoneticiMi();
            mnuRapor.Visible = ben.YoneticiMi();

            // Gizlenen iki butonun yeri boş kalmasın; alttaki butonları o kadar yukarı kaydır.
            if (!ben.YoneticiMi())
            {
                int bosluk = mnuRapor.Bottom - mnuStok.Bottom;
                mnuSifre.Top -= bosluk;
                mnuCikis.Top -= bosluk;
            }

            await OzetiYukle();
        }

        private async Task OzetiYukle()
        {
            try
            {
                Ozet ozet = await Api.Getir<Ozet>("api/ozet");
                lblAcikIs.Text = ozet.AcikIsSayisi.ToString();
                lblTeslimBekleyen.Text = ozet.TeslimBekleyenSayisi.ToString();
                lblBugunAcilan.Text = ozet.BugunAcilanSayisi.ToString();
                lblKritikStok.Text = ozet.KritikStokSayisi.ToString();
                lblOdenmemis.Text = Yardimci.Para(ozet.OdenmemisTutar);

                // Dikkat isteyen sayılar kırmızı görünsün.
                lblKritikStok.ForeColor = ozet.KritikStokSayisi > 0 ? Tema.Kirmizi : Tema.Yazi;
                lblOdenmemis.ForeColor = ozet.OdenmemisTutar > 0 ? Tema.Kirmizi : Tema.Yazi;
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        // Her ekran ayrı bir pencerede açılır; kapanınca özet yenilenir.
        private async void mnuMusteriler_Click(object sender, EventArgs e)
        {
            new MusterilerFormu().ShowDialog();
            await OzetiYukle();
        }

        private async void mnuServis_Click(object sender, EventArgs e)
        {
            new ServisKayitlariFormu().ShowDialog();
            await OzetiYukle();
        }

        private async void mnuStok_Click(object sender, EventArgs e)
        {
            new StokFormu().ShowDialog();
            await OzetiYukle();
        }

        private void mnuPersonel_Click(object sender, EventArgs e)
        {
            new PersonelFormu().ShowDialog();
        }

        private void mnuRapor_Click(object sender, EventArgs e)
        {
            new RaporFormu().ShowDialog();
        }

        private void mnuSifre_Click(object sender, EventArgs e)
        {
            new SifreDegistirFormu().ShowDialog();
        }

        private async void mnuCikis_Click(object sender, EventArgs e)
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
