using Modeller;

namespace Masaustu
{
    public partial class MusterilerFormu : Form
    {
        public MusterilerFormu()
        {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            Yardimci.TabloyuHazirla(dgvMusteriler);
            dgvMusteriler.Columns.Add("AdSoyad", "Ad soyad");
            dgvMusteriler.Columns.Add("Telefon", "Telefon");
            dgvMusteriler.Columns.Add("Email", "E-posta");
            dgvMusteriler.Columns.Add("Adres", "Adres");

            await Listele();
        }

        private async Task Listele()
        {
            try
            {
                string adres = "api/musteriler?arama=" + Uri.EscapeDataString(txtArama.Text);
                List<Musteri> musteriler = await Api.Getir<List<Musteri>>(adres);

                dgvMusteriler.Rows.Clear();
                foreach (Musteri musteri in musteriler)
                {
                    int satir = dgvMusteriler.Rows.Add(musteri.AdSoyad, musteri.Telefon, musteri.Email, musteri.Adres);
                    dgvMusteriler.Rows[satir].Tag = musteri;
                }
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            await Listele();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var form = new MusteriFormu(null);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            await SeciliyiDuzenle();
        }

        private async void dgvMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await SeciliyiDuzenle();
        }

        private async Task SeciliyiDuzenle()
        {
            Musteri? musteri = Yardimci.SeciliKayit<Musteri>(dgvMusteriler);
            if (musteri == null)
            {
                MessageBox.Show("Önce bir müşteri seçin.");
                return;
            }

            var form = new MusteriFormu(musteri);
            if (form.ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            Musteri? musteri = Yardimci.SeciliKayit<Musteri>(dgvMusteriler);
            if (musteri == null)
            {
                MessageBox.Show("Önce bir müşteri seçin.");
                return;
            }
            if (!Yardimci.Onayla(musteri.AdSoyad + " silinsin mi?"))
            {
                return;
            }

            try
            {
                await Api.Sil("api/musteriler/" + musteri.Id);
                await Listele();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }
    }
}
