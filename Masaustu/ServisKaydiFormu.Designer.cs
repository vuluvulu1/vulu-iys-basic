namespace Masaustu
{
    partial class ServisKaydiFormu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNo = new Label();
            lblMusteri = new Label();
            cmbMusteri = new ComboBox();
            lblTeknisyen = new Label();
            cmbTeknisyen = new ComboBox();
            lblCihaz = new Label();
            txtCihaz = new TextBox();
            lblSeriNo = new Label();
            txtSeriNo = new TextBox();
            lblAksesuarlar = new Label();
            txtAksesuarlar = new TextBox();
            lblSorun = new Label();
            txtSorun = new TextBox();
            lblYapilanIslem = new Label();
            txtYapilanIslem = new TextBox();
            lblDurum = new Label();
            cmbDurum = new ComboBox();
            lblIscilik = new Label();
            nudIscilik = new NumericUpDown();
            chkOdendi = new CheckBox();
            lblToplam = new Label();
            btnKaydet = new Button();
            btnKapat = new Button();
            btnSekmeParcalar = new Button();
            btnSekmeTeklif = new Button();
            btnSekmeGecmis = new Button();
            pnlParcalar = new Panel();
            cmbParca = new ComboBox();
            nudAdet = new NumericUpDown();
            btnParcaEkle = new Button();
            dgvParcalar = new DataGridView();
            btnParcaCikar = new Button();
            pnlTeklif = new Panel();
            lblTeklifDurumu = new Label();
            lblTeklifBilgi = new Label();
            lblTeklifTutar = new Label();
            nudTeklifTutar = new NumericUpDown();
            lblTeklifAciklama = new Label();
            txtTeklifAciklama = new TextBox();
            btnTeklifVer = new Button();
            lblCevapBasligi = new Label();
            lblYanitNotu = new Label();
            txtYanitNotu = new TextBox();
            btnOnayladi = new Button();
            btnReddetti = new Button();
            lblCevapIpucu = new Label();
            pnlGecmis = new Panel();
            dgvGecmis = new DataGridView();
            txtNot = new TextBox();
            btnNotEkle = new Button();
            lblYeniKayitNotu = new Label();
            btnKabulFormu = new Button();
            btnTeslimFormu = new Button();
            btnWhatsApp = new Button();
            pnlParcalar.SuspendLayout();
            pnlTeklif.SuspendLayout();
            pnlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIscilik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTeklifTutar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).BeginInit();
            SuspendLayout();
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(20, 15);
            lblNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNo.Name = "lblNo";
            lblNo.TabIndex = 0;
            lblNo.Text = "Yeni kayıt";
            // 
            // lblMusteri
            // 
            lblMusteri.AutoSize = true;
            lblMusteri.Location = new Point(20, 53);
            lblMusteri.Name = "lblMusteri";
            lblMusteri.TabIndex = 1;
            lblMusteri.Text = "Müşteri";
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.Location = new Point(130, 50);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(260, 23);
            cmbMusteri.TabIndex = 2;
            // 
            // lblTeknisyen
            // 
            lblTeknisyen.AutoSize = true;
            lblTeknisyen.Location = new Point(20, 88);
            lblTeknisyen.Name = "lblTeknisyen";
            lblTeknisyen.TabIndex = 3;
            lblTeknisyen.Text = "Teknisyen";
            // 
            // cmbTeknisyen
            // 
            cmbTeknisyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeknisyen.Location = new Point(130, 85);
            cmbTeknisyen.Name = "cmbTeknisyen";
            cmbTeknisyen.Size = new Size(260, 23);
            cmbTeknisyen.TabIndex = 4;
            // 
            // lblCihaz
            // 
            lblCihaz.AutoSize = true;
            lblCihaz.Location = new Point(20, 123);
            lblCihaz.Name = "lblCihaz";
            lblCihaz.TabIndex = 5;
            lblCihaz.Text = "Cihaz";
            // 
            // txtCihaz
            // 
            txtCihaz.Location = new Point(130, 120);
            txtCihaz.Name = "txtCihaz";
            txtCihaz.Size = new Size(260, 23);
            txtCihaz.TabIndex = 6;
            // 
            // lblSeriNo
            // 
            lblSeriNo.AutoSize = true;
            lblSeriNo.Location = new Point(20, 158);
            lblSeriNo.Name = "lblSeriNo";
            lblSeriNo.TabIndex = 7;
            lblSeriNo.Text = "Seri no / IMEI";
            // 
            // txtSeriNo
            // 
            txtSeriNo.Location = new Point(130, 155);
            txtSeriNo.Name = "txtSeriNo";
            txtSeriNo.Size = new Size(260, 23);
            txtSeriNo.TabIndex = 8;
            // 
            // lblAksesuarlar
            // 
            lblAksesuarlar.AutoSize = true;
            lblAksesuarlar.Location = new Point(20, 193);
            lblAksesuarlar.Name = "lblAksesuarlar";
            lblAksesuarlar.TabIndex = 9;
            lblAksesuarlar.Text = "Aksesuarlar";
            // 
            // txtAksesuarlar
            // 
            txtAksesuarlar.Location = new Point(130, 190);
            txtAksesuarlar.Name = "txtAksesuarlar";
            txtAksesuarlar.Size = new Size(260, 23);
            txtAksesuarlar.TabIndex = 10;
            // 
            // lblSorun
            // 
            lblSorun.AutoSize = true;
            lblSorun.Location = new Point(20, 228);
            lblSorun.Name = "lblSorun";
            lblSorun.TabIndex = 11;
            lblSorun.Text = "Sorun";
            // 
            // txtSorun
            // 
            txtSorun.Location = new Point(130, 225);
            txtSorun.Multiline = true;
            txtSorun.ScrollBars = ScrollBars.Vertical;
            txtSorun.Name = "txtSorun";
            txtSorun.Size = new Size(260, 60);
            txtSorun.TabIndex = 12;
            // 
            // lblYapilanIslem
            // 
            lblYapilanIslem.AutoSize = true;
            lblYapilanIslem.Location = new Point(20, 298);
            lblYapilanIslem.Name = "lblYapilanIslem";
            lblYapilanIslem.TabIndex = 13;
            lblYapilanIslem.Text = "Yapılan işlem";
            // 
            // txtYapilanIslem
            // 
            txtYapilanIslem.Location = new Point(130, 295);
            txtYapilanIslem.Multiline = true;
            txtYapilanIslem.ScrollBars = ScrollBars.Vertical;
            txtYapilanIslem.Name = "txtYapilanIslem";
            txtYapilanIslem.Size = new Size(260, 60);
            txtYapilanIslem.TabIndex = 14;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(20, 368);
            lblDurum.Name = "lblDurum";
            lblDurum.TabIndex = 15;
            lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Location = new Point(130, 365);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(260, 23);
            cmbDurum.TabIndex = 16;
            // 
            // lblIscilik
            // 
            lblIscilik.AutoSize = true;
            lblIscilik.Location = new Point(20, 403);
            lblIscilik.Name = "lblIscilik";
            lblIscilik.TabIndex = 17;
            lblIscilik.Text = "İşçilik ücreti";
            // 
            // nudIscilik
            // 
            nudIscilik.DecimalPlaces = 2;
            nudIscilik.Location = new Point(130, 400);
            nudIscilik.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudIscilik.Name = "nudIscilik";
            nudIscilik.Size = new Size(150, 23);
            nudIscilik.TabIndex = 18;
            nudIscilik.ThousandsSeparator = true;
            nudIscilik.ValueChanged += nudIscilik_ValueChanged;
            // 
            // chkOdendi
            // 
            chkOdendi.AutoSize = true;
            chkOdendi.Location = new Point(130, 435);
            chkOdendi.Name = "chkOdendi";
            chkOdendi.TabIndex = 19;
            chkOdendi.Text = "Ödendi";
            chkOdendi.UseVisualStyleBackColor = true;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(20, 470);
            lblToplam.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplam.Name = "lblToplam";
            lblToplam.TabIndex = 20;
            lblToplam.Text = "Toplam: 0,00 ₺";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(130, 505);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 32);
            btnKaydet.TabIndex = 21;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.Location = new Point(265, 505);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(125, 32);
            btnKapat.TabIndex = 22;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnSekmeParcalar
            // 
            btnSekmeParcalar.Location = new Point(420, 15);
            btnSekmeParcalar.Name = "btnSekmeParcalar";
            btnSekmeParcalar.Size = new Size(110, 30);
            btnSekmeParcalar.TabIndex = 23;
            btnSekmeParcalar.Text = "Parçalar";
            btnSekmeParcalar.UseVisualStyleBackColor = true;
            btnSekmeParcalar.Click += btnSekmeParcalar_Click;
            // 
            // btnSekmeTeklif
            // 
            btnSekmeTeklif.Location = new Point(534, 15);
            btnSekmeTeklif.Name = "btnSekmeTeklif";
            btnSekmeTeklif.Size = new Size(110, 30);
            btnSekmeTeklif.TabIndex = 24;
            btnSekmeTeklif.Text = "Teklif";
            btnSekmeTeklif.UseVisualStyleBackColor = true;
            btnSekmeTeklif.Click += btnSekmeTeklif_Click;
            // 
            // btnSekmeGecmis
            // 
            btnSekmeGecmis.Location = new Point(648, 15);
            btnSekmeGecmis.Name = "btnSekmeGecmis";
            btnSekmeGecmis.Size = new Size(110, 30);
            btnSekmeGecmis.TabIndex = 25;
            btnSekmeGecmis.Text = "Geçmiş";
            btnSekmeGecmis.UseVisualStyleBackColor = true;
            btnSekmeGecmis.Click += btnSekmeGecmis_Click;
            // 
            // pnlParcalar
            // 
            pnlParcalar.Controls.Add(cmbParca);
            pnlParcalar.Controls.Add(nudAdet);
            pnlParcalar.Controls.Add(btnParcaEkle);
            pnlParcalar.Controls.Add(dgvParcalar);
            pnlParcalar.Controls.Add(btnParcaCikar);
            pnlParcalar.Location = new Point(420, 50);
            pnlParcalar.Name = "pnlParcalar";
            pnlParcalar.Size = new Size(420, 420);
            pnlParcalar.TabIndex = 26;
            pnlParcalar.Tag = "kart";
            // 
            // cmbParca
            // 
            cmbParca.FormattingEnabled = true;
            cmbParca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParca.Location = new Point(12, 12);
            cmbParca.Name = "cmbParca";
            cmbParca.Size = new Size(250, 23);
            cmbParca.TabIndex = 27;
            cmbParca.Format += cmbParca_Format;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(270, 12);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(55, 23);
            nudAdet.TabIndex = 28;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.Location = new Point(333, 11);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(75, 25);
            btnParcaEkle.TabIndex = 29;
            btnParcaEkle.Text = "Ekle";
            btnParcaEkle.UseVisualStyleBackColor = true;
            btnParcaEkle.Click += btnParcaEkle_Click;
            // 
            // dgvParcalar
            // 
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcalar.Location = new Point(12, 46);
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(396, 320);
            dgvParcalar.TabIndex = 30;
            // 
            // btnParcaCikar
            // 
            btnParcaCikar.Location = new Point(12, 376);
            btnParcaCikar.Name = "btnParcaCikar";
            btnParcaCikar.Size = new Size(170, 30);
            btnParcaCikar.TabIndex = 31;
            btnParcaCikar.Text = "Seçili parçayı çıkar";
            btnParcaCikar.UseVisualStyleBackColor = true;
            btnParcaCikar.Click += btnParcaCikar_Click;
            // 
            // pnlTeklif
            // 
            pnlTeklif.Controls.Add(lblTeklifDurumu);
            pnlTeklif.Controls.Add(lblTeklifBilgi);
            pnlTeklif.Controls.Add(lblTeklifTutar);
            pnlTeklif.Controls.Add(nudTeklifTutar);
            pnlTeklif.Controls.Add(lblTeklifAciklama);
            pnlTeklif.Controls.Add(txtTeklifAciklama);
            pnlTeklif.Controls.Add(btnTeklifVer);
            pnlTeklif.Controls.Add(lblCevapBasligi);
            pnlTeklif.Controls.Add(lblYanitNotu);
            pnlTeklif.Controls.Add(txtYanitNotu);
            pnlTeklif.Controls.Add(btnOnayladi);
            pnlTeklif.Controls.Add(btnReddetti);
            pnlTeklif.Controls.Add(lblCevapIpucu);
            pnlTeklif.Location = new Point(420, 50);
            pnlTeklif.Name = "pnlTeklif";
            pnlTeklif.Size = new Size(420, 420);
            pnlTeklif.TabIndex = 32;
            pnlTeklif.Tag = "kart";
            // 
            // lblTeklifDurumu
            // 
            lblTeklifDurumu.AutoSize = true;
            lblTeklifDurumu.Location = new Point(12, 12);
            lblTeklifDurumu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTeklifDurumu.Name = "lblTeklifDurumu";
            lblTeklifDurumu.TabIndex = 33;
            lblTeklifDurumu.Text = "Henüz teklif verilmedi";
            // 
            // lblTeklifBilgi
            // 
            lblTeklifBilgi.AutoSize = true;
            lblTeklifBilgi.Location = new Point(12, 36);
            lblTeklifBilgi.ForeColor = SystemColors.GrayText;
            lblTeklifBilgi.Name = "lblTeklifBilgi";
            lblTeklifBilgi.TabIndex = 34;
            lblTeklifBilgi.Text = "";
            // 
            // lblTeklifTutar
            // 
            lblTeklifTutar.AutoSize = true;
            lblTeklifTutar.Location = new Point(12, 78);
            lblTeklifTutar.Name = "lblTeklifTutar";
            lblTeklifTutar.TabIndex = 35;
            lblTeklifTutar.Text = "Tutar";
            // 
            // nudTeklifTutar
            // 
            nudTeklifTutar.DecimalPlaces = 2;
            nudTeklifTutar.Location = new Point(110, 75);
            nudTeklifTutar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudTeklifTutar.Name = "nudTeklifTutar";
            nudTeklifTutar.Size = new Size(150, 23);
            nudTeklifTutar.TabIndex = 36;
            nudTeklifTutar.ThousandsSeparator = true;
            // 
            // lblTeklifAciklama
            // 
            lblTeklifAciklama.AutoSize = true;
            lblTeklifAciklama.Location = new Point(12, 113);
            lblTeklifAciklama.Name = "lblTeklifAciklama";
            lblTeklifAciklama.TabIndex = 37;
            lblTeklifAciklama.Text = "Açıklama";
            // 
            // txtTeklifAciklama
            // 
            txtTeklifAciklama.Location = new Point(110, 110);
            txtTeklifAciklama.Multiline = true;
            txtTeklifAciklama.ScrollBars = ScrollBars.Vertical;
            txtTeklifAciklama.Name = "txtTeklifAciklama";
            txtTeklifAciklama.Size = new Size(296, 56);
            txtTeklifAciklama.TabIndex = 38;
            // 
            // btnTeklifVer
            // 
            btnTeklifVer.Location = new Point(110, 176);
            btnTeklifVer.Name = "btnTeklifVer";
            btnTeklifVer.Size = new Size(140, 30);
            btnTeklifVer.TabIndex = 39;
            btnTeklifVer.Tag = "ana";
            btnTeklifVer.Text = "Teklif ver";
            btnTeklifVer.UseVisualStyleBackColor = true;
            btnTeklifVer.Click += btnTeklifVer_Click;
            // 
            // lblCevapBasligi
            // 
            lblCevapBasligi.AutoSize = true;
            lblCevapBasligi.Location = new Point(12, 228);
            lblCevapBasligi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCevapBasligi.Name = "lblCevapBasligi";
            lblCevapBasligi.TabIndex = 40;
            lblCevapBasligi.Text = "Müşterinin cevabı";
            // 
            // lblYanitNotu
            // 
            lblYanitNotu.AutoSize = true;
            lblYanitNotu.Location = new Point(12, 261);
            lblYanitNotu.Name = "lblYanitNotu";
            lblYanitNotu.TabIndex = 41;
            lblYanitNotu.Text = "Not";
            // 
            // txtYanitNotu
            // 
            txtYanitNotu.Location = new Point(110, 258);
            txtYanitNotu.Name = "txtYanitNotu";
            txtYanitNotu.Size = new Size(296, 23);
            txtYanitNotu.TabIndex = 42;
            txtYanitNotu.PlaceholderText = "Örn. telefonla aradı, onayladı";
            // 
            // btnOnayladi
            // 
            btnOnayladi.Location = new Point(110, 292);
            btnOnayladi.Name = "btnOnayladi";
            btnOnayladi.Size = new Size(145, 30);
            btnOnayladi.TabIndex = 43;
            btnOnayladi.Text = "Müşteri onayladı";
            btnOnayladi.UseVisualStyleBackColor = true;
            btnOnayladi.Click += btnOnayladi_Click;
            // 
            // btnReddetti
            // 
            btnReddetti.Location = new Point(261, 292);
            btnReddetti.Name = "btnReddetti";
            btnReddetti.Size = new Size(145, 30);
            btnReddetti.TabIndex = 44;
            btnReddetti.Text = "Müşteri reddetti";
            btnReddetti.UseVisualStyleBackColor = true;
            btnReddetti.Click += btnReddetti_Click;
            // 
            // lblCevapIpucu
            // 
            lblCevapIpucu.AutoSize = true;
            lblCevapIpucu.Location = new Point(12, 340);
            lblCevapIpucu.ForeColor = SystemColors.GrayText;
            lblCevapIpucu.Name = "lblCevapIpucu";
            lblCevapIpucu.TabIndex = 45;
            lblCevapIpucu.Text = "Onaylanınca kayıt \"Devam ediyor\", reddedilince \"İptal edildi\" olur.";
            // 
            // pnlGecmis
            // 
            pnlGecmis.Controls.Add(dgvGecmis);
            pnlGecmis.Controls.Add(txtNot);
            pnlGecmis.Controls.Add(btnNotEkle);
            pnlGecmis.Location = new Point(420, 50);
            pnlGecmis.Name = "pnlGecmis";
            pnlGecmis.Size = new Size(420, 420);
            pnlGecmis.TabIndex = 46;
            pnlGecmis.Tag = "kart";
            // 
            // dgvGecmis
            // 
            dgvGecmis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGecmis.Location = new Point(12, 12);
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.Size = new Size(396, 352);
            dgvGecmis.TabIndex = 47;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(12, 376);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(300, 23);
            txtNot.TabIndex = 48;
            txtNot.PlaceholderText = "Kayda not ekleyin";
            // 
            // btnNotEkle
            // 
            btnNotEkle.Location = new Point(318, 375);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(90, 25);
            btnNotEkle.TabIndex = 49;
            btnNotEkle.Text = "Not ekle";
            btnNotEkle.UseVisualStyleBackColor = true;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // lblYeniKayitNotu
            // 
            lblYeniKayitNotu.AutoSize = true;
            lblYeniKayitNotu.Location = new Point(422, 62);
            lblYeniKayitNotu.ForeColor = SystemColors.GrayText;
            lblYeniKayitNotu.Name = "lblYeniKayitNotu";
            lblYeniKayitNotu.TabIndex = 50;
            lblYeniKayitNotu.Text = "Parça, teklif, geçmiş ve formlar için önce kaydı kaydedin.";
            // 
            // btnKabulFormu
            // 
            btnKabulFormu.Location = new Point(420, 505);
            btnKabulFormu.Name = "btnKabulFormu";
            btnKabulFormu.Size = new Size(130, 32);
            btnKabulFormu.TabIndex = 51;
            btnKabulFormu.Text = "Kabul formu";
            btnKabulFormu.UseVisualStyleBackColor = true;
            btnKabulFormu.Click += btnKabulFormu_Click;
            // 
            // btnTeslimFormu
            // 
            btnTeslimFormu.Location = new Point(556, 505);
            btnTeslimFormu.Name = "btnTeslimFormu";
            btnTeslimFormu.Size = new Size(130, 32);
            btnTeslimFormu.TabIndex = 52;
            btnTeslimFormu.Text = "Teslim formu";
            btnTeslimFormu.UseVisualStyleBackColor = true;
            btnTeslimFormu.Click += btnTeslimFormu_Click;
            // 
            // btnWhatsApp
            // 
            btnWhatsApp.Location = new Point(692, 505);
            btnWhatsApp.Name = "btnWhatsApp";
            btnWhatsApp.Size = new Size(148, 32);
            btnWhatsApp.TabIndex = 53;
            btnWhatsApp.Text = "WhatsApp ile bildir";
            btnWhatsApp.UseVisualStyleBackColor = true;
            btnWhatsApp.Click += btnWhatsApp_Click;
            // 
            // ServisKaydiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(860, 560);
            Controls.Add(btnWhatsApp);
            Controls.Add(btnTeslimFormu);
            Controls.Add(btnKabulFormu);
            Controls.Add(lblYeniKayitNotu);
            Controls.Add(pnlGecmis);
            Controls.Add(pnlTeklif);
            Controls.Add(pnlParcalar);
            Controls.Add(btnSekmeGecmis);
            Controls.Add(btnSekmeTeklif);
            Controls.Add(btnSekmeParcalar);
            Controls.Add(btnKapat);
            Controls.Add(btnKaydet);
            Controls.Add(lblToplam);
            Controls.Add(chkOdendi);
            Controls.Add(nudIscilik);
            Controls.Add(lblIscilik);
            Controls.Add(cmbDurum);
            Controls.Add(lblDurum);
            Controls.Add(txtYapilanIslem);
            Controls.Add(lblYapilanIslem);
            Controls.Add(txtSorun);
            Controls.Add(lblSorun);
            Controls.Add(txtAksesuarlar);
            Controls.Add(lblAksesuarlar);
            Controls.Add(txtSeriNo);
            Controls.Add(lblSeriNo);
            Controls.Add(txtCihaz);
            Controls.Add(lblCihaz);
            Controls.Add(cmbTeknisyen);
            Controls.Add(lblTeknisyen);
            Controls.Add(cmbMusteri);
            Controls.Add(lblMusteri);
            Controls.Add(lblNo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ServisKaydiFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servis kaydı";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)nudIscilik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTeklifTutar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            pnlParcalar.ResumeLayout(false);
            pnlParcalar.PerformLayout();
            pnlTeklif.ResumeLayout(false);
            pnlTeklif.PerformLayout();
            pnlGecmis.ResumeLayout(false);
            pnlGecmis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNo;
        private Label lblMusteri;
        private ComboBox cmbMusteri;
        private Label lblTeknisyen;
        private ComboBox cmbTeknisyen;
        private Label lblCihaz;
        private TextBox txtCihaz;
        private Label lblSeriNo;
        private TextBox txtSeriNo;
        private Label lblAksesuarlar;
        private TextBox txtAksesuarlar;
        private Label lblSorun;
        private TextBox txtSorun;
        private Label lblYapilanIslem;
        private TextBox txtYapilanIslem;
        private Label lblDurum;
        private ComboBox cmbDurum;
        private Label lblIscilik;
        private NumericUpDown nudIscilik;
        private CheckBox chkOdendi;
        private Label lblToplam;
        private Button btnKaydet;
        private Button btnKapat;
        private Button btnSekmeParcalar;
        private Button btnSekmeTeklif;
        private Button btnSekmeGecmis;
        private Panel pnlParcalar;
        private ComboBox cmbParca;
        private NumericUpDown nudAdet;
        private Button btnParcaEkle;
        private DataGridView dgvParcalar;
        private Button btnParcaCikar;
        private Panel pnlTeklif;
        private Label lblTeklifDurumu;
        private Label lblTeklifBilgi;
        private Label lblTeklifTutar;
        private NumericUpDown nudTeklifTutar;
        private Label lblTeklifAciklama;
        private TextBox txtTeklifAciklama;
        private Button btnTeklifVer;
        private Label lblCevapBasligi;
        private Label lblYanitNotu;
        private TextBox txtYanitNotu;
        private Button btnOnayladi;
        private Button btnReddetti;
        private Label lblCevapIpucu;
        private Panel pnlGecmis;
        private DataGridView dgvGecmis;
        private TextBox txtNot;
        private Button btnNotEkle;
        private Label lblYeniKayitNotu;
        private Button btnKabulFormu;
        private Button btnTeslimFormu;
        private Button btnWhatsApp;
    }
}
