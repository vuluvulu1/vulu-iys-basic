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
            txtArama.Location = new Point(12, 12);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(250, 23);
            txtArama.TabIndex = 0;
            txtArama.PlaceholderText = "Kayıt no, müşteri, cihaz, seri no";
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Location = new Point(270, 12);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(150, 23);
            cmbDurum.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(430, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 25);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvKayitlar
            // 
            dgvKayitlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKayitlar.Location = new Point(12, 45);
            dgvKayitlar.Name = "dgvKayitlar";
            dgvKayitlar.Size = new Size(876, 420);
            dgvKayitlar.TabIndex = 3;
            dgvKayitlar.CellDoubleClick += dgvKayitlar_CellDoubleClick;
            // 
            // btnYeni
            // 
            btnYeni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnYeni.Location = new Point(12, 475);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(120, 32);
            btnYeni.TabIndex = 4;
            btnYeni.Text = "Yeni kayıt";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnAc
            // 
            btnAc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAc.Location = new Point(138, 475);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(120, 32);
            btnAc.TabIndex = 5;
            btnAc.Text = "Aç / düzenle";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.Location = new Point(264, 475);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 32);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // ServisKayitlariFormu
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Controls.Add(btnSil);
            Controls.Add(btnAc);
            Controls.Add(btnYeni);
            Controls.Add(dgvKayitlar);
            Controls.Add(btnAra);
            Controls.Add(cmbDurum);
            Controls.Add(txtArama);
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
