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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtArama.BackColor = Color.FromArgb(43, 26, 16);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.ForeColor = Color.FromArgb(243, 230, 214);
            txtArama.Location = new Point(12, 12);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(300, 23);
            txtArama.TabIndex = 0;
            txtArama.PlaceholderText = "Parça adı ya da kodu";
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(58, 36, 22);
            btnAra.Cursor = Cursors.Hand;
            btnAra.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnAra.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnAra.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.ForeColor = Color.FromArgb(243, 230, 214);
            btnAra.Location = new Point(320, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 25);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // dgvParcalar
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 21, 9);
            dgvParcalar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvParcalar.Location = new Point(12, 45);
            dgvParcalar.RowTemplate.Height = 28;
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(796, 380);
            dgvParcalar.TabIndex = 2;
            dgvParcalar.CellDoubleClick += dgvParcalar_CellDoubleClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.BackColor = Color.FromArgb(181, 128, 79);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.FromArgb(26, 17, 10);
            btnEkle.Location = new Point(12, 435);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 32);
            btnEkle.TabIndex = 3;
            btnEkle.Tag = "ana";
            btnEkle.Text = "Yeni parça";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDuzenle.BackColor = Color.FromArgb(58, 36, 22);
            btnDuzenle.Cursor = Cursors.Hand;
            btnDuzenle.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnDuzenle.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnDuzenle.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.ForeColor = Color.FromArgb(243, 230, 214);
            btnDuzenle.Location = new Point(128, 435);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(110, 32);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.BackColor = Color.FromArgb(58, 36, 22);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnSil.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnSil.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.FromArgb(243, 230, 214);
            btnSil.Location = new Point(244, 435);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 32);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
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
            nudStokAdet.BackColor = Color.FromArgb(43, 26, 16);
            nudStokAdet.BorderStyle = BorderStyle.FixedSingle;
            nudStokAdet.ForeColor = Color.FromArgb(243, 230, 214);
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
            btnStokGirisi.BackColor = Color.FromArgb(58, 36, 22);
            btnStokGirisi.Cursor = Cursors.Hand;
            btnStokGirisi.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnStokGirisi.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnStokGirisi.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnStokGirisi.FlatStyle = FlatStyle.Flat;
            btnStokGirisi.ForeColor = Color.FromArgb(243, 230, 214);
            btnStokGirisi.Location = new Point(525, 435);
            btnStokGirisi.Name = "btnStokGirisi";
            btnStokGirisi.Size = new Size(140, 32);
            btnStokGirisi.TabIndex = 8;
            btnStokGirisi.Text = "Stoğa ekle / düş";
            btnStokGirisi.UseVisualStyleBackColor = false;
            btnStokGirisi.Click += btnStokGirisi_Click;
            // 
            // lblStokNotu
            // 
            lblStokNotu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStokNotu.AutoSize = true;
            lblStokNotu.Location = new Point(675, 443);
            lblStokNotu.ForeColor = Color.FromArgb(184, 154, 124);
            lblStokNotu.Name = "lblStokNotu";
            lblStokNotu.TabIndex = 9;
            lblStokNotu.Text = "Eksi adet stoktan düşer.";
            // 
            // StokFormu
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 10);
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
            ForeColor = Color.FromArgb(243, 230, 214);
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
