using Modeller;

namespace Masaustu
{
    public partial class ParcaFormu : Form
    {
        // null ise yeni parça ekleniyor demektir.
        private readonly Parca? parca;

        public ParcaFormu(Parca? parca)
        {
            InitializeComponent();
            Tema.Uygula(this);
            this.parca = parca;

            if (parca == null)
            {
                Text = "Yeni parça";
            }
            else
            {
                Text = "Parçayı düzenle";
                txtAd.Text = parca.Ad;
                txtKod.Text = parca.Kod;
                nudFiyat.Value = parca.BirimFiyat;
                nudStok.Value = parca.StokAdedi;
                nudKritik.Value = parca.KritikSeviye;

                // Var olan parçanın stoğu buradan değil, Stok ekranındaki "Stoğa ekle / düş" ile değişir.
                lblStok.Text = "Stok";
                nudStok.Enabled = false;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            var yeniBilgiler = new Parca
            {
                Ad = txtAd.Text,
                Kod = txtKod.Text,
                BirimFiyat = nudFiyat.Value,
                StokAdedi = (int)nudStok.Value,
                KritikSeviye = (int)nudKritik.Value
            };

            btnKaydet.Enabled = false;
            try
            {
                if (parca == null)
                {
                    await Api.Gonder<Parca>("api/parcalar", yeniBilgiler);
                }
                else
                {
                    await Api.Guncelle("api/parcalar/" + parca.Id, yeniBilgiler);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
            btnKaydet.Enabled = true;
        }
    }
}
