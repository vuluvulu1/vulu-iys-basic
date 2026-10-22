namespace Masaustu
{
    partial class StokFormu
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
            txtArama = new TextBox();
            btnAra = new Button();
            dgvParcalar = new DataGridView();
            btnEkle = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            lblAdet = new Label();
            nudStokAdet = new NumericUpDown();
            btnStokGirisi = new Button();
            lblStokNotu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStokAdet).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.Location = new Point(12, 12);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(300, 23);
            txtArama.TabIndex = 0;
            txtArama.PlaceholderText = "Parça adı ya da kodu";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(320, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 25);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvParcalar
            // 
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcalar.Location = new Point(12, 45);
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(796, 380);
            dgvParcalar.TabIndex = 2;
            dgvParcalar.CellDoubleClick += dgvParcalar_CellDoubleClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.Location = new Point(12, 435);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 32);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Yeni parça";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDuzenle.Location = new Point(128, 435);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(110, 32);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.Location = new Point(244, 435);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 32);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblAdet
            // 
            lblAdet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAdet.AutoSize = true;
            lblAdet.Location = new Point(400, 443);
            lblAdet.Name = "lblAdet";
            lblAdet.TabIndex = 6;
            lblAdet.Text = "Adet:";
            // 
            // nudStokAdet
            // 
            nudStokAdet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudStokAdet.Location = new Point(445, 439);
            nudStokAdet.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStokAdet.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            nudStokAdet.Name = "nudStokAdet";
            nudStokAdet.Size = new Size(70, 23);
            nudStokAdet.TabIndex = 7;
            nudStokAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnStokGirisi
            // 
            btnStokGirisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStokGirisi.Location = new Point(525, 435);
            btnStokGirisi.Name = "btnStokGirisi";
            btnStokGirisi.Size = new Size(140, 32);
            btnStokGirisi.TabIndex = 8;
            btnStokGirisi.Text = "Stoğa ekle / düş";
            btnStokGirisi.UseVisualStyleBackColor = true;
            btnStokGirisi.Click += btnStokGirisi_Click;
            // 
            // lblStokNotu
            // 
            lblStokNotu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStokNotu.AutoSize = true;
            lblStokNotu.Location = new Point(675, 443);
            lblStokNotu.ForeColor = SystemColors.GrayText;
            lblStokNotu.Name = "lblStokNotu";
            lblStokNotu.TabIndex = 9;
            lblStokNotu.Text = "Eksi adet stoktan düşer.";
            // 
            // StokFormu
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 500);
            Controls.Add(lblStokNotu);
            Controls.Add(btnStokGirisi);
            Controls.Add(nudStokAdet);
            Controls.Add(lblAdet);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(dgvParcalar);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            MinimumSize = new Size(700, 300);
            Name = "StokFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stok";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStokAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArama;
        private Button btnAra;
        private DataGridView dgvParcalar;
        private Button btnEkle;
        private Button btnDuzenle;
        private Button btnSil;
        private Label lblAdet;
        private NumericUpDown nudStokAdet;
        private Button btnStokGirisi;
        private Label lblStokNotu;
    }
}
