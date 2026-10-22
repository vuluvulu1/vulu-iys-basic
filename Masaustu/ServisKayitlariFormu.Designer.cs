namespace Masaustu
{
    partial class ServisKayitlariFormu
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
            cmbDurum = new ComboBox();
            btnAra = new Button();
            dgvKayitlar = new DataGridView();
            btnYeni = new Button();
            btnAc = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.BackColor = Color.FromArgb(43, 26, 16);
            txtArama.BorderStyle = BorderStyle.FixedSingle;
            txtArama.ForeColor = Color.FromArgb(243, 230, 214);
            txtArama.Location = new Point(12, 12);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(250, 23);
            txtArama.TabIndex = 0;
            txtArama.PlaceholderText = "Kayıt no, müşteri, cihaz, seri no";
            // 
            // cmbDurum
            // 
            cmbDurum.BackColor = Color.FromArgb(43, 26, 16);
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.FlatStyle = FlatStyle.Flat;
            cmbDurum.ForeColor = Color.FromArgb(243, 230, 214);
            cmbDurum.Location = new Point(270, 12);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(150, 23);
            cmbDurum.TabIndex = 1;
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
            btnAra.Location = new Point(430, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 25);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // dgvKayitlar
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 21, 9);
            dgvKayitlar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvKayitlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKayitlar.BackgroundColor = Color.FromArgb(26, 17, 10);
            dgvKayitlar.BorderStyle = BorderStyle.None;
            dgvKayitlar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKayitlar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKayitlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKayitlar.ColumnHeadersHeight = 32;
            dgvKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 17, 10);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 46, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKayitlar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKayitlar.EnableHeadersVisualStyles = false;
            dgvKayitlar.GridColor = Color.FromArgb(74, 46, 28);
            dgvKayitlar.Location = new Point(12, 45);
            dgvKayitlar.RowTemplate.Height = 28;
            dgvKayitlar.Name = "dgvKayitlar";
            dgvKayitlar.Size = new Size(876, 420);
            dgvKayitlar.TabIndex = 3;
            dgvKayitlar.CellDoubleClick += dgvKayitlar_CellDoubleClick;
            // 
            // btnYeni
            // 
            btnYeni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnYeni.BackColor = Color.FromArgb(181, 128, 79);
            btnYeni.Cursor = Cursors.Hand;
            btnYeni.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnYeni.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnYeni.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnYeni.FlatStyle = FlatStyle.Flat;
            btnYeni.ForeColor = Color.FromArgb(26, 17, 10);
            btnYeni.Location = new Point(12, 475);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(120, 32);
            btnYeni.TabIndex = 4;
            btnYeni.Tag = "ana";
            btnYeni.Text = "Yeni kayıt";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnAc
            // 
            btnAc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAc.BackColor = Color.FromArgb(58, 36, 22);
            btnAc.Cursor = Cursors.Hand;
            btnAc.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnAc.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnAc.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.ForeColor = Color.FromArgb(243, 230, 214);
            btnAc.Location = new Point(138, 475);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(120, 32);
            btnAc.TabIndex = 5;
            btnAc.Text = "Aç / düzenle";
            btnAc.UseVisualStyleBackColor = false;
            btnAc.Click += btnAc_Click;
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
            btnSil.Location = new Point(264, 475);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 32);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // ServisKayitlariFormu
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(900, 520);
            Controls.Add(btnSil);
            Controls.Add(btnAc);
            Controls.Add(btnYeni);
            Controls.Add(dgvKayitlar);
            Controls.Add(btnAra);
            Controls.Add(cmbDurum);
            Controls.Add(txtArama);
            ForeColor = Color.FromArgb(243, 230, 214);
            MinimumSize = new Size(600, 300);
            Name = "ServisKayitlariFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Servis kayıtları";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArama;
        private ComboBox cmbDurum;
        private Button btnAra;
        private DataGridView dgvKayitlar;
        private Button btnYeni;
        private Button btnAc;
        private Button btnSil;
    }
}
