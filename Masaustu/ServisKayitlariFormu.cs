using Modeller;

namespace Masaustu
{
    public partial class ServisKayitlariFormu : Form
    {
        public ServisKayitlariFormu()
        {
            InitializeComponent();
            Tema.Uygula(this);
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.Add("Tüm durumlar");
            cmbDurum.Items.AddRange(ServisDurumlari.Hepsi);
            cmbDurum.SelectedIndex = 0;

            Yardimci.TabloyuHazirla(dgvKayitlar);
            dgvKayitlar.Columns.Add("No", "Kayıt no");
            dgvKayitlar.Columns.Add("Musteri", "Müşteri");
            dgvKayitlar.Columns.Add("Cihaz", "Cihaz");
            dgvKayitlar.Columns.Add("Durum", "Durum");
            dgvKayitlar.Columns.Add("Teknisyen", "Teknisyen");
            dgvKayitlar.Columns.Add("Acilis", "Açılış");
            dgvKayitlar.Columns.Add("Tutar", "Tutar");
            dgvKayitlar.Columns.Add("Odeme", "Ödeme");

            Yardimci.SutunPayi(dgvKayitlar, "Musteri", 130);
            Yardimci.SutunPayi(dgvKayitlar, "Cihaz", 170);
            Yardimci.SutunPayi(dgvKayitlar, "Odeme", 60);
            Yardimci.SagaYasla(dgvKayitlar, "Tutar");

            await Listele();
        }

        private async Task Listele()
        {
            string durum = "";
            if (cmbDurum.SelectedIndex > 0)
            {
                durum = cmbDurum.Text;
            }

            try
            {
                string adres = "api/servis-kayitlari?arama=" + Uri.EscapeDataString(txtArama.Text)
                    + "&durum=" + Uri.EscapeDataString(durum);
                List<ServisKaydi> kayitlar = await Api.Getir<List<ServisKaydi>>(adres);

                dgvKayitlar.Rows.Clear();
                foreach (ServisKaydi kayit in kayitlar)
                {
                    string odeme = kayit.OdendiMi ? "Ödendi" : "";
                    int satir = dgvKayitlar.Rows.Add(kayit.No, kayit.MusteriAdi, kayit.Cihaz, kayit.Durum,
                        kayit.TeknisyenAdi, Yardimci.Tarih(kayit.AcilisTarihi), Yardimci.Para(kayit.ToplamTutar()), odeme);
                    dgvKayitlar.Rows[satir].Tag = kayit;
                    dgvKayitlar.Rows[satir].Cells["Durum"].Style.ForeColor = Tema.DurumRengi(kayit.Durum);
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

        private async void btnYeni_Click(object sender, EventArgs e)
        {
            new ServisKaydiFormu(null).ShowDialog();
            await Listele();
        }

        private async void btnAc_Click(object sender, EventArgs e)
        {
            await SeciliyiAc();
        }

        private async void dgvKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            await SeciliyiAc();
        }

        private async Task SeciliyiAc()
        {
            ServisKaydi? kayit = Yardimci.SeciliKayit<ServisKaydi>(dgvKayitlar);
            if (kayit == null)
            {
                MessageBox.Show("Önce bir kayıt seçin.");
                return;
            }

            new ServisKaydiFormu(kayit.Id).ShowDialog();
            await Listele();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            ServisKaydi? kayit = Yardimci.SeciliKayit<ServisKaydi>(dgvKayitlar);
            if (kayit == null)
            {
                MessageBox.Show("Önce bir kayıt seçin.");
                return;
            }
            if (!Yardimci.Onayla(kayit.No + " numaralı kayıt silinsin mi?"))
            {
                return;
            }

            try
            {
                await Api.Sil("api/servis-kayitlari/" + kayit.Id);
                await Listele();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }
    }
}
