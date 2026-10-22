using Modeller;

namespace Masaustu
{
    public partial class StokFormu : Form
    {
        public StokFormu()
        {
            InitializeComponent();
            Tema.Uygula(this);
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            Yardimci.TabloyuHazirla(dgvParcalar);
            dgvParcalar.Columns.Add("Ad", "Parça");
            dgvParcalar.Columns.Add("Kod", "Kod");
            dgvParcalar.Columns.Add("Fiyat", "Satış fiyatı");
            dgvParcalar.Columns.Add("Stok", "Stok");
            dgvParcalar.Columns.Add("Kritik", "Kritik seviye");
            Yardimci.SutunPayi(dgvParcalar, "Ad", 180);
            Yardimci.SagaYasla(dgvParcalar, "Fiyat", "Stok", "Kritik");

            // Stoğu herkes görür ama yalnızca yetkisi olan değiştirebilir.
            bool yetkili = Api.Ben!.StokDuzenleyebilirMi();
            btnEkle.Visible = yetkili;
            btnDuzenle.Visible = yetkili;
            btnSil.Visible = yetkili;
            lblAdet.Visible = yetkili;
            nudStokAdet.Visible = yetkili;
            btnStokGirisi.Visible = yetkili;
            lblStokNotu.Visible = yetkili;

            await Listele();
        }

        private async Task Listele()
        {
            try
            {
                string adres = "api/parcalar?arama=" + Uri.EscapeDataString(txtArama.Text);
                List<Parca> parcalar = await Api.Getir<List<Parca>>(adres);

                dgvParcalar.Rows.Clear();
                foreach (Parca parca in parcalar)
                {
                    int satir = dgvParcalar.Rows.Add(parca.Ad, parca.Kod, Yardimci.Para(parca.BirimFiyat),
                        parca.StokAdedi, parca.KritikSeviye);
                    dgvParcalar.Rows[satir].Tag = parca;

                    // Stoğu azalan parçalar kırmızı görünsün.
                    if (parca.StokAdedi <= parca.KritikSeviye)
                    {
                        dgvParcalar.Rows[satir].DefaultCellStyle.BackColor = Tema.UyariSatiri;
                        dgvParcalar.Rows[satir].DefaultCellStyle.ForeColor = Tema.Kirmizi;
                    }
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
            if (new ParcaFormu(null).ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnDuzenle_Click(object sender, EventArgs e)
        {
            await SeciliyiDuzenle();
        }

        private async void dgvParcalar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Api.Ben!.StokDuzenleyebilirMi())
            {
                await SeciliyiDuzenle();
            }
        }

        private async Task SeciliyiDuzenle()
        {
            Parca? parca = Yardimci.SeciliKayit<Parca>(dgvParcalar);
            if (parca == null)
            {
                MessageBox.Show("Önce bir parça seçin.");
                return;
            }

            if (new ParcaFormu(parca).ShowDialog() == DialogResult.OK)
            {
                await Listele();
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            Parca? parca = Yardimci.SeciliKayit<Parca>(dgvParcalar);
            if (parca == null)
            {
                MessageBox.Show("Önce bir parça seçin.");
                return;
            }
            if (!Yardimci.Onayla(parca.Ad + " stok kartı silinsin mi?"))
            {
                return;
            }

            try
            {
                await Api.Sil("api/parcalar/" + parca.Id);
                await Listele();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private async void btnStokGirisi_Click(object sender, EventArgs e)
        {
            Parca? parca = Yardimci.SeciliKayit<Parca>(dgvParcalar);
            if (parca == null)
            {
                MessageBox.Show("Önce bir parça seçin.");
                return;
            }

            var istek = new StokGirisIstegi { Adet = (int)nudStokAdet.Value };
            try
            {
                await Api.Gonder("api/parcalar/" + parca.Id + "/stok-giris", istek);
                await Listele();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }
    }
}
