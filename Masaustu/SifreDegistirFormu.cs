using Modeller;

namespace Masaustu
{
    public partial class SifreDegistirFormu : Form
    {
        public SifreDegistirFormu()
        {
            InitializeComponent();
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeni.Text != txtTekrar.Text)
            {
                MessageBox.Show("Yeni şifreler birbirini tutmuyor.");
                return;
            }

            var istek = new SifreDegistirIstegi
            {
                EskiSifre = txtEski.Text,
                YeniSifre = txtYeni.Text
            };

            try
            {
                await Api.Gonder("api/kimlik/sifre-degistir", istek);
                MessageBox.Show("Şifreniz değiştirildi.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }
    }
}
