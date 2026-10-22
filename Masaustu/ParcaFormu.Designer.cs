namespace Masaustu
{
    partial class ParcaFormu
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
            lblAd = new Label();
            txtAd = new TextBox();
            lblKod = new Label();
            txtKod = new TextBox();
            lblFiyat = new Label();
            nudFiyat = new NumericUpDown();
            lblStok = new Label();
            nudStok = new NumericUpDown();
            lblKritik = new Label();
            nudKritik = new NumericUpDown();
            btnKaydet = new Button();
            btnVazgec = new Button();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKritik).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(20, 23);
            lblAd.Name = "lblAd";
            lblAd.TabIndex = 0;
            lblAd.Text = "Parça adı";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(43, 26, 16);
            txtAd.BorderStyle = BorderStyle.FixedSingle;
            txtAd.ForeColor = Color.FromArgb(243, 230, 214);
            txtAd.Location = new Point(130, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(240, 23);
            txtAd.TabIndex = 1;
            // 
            // lblKod
            // 
            lblKod.AutoSize = true;
            lblKod.Location = new Point(20, 58);
            lblKod.Name = "lblKod";
            lblKod.TabIndex = 2;
            lblKod.Text = "Kod";
            // 
            // txtKod
            // 
            txtKod.BackColor = Color.FromArgb(43, 26, 16);
            txtKod.BorderStyle = BorderStyle.FixedSingle;
            txtKod.ForeColor = Color.FromArgb(243, 230, 214);
            txtKod.Location = new Point(130, 55);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(240, 23);
            txtKod.TabIndex = 3;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(20, 93);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.TabIndex = 4;
            lblFiyat.Text = "Satış fiyatı";
            // 
            // nudFiyat
            // 
            nudFiyat.BackColor = Color.FromArgb(43, 26, 16);
            nudFiyat.BorderStyle = BorderStyle.FixedSingle;
            nudFiyat.ForeColor = Color.FromArgb(243, 230, 214);
            nudFiyat.DecimalPlaces = 2;
            nudFiyat.Location = new Point(130, 90);
            nudFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(120, 23);
            nudFiyat.TabIndex = 5;
            nudFiyat.ThousandsSeparator = true;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(20, 128);
            lblStok.Name = "lblStok";
            lblStok.TabIndex = 6;
            lblStok.Text = "Başlangıç stoğu";
            // 
            // nudStok
            // 
            nudStok.BackColor = Color.FromArgb(43, 26, 16);
            nudStok.BorderStyle = BorderStyle.FixedSingle;
            nudStok.ForeColor = Color.FromArgb(243, 230, 214);
            nudStok.Location = new Point(130, 125);
            nudStok.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(120, 23);
            nudStok.TabIndex = 7;
            // 
            // lblKritik
            // 
            lblKritik.AutoSize = true;
            lblKritik.Location = new Point(20, 163);
            lblKritik.Name = "lblKritik";
            lblKritik.TabIndex = 8;
            lblKritik.Text = "Kritik seviye";
            // 
            // nudKritik
            // 
            nudKritik.BackColor = Color.FromArgb(43, 26, 16);
            nudKritik.BorderStyle = BorderStyle.FixedSingle;
            nudKritik.ForeColor = Color.FromArgb(243, 230, 214);
            nudKritik.Location = new Point(130, 160);
            nudKritik.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudKritik.Name = "nudKritik";
            nudKritik.Size = new Size(120, 23);
            nudKritik.TabIndex = 9;
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
            btnKaydet.Location = new Point(160, 205);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 32);
            btnKaydet.TabIndex = 10;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.BackColor = Color.FromArgb(58, 36, 22);
            btnVazgec.Cursor = Cursors.Hand;
            btnVazgec.DialogResult = DialogResult.Cancel;
            btnVazgec.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnVazgec.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnVazgec.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnVazgec.FlatStyle = FlatStyle.Flat;
            btnVazgec.ForeColor = Color.FromArgb(243, 230, 214);
            btnVazgec.Location = new Point(270, 205);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 11;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = false;
            // 
            // ParcaFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVazgec;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(400, 250);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(nudKritik);
            Controls.Add(lblKritik);
            Controls.Add(nudStok);
            Controls.Add(lblStok);
            Controls.Add(nudFiyat);
            Controls.Add(lblFiyat);
            Controls.Add(txtKod);
            Controls.Add(lblKod);
            Controls.Add(txtAd);
            Controls.Add(lblAd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ForeColor = Color.FromArgb(243, 230, 214);
            Name = "ParcaFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parça";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKritik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private TextBox txtAd;
        private Label lblKod;
        private TextBox txtKod;
        private Label lblFiyat;
        private NumericUpDown nudFiyat;
        private Label lblStok;
        private NumericUpDown nudStok;
        private Label lblKritik;
        private NumericUpDown nudKritik;
        private Button btnKaydet;
        private Button btnVazgec;
    }
}
