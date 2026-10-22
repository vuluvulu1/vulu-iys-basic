using Modeller;

namespace Masaustu
{
    // Servis kaydını açma ve düzenleme penceresi. Sağdaki bölümden kayda stoktan parça eklenir.
    public partial class ServisKaydiFormu : Form
    {
        // Yeni kayıtta null'dır; kaydedilince dolar ve parça bölümü açılır.
        private string? kayitId;
        private ServisKaydi kayit = new ServisKaydi();

        public ServisKaydiFormu(string? kayitId)
        {
            InitializeComponent();
            this.kayitId = kayitId;
        }

        private async void Form_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.AddRange(ServisDurumlari.Hepsi);
            cmbDurum.SelectedIndex = 0;

            Yardimci.TabloyuHazirla(dgvParcalar);
            dgvParcalar.Columns.Add("Ad", "Parça");
            dgvParcalar.Columns.Add("Adet", "Adet");
            dgvParcalar.Columns.Add("Fiyat", "Birim fiyat");
            dgvParcalar.Columns.Add("Tutar", "Tutar");
            dgvParcalar.Columns["Ad"].FillWeight = 160;
            dgvParcalar.Columns["Adet"].FillWeight = 50;
            Yardimci.SagaYasla(dgvParcalar, "Adet", "Fiyat", "Tutar");

            try
            {
                if (kayitId != null)
                {
                    kayit = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
                }
                await SecenekleriYukle();
                AlanlariDoldur();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
                Close();
            }
        }

        // Müşteri, teknisyen ve parça açılır listelerini doldurur.
        private async Task SecenekleriYukle()
        {
            List<Musteri> musteriler = await Api.Getir<List<Musteri>>("api/musteriler");
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "Id";
            cmbMusteri.DataSource = musteriler;

            // Listenin başına "atanmamış" seçeneği konur. Pasif personel listede yer almaz,
            // ama bu kayda zaten atanmışsa görünmeye devam eder.
            List<Kullanici> personel = await Api.Getir<List<Kullanici>>("api/personel");
            var teknisyenler = new List<Kullanici>();
            teknisyenler.Add(new Kullanici { Id = "", AdSoyad = "(Atanmamış)" });
            foreach (Kullanici kisi in personel)
            {
                if (kisi.AktifMi || kisi.Id == kayit.TeknisyenId)
                {
                    teknisyenler.Add(kisi);
                }
            }
            cmbTeknisyen.DisplayMember = "AdSoyad";
            cmbTeknisyen.ValueMember = "Id";
            cmbTeknisyen.DataSource = teknisyenler;

            await ParcaListesiniYukle();
        }

        private async Task ParcaListesiniYukle()
        {
            List<Parca> parcalar = await Api.Getir<List<Parca>>("api/parcalar");
            cmbParca.DisplayMember = "Ad";
            cmbParca.DataSource = parcalar;
        }

        // Açılır listede parçanın yanında stok adedi de görünsün: "Ekran (stok: 4)"
        private void cmbParca_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Parca parca)
            {
                e.Value = parca.Ad + " (stok: " + parca.StokAdedi + ")";
            }
        }

        private void AlanlariDoldur()
        {
            if (kayitId == null)
            {
                lblNo.Text = "Yeni kayıt";
                // Müşteri boş başlar ki yanlışlıkla listedeki ilk müşteriye kayıt açılmasın.
                cmbMusteri.SelectedIndex = -1;
                if (Api.Ben != null && Api.Ben.AktifMi)
                {
                    cmbTeknisyen.SelectedValue = Api.Ben.Id;
                }
            }
            else
            {
                lblNo.Text = kayit.No + "  -  " + Yardimci.Tarih(kayit.AcilisTarihi);
                cmbMusteri.SelectedValue = kayit.MusteriId;
                cmbTeknisyen.SelectedValue = kayit.TeknisyenId;
                txtCihaz.Text = kayit.Cihaz;
                txtSeriNo.Text = kayit.SeriNo;
                txtAksesuarlar.Text = kayit.Aksesuarlar;
                txtSorun.Text = kayit.Sorun;
                txtYapilanIslem.Text = kayit.YapilanIslem;
                cmbDurum.Text = kayit.Durum;
                nudIscilik.Value = kayit.IscilikUcreti;
                chkOdendi.Checked = kayit.OdendiMi;
            }

            // Kayıt açıldıktan sonra müşterisi değiştirilemez.
            cmbMusteri.Enabled = kayitId == null;

            // Parça eklemek için kaydın veritabanında olması gerekir.
            grpParcalar.Enabled = kayitId != null;
            if (kayitId == null)
            {
                grpParcalar.Text = "Kullanılan parçalar (önce kaydı kaydedin)";
            }
            else
            {
                grpParcalar.Text = "Kullanılan parçalar";
            }

            ParcalariGoster();
        }

        private void ParcalariGoster()
        {
            dgvParcalar.Rows.Clear();
            foreach (KullanilanParca parca in kayit.Parcalar)
            {
                int satir = dgvParcalar.Rows.Add(parca.Ad, parca.Adet, Yardimci.Para(parca.BirimFiyat), Yardimci.Para(parca.Tutar()));
                dgvParcalar.Rows[satir].Tag = parca;
            }
            ToplamiGoster();
        }

        private void ToplamiGoster()
        {
            decimal toplam = nudIscilik.Value + kayit.ParcaToplami();
            lblToplam.Text = "Toplam: " + Yardimci.Para(toplam) + "  (parçalar: " + Yardimci.Para(kayit.ParcaToplami()) + ")";
        }

        private void nudIscilik_ValueChanged(object sender, EventArgs e)
        {
            ToplamiGoster();
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedValue == null)
            {
                MessageBox.Show("Bir müşteri seçin. Müşteri yoksa önce Müşteriler ekranından ekleyin.");
                return;
            }

            kayit.MusteriId = (string)cmbMusteri.SelectedValue;
            kayit.TeknisyenId = (string?)cmbTeknisyen.SelectedValue ?? "";
            kayit.Cihaz = txtCihaz.Text;
            kayit.SeriNo = txtSeriNo.Text;
            kayit.Aksesuarlar = txtAksesuarlar.Text;
            kayit.Sorun = txtSorun.Text;
            kayit.YapilanIslem = txtYapilanIslem.Text;
            kayit.Durum = cmbDurum.Text;
            kayit.IscilikUcreti = nudIscilik.Value;
            kayit.OdendiMi = chkOdendi.Checked;

            btnKaydet.Enabled = false;
            try
            {
                if (kayitId == null)
                {
                    kayit = await Api.Gonder<ServisKaydi>("api/servis-kayitlari", kayit);
                    kayitId = kayit.Id;
                    MessageBox.Show(kayit.No + " numaralı kayıt açıldı. Şimdi kullanılan parçaları ekleyebilirsiniz.");
                }
                else
                {
                    await Api.Guncelle("api/servis-kayitlari/" + kayitId, kayit);
                    kayit = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
                    MessageBox.Show("Kaydedildi.");
                }
                AlanlariDoldur();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
            btnKaydet.Enabled = true;
        }

        private async void btnParcaEkle_Click(object sender, EventArgs e)
        {
            if (cmbParca.SelectedItem is not Parca parca)
            {
                MessageBox.Show("Bir parça seçin. Parça yoksa önce Stok ekranından ekleyin.");
                return;
            }

            var istek = new ParcaKullanIstegi { ParcaId = parca.Id, Adet = (int)nudAdet.Value };
            try
            {
                await Api.Gonder<KullanilanParca>("api/servis-kayitlari/" + kayitId + "/parcalar", istek);
                await ParcalariYenile();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private async void btnParcaCikar_Click(object sender, EventArgs e)
        {
            KullanilanParca? parca = Yardimci.SeciliKayit<KullanilanParca>(dgvParcalar);
            if (parca == null)
            {
                MessageBox.Show("Önce listeden bir parça seçin.");
                return;
            }
            if (!Yardimci.Onayla(parca.Ad + " kayıttan çıkarılsın ve stoğa geri eklensin mi?"))
            {
                return;
            }

            try
            {
                await Api.Sil("api/servis-kayitlari/" + kayitId + "/parcalar/" + parca.Id);
                await ParcalariYenile();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        // Yalnızca parça listesini ve stok adetlerini tazeler; ekranda yazılıp henüz kaydedilmemiş bilgiler kaybolmaz.
        private async Task ParcalariYenile()
        {
            ServisKaydi guncel = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
            kayit.Parcalar = guncel.Parcalar;
            ParcalariGoster();

            int seciliSira = cmbParca.SelectedIndex;
            await ParcaListesiniYukle();
            if (seciliSira < cmbParca.Items.Count)
            {
                cmbParca.SelectedIndex = seciliSira;
            }
        }
    }
}
