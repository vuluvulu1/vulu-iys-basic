using Modeller;

namespace Masaustu
{
    // Servis kaydını açma ve düzenleme penceresi.
    // Solda kaydın bilgileri, sağda iki sekme var: kullanılan parçalar ve işlem geçmişi.
    public partial class ServisKaydiFormu : Form
    {
        // Yeni kayıtta null'dır; kaydedilince dolar ve sağdaki bölümler açılır.
        private string? kayitId;
        private ServisKaydi kayit = new ServisKaydi();

        public ServisKaydiFormu(string? kayitId)
        {
            InitializeComponent();
            Tema.Uygula(this);
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
            Yardimci.SutunPayi(dgvParcalar, "Ad", 160);
            Yardimci.SutunPayi(dgvParcalar, "Adet", 50);
            Yardimci.SagaYasla(dgvParcalar, "Adet", "Fiyat", "Tutar");

            Yardimci.TabloyuHazirla(dgvGecmis);
            dgvGecmis.Columns.Add("Tarih", "Tarih");
            dgvGecmis.Columns.Add("Kisi", "Kim");
            dgvGecmis.Columns.Add("Islem", "İşlem");
            Yardimci.SutunPayi(dgvGecmis, "Tarih", 110);
            Yardimci.SutunPayi(dgvGecmis, "Kisi", 70);
            Yardimci.SutunPayi(dgvGecmis, "Islem", 180);
            // Uzun açıklamalar alt satıra geçsin, satır da ona göre uzasın.
            dgvGecmis.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvGecmis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            SekmeyiAc(pnlParcalar, btnSekmeParcalar);

            try
            {
                if (kayitId != null)
                {
                    kayit = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
                }
                await SecenekleriYukle();
                AlanlariDoldur();
                await GecmisiYukle();
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

            // Parça, geçmiş ve formlar için kaydın veritabanında olması gerekir.
            bool kayitli = kayitId != null;
            btnSekmeParcalar.Enabled = kayitli;
            btnSekmeGecmis.Enabled = kayitli;
            btnKabulFormu.Enabled = kayitli;
            btnTeslimFormu.Enabled = kayitli;
            btnWhatsApp.Enabled = kayitli;
            lblYeniKayitNotu.Visible = !kayitli;
            if (kayitli)
            {
                SekmeyiAc(pnlParcalar, btnSekmeParcalar);
            }
            else
            {
                pnlParcalar.Visible = false;
                pnlGecmis.Visible = false;
            }

            ParcalariGoster();
        }

        // Sağ taraftaki iki panelden yalnızca birini gösterir; seçili sekmenin butonu vurgulanır.
        private void SekmeyiAc(Panel panel, Button buton)
        {
            pnlParcalar.Visible = panel == pnlParcalar;
            pnlGecmis.Visible = panel == pnlGecmis;

            foreach (Button sekme in new[] { btnSekmeParcalar, btnSekmeGecmis })
            {
                sekme.BackColor = Tema.Kutu;
                sekme.ForeColor = Tema.Yazi;
            }
            buton.BackColor = Tema.Vurgu;
            buton.ForeColor = Tema.Arka;
        }

        private void btnSekmeParcalar_Click(object sender, EventArgs e)
        {
            SekmeyiAc(pnlParcalar, btnSekmeParcalar);
        }

        private void btnSekmeGecmis_Click(object sender, EventArgs e)
        {
            SekmeyiAc(pnlGecmis, btnSekmeGecmis);
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

        private async Task GecmisiYukle()
        {
            if (kayitId == null)
            {
                return;
            }

            List<IslemKaydi> gecmis = await Api.Getir<List<IslemKaydi>>("api/servis-kayitlari/" + kayitId + "/gecmis");
            dgvGecmis.Rows.Clear();
            foreach (IslemKaydi satir in gecmis)
            {
                dgvGecmis.Rows.Add(Yardimci.Tarih(satir.Tarih), satir.KullaniciAdi, satir.Aciklama);
            }
            dgvGecmis.ClearSelection();
        }

        // Parça işleminden sonra kaydı API'den yeniden okur.
        // Soldaki kutulara dokunmaz; böylece yazılıp henüz kaydedilmemiş bilgiler kaybolmaz.
        private async Task KaydiTazele()
        {
            ServisKaydi guncel = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
            kayit.Parcalar = guncel.Parcalar;

            ParcalariGoster();
            await GecmisiYukle();
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
                    MessageBox.Show(kayit.No + " numaralı kayıt açıldı. Şimdi parça ekleyebilir ya da kabul formunu yazdırabilirsiniz.");
                }
                else
                {
                    await Api.Guncelle("api/servis-kayitlari/" + kayitId, kayit);
                    kayit = await Api.Getir<ServisKaydi>("api/servis-kayitlari/" + kayitId);
                    MessageBox.Show("Kaydedildi.");
                }
                AlanlariDoldur();
                await GecmisiYukle();
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
                await KaydiTazele();
                await StokListesiniTazele();
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
                await KaydiTazele();
                await StokListesiniTazele();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        // Parça eklenip çıkarılınca açılır listedeki stok adetleri değişir; seçili parça yerinde kalsın.
        private async Task StokListesiniTazele()
        {
            int seciliSira = cmbParca.SelectedIndex;
            await ParcaListesiniYukle();
            if (seciliSira < cmbParca.Items.Count)
            {
                cmbParca.SelectedIndex = seciliSira;
            }
        }

        private async void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (txtNot.Text.Trim() == "")
            {
                MessageBox.Show("Önce notu yazın.");
                return;
            }

            try
            {
                await Api.Gonder("api/servis-kayitlari/" + kayitId + "/notlar", new NotIstegi { Metin = txtNot.Text });
                txtNot.Clear();
                await GecmisiYukle();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private async void btnKabulFormu_Click(object sender, EventArgs e)
        {
            await FormuAc("kabul-formu");
        }

        private async void btnTeslimFormu_Click(object sender, EventArgs e)
        {
            await FormuAc("teslim-formu");
        }

        // PDF'i API hazırlar; biz indirip bilgisayardaki PDF programıyla açarız. Oradan yazdırılabilir.
        private async Task FormuAc(string formAdi)
        {
            try
            {
                byte[] pdf = await Api.DosyaGetir("api/servis-kayitlari/" + kayitId + "/" + formAdi);
                Yardimci.DosyayiAc(pdf, kayit.No + "-" + formAdi + ".pdf");
            }
            catch (IOException)
            {
                MessageBox.Show("Form dosyası başka bir programda açık. Açık PDF'i kapatıp tekrar deneyin.");
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        // Müşteriye kaydın durumuna uygun bir mesaj hazırlar ve WhatsApp'ta açar.
        // Mesajı program göndermez; personel WhatsApp'ta kontrol edip kendisi gönderir.
        private async void btnWhatsApp_Click(object sender, EventArgs e)
        {
            string telefon = WhatsAppNumarasi(kayit.MusteriTelefon);
            if (telefon == "")
            {
                MessageBox.Show("Müşterinin telefon numarası kayıtlı değil ya da geçersiz.");
                return;
            }

            string mesaj = MusteriMesaji();
            Yardimci.AdresiAc("https://wa.me/" + telefon + "?text=" + Uri.EscapeDataString(mesaj));

            try
            {
                var not = new NotIstegi { Metin = "Müşteri WhatsApp ile bilgilendirildi (" + kayit.Durum + ")." };
                await Api.Gonder("api/servis-kayitlari/" + kayitId + "/notlar", not);
                await GecmisiYukle();
            }
            catch (Exception hata)
            {
                Yardimci.Hata(hata);
            }
        }

        private string MusteriMesaji()
        {
            string giris = "Merhaba " + kayit.MusteriAdi + ", " + kayit.No + " numaralı kayıttaki " + kayit.Cihaz + " cihazınız ";

            if (kayit.Durum == ServisDurumlari.DevamEdiyor)
            {
                return giris + "üzerinde çalışıyoruz. Hazır olduğunda size haber vereceğiz.";
            }
            if (kayit.Durum == ServisDurumlari.Tamamlandi)
            {
                return giris + "hazır. Toplam tutar: " + Yardimci.Para(kayit.ToplamTutar())
                    + ". Cihazınızı teslim alabilirsiniz.";
            }
            if (kayit.Durum == ServisDurumlari.TeslimEdildi)
            {
                return giris + "teslim edilmiştir. Bizi tercih ettiğiniz için teşekkür ederiz.";
            }
            if (kayit.Durum == ServisDurumlari.IptalEdildi)
            {
                return giris + "için servis kaydı kapatılmıştır. Cihazınızı teslim alabilirsiniz.";
            }
            return giris + "servisimize alınmıştır. Durumu hakkında sizi bilgilendireceğiz.";
        }

        // "0532 111 22 33" gibi bir numarayı WhatsApp'ın istediği "905321112233" biçimine çevirir.
        private static string WhatsAppNumarasi(string telefon)
        {
            string rakamlar = "";
            foreach (char karakter in telefon)
            {
                if (char.IsDigit(karakter))
                {
                    rakamlar += karakter;
                }
            }

            if (rakamlar.StartsWith("90") && rakamlar.Length == 12)
            {
                return rakamlar;
            }
            if (rakamlar.StartsWith("0") && rakamlar.Length == 11)
            {
                return "9" + rakamlar;
            }
            if (rakamlar.Length == 10)
            {
                return "90" + rakamlar;
            }
            return "";
        }
    }
}
