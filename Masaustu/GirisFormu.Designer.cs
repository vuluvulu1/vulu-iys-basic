namespace Masaustu
{
    partial class GirisFormu
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
            picLogo = new PictureBox();
            lblBaslik = new Label();
            lblAltBaslik = new Label();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Location = new Point(24, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(48, 48);
            picLogo.TabIndex = 0;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabStop = false;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(82, 22);
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "vulu İYS";
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Location = new Point(84, 52);
            lblAltBaslik.ForeColor = SystemColors.GrayText;
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.TabIndex = 2;
            lblAltBaslik.Text = "İşletme yönetim sistemi";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(24, 98);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(124, 95);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(210, 23);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(24, 133);
            lblSifre.Name = "lblSifre";
            lblSifre.TabIndex = 5;
            lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(124, 130);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(210, 23);
            txtSifre.TabIndex = 6;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(124, 174);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(210, 34);
            btnGiris.TabIndex = 7;
            btnGiris.Tag = "ana";
            btnGiris.Text = "Giriş yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // GirisFormu
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 230);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblAltBaslik);
            Controls.Add(lblBaslik);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vulu İYS - Giriş";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblBaslik;
        private Label lblAltBaslik;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnGiris;
    }
}
