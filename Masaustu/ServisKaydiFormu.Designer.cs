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
            grpParcalar = new GroupBox();
            cmbParca = new ComboBox();
            nudAdet = new NumericUpDown();
            btnParcaEkle = new Button();
            dgvParcalar = new DataGridView();
            btnParcaCikar = new Button();
            grpParcalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIscilik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).BeginInit();
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
            cmbMusteri.Size = new Size(250, 23);
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
            cmbTeknisyen.Size = new Size(250, 23);
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
            txtCihaz.Size = new Size(250, 23);
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
            txtSeriNo.Size = new Size(250, 23);
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
            txtAksesuarlar.Size = new Size(250, 23);
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
            txtSorun.Size = new Size(250, 60);
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
            txtYapilanIslem.Size = new Size(250, 60);
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
            cmbDurum.Size = new Size(250, 23);
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
            btnKaydet.Size = new Size(120, 32);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.Location = new Point(260, 505);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(120, 32);
            btnKapat.TabIndex = 22;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            // 
            // grpParcalar
            // 
            grpParcalar.Controls.Add(cmbParca);
            grpParcalar.Controls.Add(nudAdet);
            grpParcalar.Controls.Add(btnParcaEkle);
            grpParcalar.Controls.Add(dgvParcalar);
            grpParcalar.Controls.Add(btnParcaCikar);
            grpParcalar.Location = new Point(410, 15);
            grpParcalar.Name = "grpParcalar";
            grpParcalar.Size = new Size(390, 480);
            grpParcalar.TabIndex = 23;
            grpParcalar.Text = "Kullanılan parçalar";
            // 
            // cmbParca
            // 
            cmbParca.FormattingEnabled = true;
            cmbParca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParca.Location = new Point(15, 25);
            cmbParca.Name = "cmbParca";
            cmbParca.Size = new Size(230, 23);
            cmbParca.TabIndex = 24;
            cmbParca.Format += cmbParca_Format;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(255, 25);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(50, 23);
            nudAdet.TabIndex = 25;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.Location = new Point(315, 24);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(60, 25);
            btnParcaEkle.TabIndex = 26;
            btnParcaEkle.Text = "Ekle";
            btnParcaEkle.UseVisualStyleBackColor = true;
            btnParcaEkle.Click += btnParcaEkle_Click;
            // 
            // dgvParcalar
            // 
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcalar.Location = new Point(15, 60);
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(360, 370);
            dgvParcalar.TabIndex = 27;
            // 
            // btnParcaCikar
            // 
            btnParcaCikar.Location = new Point(15, 440);
            btnParcaCikar.Name = "btnParcaCikar";
            btnParcaCikar.Size = new Size(160, 28);
            btnParcaCikar.TabIndex = 28;
            btnParcaCikar.Text = "Seçili parçayı çıkar";
            btnParcaCikar.UseVisualStyleBackColor = true;
            btnParcaCikar.Click += btnParcaCikar_Click;
            // 
            // ServisKaydiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(820, 560);
            Controls.Add(grpParcalar);
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
            grpParcalar.ResumeLayout(false);
            grpParcalar.PerformLayout();
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
        private GroupBox grpParcalar;
        private ComboBox cmbParca;
        private NumericUpDown nudAdet;
        private Button btnParcaEkle;
        private DataGridView dgvParcalar;
        private Button btnParcaCikar;
    }
}
