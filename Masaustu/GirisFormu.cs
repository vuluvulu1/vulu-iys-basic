namespace Masaustu
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
            Tema.Uygula(this);
            picLogo.Image = Tema.LogoResmi(16);
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            await Api.IsletmeAdiniGetir();
            if (Api.IsletmeAdi != "")
            {
                lblIsletmeAdi.Text = Api.IsletmeAdi;
                Text = Api.IsletmeAdi + " - Giriş";
            }
            else
            {
                lblIsletmeAdi.Text = "Giriş";
            }
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifreyi yazın.");
                return;
            }

            // İstek sürerken butona ikinci kez basılmasın.
            btnGiris.Enabled = false;
            try
            {
                await Api.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
                txtSifre.Clear();
                txtSifre.Focus();
            }
            btnGiris.Enabled = true;
        }
    }
}
