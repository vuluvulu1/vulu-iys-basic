namespace Masaustu
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
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
