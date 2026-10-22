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
            lblIsletmeAdi = new Label();
            lblAltBaslik = new Label();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            picLogo = new PictureBox();
            lblVulu = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblIsletmeAdi
            // 
            lblIsletmeAdi.AutoEllipsis = true;
            lblIsletmeAdi.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblIsletmeAdi.Location = new Point(24, 18);
            lblIsletmeAdi.Name = "lblIsletmeAdi";
            lblIsletmeAdi.Size = new Size(310, 34);
            lblIsletmeAdi.TabIndex = 0;
            lblIsletmeAdi.Text = "İşletme adı";
            lblIsletmeAdi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.Location = new Point(26, 52);
            lblAltBaslik.ForeColor = Color.FromArgb(184, 154, 124);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.TabIndex = 1;
            lblAltBaslik.Text = "Servis yönetimi";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(24, 98);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.TabIndex = 2;
            lblKullaniciAdi.Text = "Kullanıcı adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(43, 26, 16);
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.ForeColor = Color.FromArgb(243, 230, 214);
            txtKullaniciAdi.Location = new Point(124, 95);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(210, 23);
            txtKullaniciAdi.TabIndex = 3;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(24, 133);
            lblSifre.Name = "lblSifre";
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(43, 26, 16);
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.ForeColor = Color.FromArgb(243, 230, 214);
            txtSifre.Location = new Point(124, 130);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(210, 23);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(181, 128, 79);
            btnGiris.Cursor = Cursors.Hand;
            btnGiris.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnGiris.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnGiris.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.ForeColor = Color.FromArgb(26, 17, 10);
            btnGiris.Location = new Point(124, 174);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(210, 34);
            btnGiris.TabIndex = 6;
            btnGiris.Tag = "ana";
            btnGiris.Text = "Giriş yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(24, 222);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(16, 16);
            picLogo.TabIndex = 7;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabStop = false;
            // 
            // lblVulu
            // 
            lblVulu.AutoSize = true;
            lblVulu.Location = new Point(42, 223);
            lblVulu.Font = new Font("Segoe UI", 8F);
            lblVulu.ForeColor = Color.FromArgb(184, 154, 124);
            lblVulu.Name = "lblVulu";
            lblVulu.TabIndex = 8;
            lblVulu.Text = "vulu İYS";
            // 
            // GirisFormu
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(360, 250);
            Controls.Add(lblVulu);
            Controls.Add(picLogo);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblAltBaslik);
            Controls.Add(lblIsletmeAdi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ForeColor = Color.FromArgb(243, 230, 214);
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIsletmeAdi;
        private Label lblAltBaslik;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnGiris;
        private PictureBox picLogo;
        private Label lblVulu;
    }
}
