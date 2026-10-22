using Modeller;

namespace Masaustu
{
    public partial class RaporFormu : Form
    {
        public RaporFormu()
        {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            // Varsayılan dönem: bu ayın başından bugüne.
            dtpBaslangic.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpBitis.Value = DateTime.Today;

            Yardimci.TabloyuHazirla(dgvTeknisyenler);
            dgvTeknisyenler.Columns.Add("Teknisyen", "Teknisyen");
            dgvTeknisyenler.Columns.Add("IsSayisi", "İş sayısı");
            dgvTeknisyenler.Columns.Add("Tutar", "Tutar");

            Yardimci.TabloyuHazirla(dgvParcalar);
            dgvParcalar.Columns.Add("Parca", "Parça");
            dgvParcalar.Columns.Add("Adet", "Kullanılan adet");
            Yardimci.SagaYasla(dgvTeknisyenler, "IsSayisi", "Tutar");
            Yardimci.SagaYasla(dgvParcalar, "Adet");

            await RaporuGetir();
        }

        private async void btnGoster_Click(object sender, EventArgs e)
        {
            await RaporuGetir();
        }

        private async Task RaporuGetir()
        {
            if (dtpBitis.Value.Date < dtpBaslangic.Value.Date)
            {
                MessageBox.Show("Bitiş tarihi başlangıçtan önce olamaz.");
                return;
            }

            // Bitiş gününün de tamamı rapora girsin diye ertesi günün başına kadar sorulur.
            // Tarihler UTC'ye çevrilip "o" biçimiyle (örn. 2026-10-01T21:00:00.0000000Z) gönderilir.
            DateTime baslangic = dtpBaslangic.Value.Date.ToUniversalTime();
            DateTime bitis = dtpBitis.Value.Date.AddDays(1).ToUniversalTime();
            string adres = "api/rapor?baslangic=" + Uri.EscapeDataString(baslangic.ToString("o"))
                + "&bitis=" + Uri.EscapeDataString(bitis.ToString("o"));

            try
            {
                Rapor rapor = await Api.Getir<Rapor>(adres);

                lblAcilan.Text = "Açılan iş: " + rapor.AcilanIs;
                lblTamamlanan.Text = "Tamamlanan iş: " + rapor.TamamlananIs;
                lblIptal.Text = "İptal edilen iş: " + rapor.IptalEdilenIs;
                lblToplamTutar.Text = "Toplam tutar: " + Yardimci.Para(rapor.ToplamTutar);
                lblTahsil.Text = "Tahsil edilen: " + Yardimci.Para(rapor.TahsilEdilen);
                lblKalan.Text = "Tahsil edilmeyen: " + Yardimci.Para(rapor.ToplamTutar - rapor.TahsilEdilen);

                dgvTeknisyenler.Rows.Clear();
                foreach (TeknisyenSatiri satir in rapor.Teknisyenler)
                {
                    dgvTeknisyenler.Rows.Add(satir.TeknisyenAdi, satir.IsSayisi, Yardimci.Para(satir.Tutar));
                }

                dgvParcalar.Rows.Clear();
                foreach (ParcaSatiri satir in rapor.EnCokKullanilanParcalar)
                {
                    dgvParcalar.Rows.Add(satir.ParcaAdi, satir.Adet);
                }

                // Bu tablolar yalnızca bilgi verir; ilk satırın seçili görünmesine gerek yok.
                dgvTeknisyenler.ClearSelection();
                dgvParcalar.ClearSelection();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }
    }
}
