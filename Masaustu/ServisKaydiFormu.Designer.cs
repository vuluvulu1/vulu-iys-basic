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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            btnSekmeGecmis = new Button();
            pnlParcalar = new Panel();
            cmbParca = new ComboBox();
            nudAdet = new NumericUpDown();
            btnParcaEkle = new Button();
            dgvParcalar = new DataGridView();
            btnParcaCikar = new Button();
            pnlGecmis = new Panel();
            dgvGecmis = new DataGridView();
            txtNot = new TextBox();
            btnNotEkle = new Button();
            lblYeniKayitNotu = new Label();
            btnKabulFormu = new Button();
            btnTeslimFormu = new Button();
            btnWhatsApp = new Button();
            pnlParcalar.SuspendLayout();
            pnlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIscilik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).BeginInit();
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
            cmbMusteri.BackColor = Color.FromArgb(43, 26, 16);
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FlatStyle = FlatStyle.Flat;
            cmbMusteri.ForeColor = Color.FromArgb(243, 230, 214);
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
            cmbTeknisyen.BackColor = Color.FromArgb(43, 26, 16);
            cmbTeknisyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTeknisyen.FlatStyle = FlatStyle.Flat;
            cmbTeknisyen.ForeColor = Color.FromArgb(243, 230, 214);
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
            txtCihaz.BackColor = Color.FromArgb(43, 26, 16);
            txtCihaz.BorderStyle = BorderStyle.FixedSingle;
            txtCihaz.ForeColor = Color.FromArgb(243, 230, 214);
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
            txtSeriNo.BackColor = Color.FromArgb(43, 26, 16);
            txtSeriNo.BorderStyle = BorderStyle.FixedSingle;
            txtSeriNo.ForeColor = Color.FromArgb(243, 230, 214);
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
            txtAksesuarlar.BackColor = Color.FromArgb(43, 26, 16);
            txtAksesuarlar.BorderStyle = BorderStyle.FixedSingle;
            txtAksesuarlar.ForeColor = Color.FromArgb(243, 230, 214);
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
            txtSorun.BackColor = Color.FromArgb(43, 26, 16);
            txtSorun.BorderStyle = BorderStyle.FixedSingle;
            txtSorun.ForeColor = Color.FromArgb(243, 230, 214);
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
            txtYapilanIslem.BackColor = Color.FromArgb(43, 26, 16);
            txtYapilanIslem.BorderStyle = BorderStyle.FixedSingle;
            txtYapilanIslem.ForeColor = Color.FromArgb(243, 230, 214);
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
            cmbDurum.BackColor = Color.FromArgb(43, 26, 16);
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FlatStyle = FlatStyle.Flat;
            cmbDurum.ForeColor = Color.FromArgb(243, 230, 214);
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
            nudIscilik.BackColor = Color.FromArgb(43, 26, 16);
            nudIscilik.BorderStyle = BorderStyle.FixedSingle;
            nudIscilik.ForeColor = Color.FromArgb(243, 230, 214);
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
            btnKaydet.BackColor = Color.FromArgb(181, 128, 79);
            btnKaydet.Cursor = Cursors.Hand;
            btnKaydet.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnKaydet.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnKaydet.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.FromArgb(26, 17, 10);
            btnKaydet.Location = new Point(130, 505);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 32);
            btnKaydet.TabIndex = 21;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.FromArgb(58, 36, 22);
            btnKapat.Cursor = Cursors.Hand;
            btnKapat.DialogResult = DialogResult.Cancel;
            btnKapat.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnKapat.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnKapat.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.ForeColor = Color.FromArgb(243, 230, 214);
            btnKapat.Location = new Point(265, 505);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(125, 32);
            btnKapat.TabIndex = 22;
            btnKapat.Text = "Kapat";
            btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnSekmeParcalar
            // 
            btnSekmeParcalar.BackColor = Color.FromArgb(58, 36, 22);
            btnSekmeParcalar.Cursor = Cursors.Hand;
            btnSekmeParcalar.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnSekmeParcalar.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnSekmeParcalar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnSekmeParcalar.FlatStyle = FlatStyle.Flat;
            btnSekmeParcalar.ForeColor = Color.FromArgb(243, 230, 214);
            btnSekmeParcalar.Location = new Point(420, 15);
            btnSekmeParcalar.Name = "btnSekmeParcalar";
            btnSekmeParcalar.Size = new Size(110, 30);
            btnSekmeParcalar.TabIndex = 23;
            btnSekmeParcalar.Text = "Parçalar";
            btnSekmeParcalar.UseVisualStyleBackColor = false;
            btnSekmeParcalar.Click += btnSekmeParcalar_Click;
            // 
            // btnSekmeGecmis
            // 
            btnSekmeGecmis.BackColor = Color.FromArgb(58, 36, 22);
            btnSekmeGecmis.Cursor = Cursors.Hand;
            btnSekmeGecmis.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnSekmeGecmis.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnSekmeGecmis.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnSekmeGecmis.FlatStyle = FlatStyle.Flat;
            btnSekmeGecmis.ForeColor = Color.FromArgb(243, 230, 214);
            btnSekmeGecmis.Location = new Point(534, 15);
            btnSekmeGecmis.Name = "btnSekmeGecmis";
            btnSekmeGecmis.Size = new Size(110, 30);
            btnSekmeGecmis.TabIndex = 24;
            btnSekmeGecmis.Text = "Geçmiş";
            btnSekmeGecmis.UseVisualStyleBackColor = false;
            btnSekmeGecmis.Click += btnSekmeGecmis_Click;
            // 
            // pnlParcalar
            // 
            pnlParcalar.Controls.Add(cmbParca);
            pnlParcalar.Controls.Add(nudAdet);
            pnlParcalar.Controls.Add(btnParcaEkle);
            pnlParcalar.Controls.Add(dgvParcalar);
            pnlParcalar.Controls.Add(btnParcaCikar);
            pnlParcalar.BackColor = Color.FromArgb(43, 26, 16);
            pnlParcalar.Location = new Point(420, 50);
            pnlParcalar.Name = "pnlParcalar";
            pnlParcalar.Size = new Size(420, 420);
            pnlParcalar.TabIndex = 25;
            pnlParcalar.Tag = "kart";
            // 
            // cmbParca
            // 
            cmbParca.BackColor = Color.FromArgb(43, 26, 16);
            cmbParca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbParca.FlatStyle = FlatStyle.Flat;
            cmbParca.ForeColor = Color.FromArgb(243, 230, 214);
            cmbParca.FormattingEnabled = true;
            cmbParca.Location = new Point(12, 12);
            cmbParca.Name = "cmbParca";
            cmbParca.Size = new Size(250, 23);
            cmbParca.TabIndex = 26;
            cmbParca.Format += cmbParca_Format;
            // 
            // nudAdet
            // 
            nudAdet.BackColor = Color.FromArgb(43, 26, 16);
            nudAdet.BorderStyle = BorderStyle.FixedSingle;
            nudAdet.ForeColor = Color.FromArgb(243, 230, 214);
            nudAdet.Location = new Point(270, 12);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(55, 23);
            nudAdet.TabIndex = 27;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.BackColor = Color.FromArgb(58, 36, 22);
            btnParcaEkle.Cursor = Cursors.Hand;
            btnParcaEkle.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnParcaEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnParcaEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnParcaEkle.FlatStyle = FlatStyle.Flat;
            btnParcaEkle.ForeColor = Color.FromArgb(243, 230, 214);
            btnParcaEkle.Location = new Point(333, 11);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(75, 25);
            btnParcaEkle.TabIndex = 28;
            btnParcaEkle.Text = "Ekle";
            btnParcaEkle.UseVisualStyleBackColor = false;
            btnParcaEkle.Click += btnParcaEkle_Click;
            // 
            // dgvParcalar
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 21, 9);
            dgvParcalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcalar.BackgroundColor = Color.FromArgb(26, 17, 10);
            dgvParcalar.BorderStyle = BorderStyle.None;
            dgvParcalar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvParcalar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvParcalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvParcalar.ColumnHeadersHeight = 32;
            dgvParcalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 17, 10);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 46, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvParcalar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvParcalar.EnableHeadersVisualStyles = false;
            dgvParcalar.GridColor = Color.FromArgb(74, 46, 28);
            dgvParcalar.Location = new Point(12, 46);
            dgvParcalar.RowTemplate.Height = 28;
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(396, 320);
            dgvParcalar.TabIndex = 29;
            // 
            // btnParcaCikar
            // 
            btnParcaCikar.BackColor = Color.FromArgb(58, 36, 22);
            btnParcaCikar.Cursor = Cursors.Hand;
            btnParcaCikar.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnParcaCikar.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnParcaCikar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnParcaCikar.FlatStyle = FlatStyle.Flat;
            btnParcaCikar.ForeColor = Color.FromArgb(243, 230, 214);
            btnParcaCikar.Location = new Point(12, 376);
            btnParcaCikar.Name = "btnParcaCikar";
            btnParcaCikar.Size = new Size(170, 30);
            btnParcaCikar.TabIndex = 30;
            btnParcaCikar.Text = "Seçili parçayı çıkar";
            btnParcaCikar.UseVisualStyleBackColor = false;
            btnParcaCikar.Click += btnParcaCikar_Click;
            // 
            // pnlGecmis
            // 
            pnlGecmis.Controls.Add(dgvGecmis);
            pnlGecmis.Controls.Add(txtNot);
            pnlGecmis.Controls.Add(btnNotEkle);
            pnlGecmis.BackColor = Color.FromArgb(43, 26, 16);
            pnlGecmis.Location = new Point(420, 50);
            pnlGecmis.Name = "pnlGecmis";
            pnlGecmis.Size = new Size(420, 420);
            pnlGecmis.TabIndex = 31;
            pnlGecmis.Tag = "kart";
            // 
            // dgvGecmis
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(33, 21, 9);
            dgvGecmis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvGecmis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvGecmis.BackgroundColor = Color.FromArgb(26, 17, 10);
            dgvGecmis.BorderStyle = BorderStyle.None;
            dgvGecmis.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGecmis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle4.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvGecmis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvGecmis.ColumnHeadersHeight = 32;
            dgvGecmis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 17, 10);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle5.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(74, 46, 28);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvGecmis.DefaultCellStyle = dataGridViewCellStyle5;
            dgvGecmis.EnableHeadersVisualStyles = false;
            dgvGecmis.GridColor = Color.FromArgb(74, 46, 28);
            dgvGecmis.Location = new Point(12, 12);
            dgvGecmis.RowTemplate.Height = 28;
            dgvGecmis.Name = "dgvGecmis";
            dgvGecmis.Size = new Size(396, 352);
            dgvGecmis.TabIndex = 32;
            // 
            // txtNot
            // 
            txtNot.BackColor = Color.FromArgb(43, 26, 16);
            txtNot.BorderStyle = BorderStyle.FixedSingle;
            txtNot.ForeColor = Color.FromArgb(243, 230, 214);
            txtNot.Location = new Point(12, 376);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(300, 23);
            txtNot.TabIndex = 33;
            txtNot.PlaceholderText = "Kayda not ekleyin";
            // 
            // btnNotEkle
            // 
            btnNotEkle.BackColor = Color.FromArgb(58, 36, 22);
            btnNotEkle.Cursor = Cursors.Hand;
            btnNotEkle.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnNotEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnNotEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnNotEkle.FlatStyle = FlatStyle.Flat;
            btnNotEkle.ForeColor = Color.FromArgb(243, 230, 214);
            btnNotEkle.Location = new Point(318, 375);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(90, 25);
            btnNotEkle.TabIndex = 34;
            btnNotEkle.Text = "Not ekle";
            btnNotEkle.UseVisualStyleBackColor = false;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // lblYeniKayitNotu
            // 
            lblYeniKayitNotu.AutoSize = true;
            lblYeniKayitNotu.Location = new Point(422, 62);
            lblYeniKayitNotu.ForeColor = Color.FromArgb(184, 154, 124);
            lblYeniKayitNotu.Name = "lblYeniKayitNotu";
            lblYeniKayitNotu.TabIndex = 35;
            lblYeniKayitNotu.Text = "Parça, geçmiş ve formlar için önce kaydı kaydedin.";
            // 
            // btnKabulFormu
            // 
            btnKabulFormu.BackColor = Color.FromArgb(58, 36, 22);
            btnKabulFormu.Cursor = Cursors.Hand;
            btnKabulFormu.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnKabulFormu.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnKabulFormu.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnKabulFormu.FlatStyle = FlatStyle.Flat;
            btnKabulFormu.ForeColor = Color.FromArgb(243, 230, 214);
            btnKabulFormu.Location = new Point(420, 505);
            btnKabulFormu.Name = "btnKabulFormu";
            btnKabulFormu.Size = new Size(130, 32);
            btnKabulFormu.TabIndex = 36;
            btnKabulFormu.Text = "Kabul formu";
            btnKabulFormu.UseVisualStyleBackColor = false;
            btnKabulFormu.Click += btnKabulFormu_Click;
            // 
            // btnTeslimFormu
            // 
            btnTeslimFormu.BackColor = Color.FromArgb(58, 36, 22);
            btnTeslimFormu.Cursor = Cursors.Hand;
            btnTeslimFormu.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnTeslimFormu.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnTeslimFormu.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnTeslimFormu.FlatStyle = FlatStyle.Flat;
            btnTeslimFormu.ForeColor = Color.FromArgb(243, 230, 214);
            btnTeslimFormu.Location = new Point(556, 505);
            btnTeslimFormu.Name = "btnTeslimFormu";
            btnTeslimFormu.Size = new Size(130, 32);
            btnTeslimFormu.TabIndex = 37;
            btnTeslimFormu.Text = "Teslim formu";
            btnTeslimFormu.UseVisualStyleBackColor = false;
            btnTeslimFormu.Click += btnTeslimFormu_Click;
            // 
            // btnWhatsApp
            // 
            btnWhatsApp.BackColor = Color.FromArgb(58, 36, 22);
            btnWhatsApp.Cursor = Cursors.Hand;
            btnWhatsApp.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnWhatsApp.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnWhatsApp.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnWhatsApp.FlatStyle = FlatStyle.Flat;
            btnWhatsApp.ForeColor = Color.FromArgb(243, 230, 214);
            btnWhatsApp.Location = new Point(692, 505);
            btnWhatsApp.Name = "btnWhatsApp";
            btnWhatsApp.Size = new Size(148, 32);
            btnWhatsApp.TabIndex = 38;
            btnWhatsApp.Text = "WhatsApp ile bildir";
            btnWhatsApp.UseVisualStyleBackColor = false;
            btnWhatsApp.Click += btnWhatsApp_Click;
            // 
            // ServisKaydiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(860, 560);
            Controls.Add(btnWhatsApp);
            Controls.Add(btnTeslimFormu);
            Controls.Add(btnKabulFormu);
            Controls.Add(lblYeniKayitNotu);
            Controls.Add(pnlGecmis);
            Controls.Add(pnlParcalar);
            Controls.Add(btnSekmeGecmis);
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
            ForeColor = Color.FromArgb(243, 230, 214);
            Name = "ServisKaydiFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servis kaydı";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)nudIscilik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGecmis).EndInit();
            pnlParcalar.ResumeLayout(false);
            pnlParcalar.PerformLayout();
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
        private Button btnSekmeGecmis;
        private Panel pnlParcalar;
        private ComboBox cmbParca;
        private NumericUpDown nudAdet;
        private Button btnParcaEkle;
        private DataGridView dgvParcalar;
        private Button btnParcaCikar;
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
