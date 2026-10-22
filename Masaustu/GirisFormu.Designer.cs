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
            lblBaslik = new Label();
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "vulu İYS";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(20, 70);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(120, 67);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(190, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(20, 105);
            lblSifre.Name = "lblSifre";
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(120, 102);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(190, 23);
            txtSifre.TabIndex = 4;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(120, 145);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(190, 32);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // GirisFormu
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 200);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vulu İYS - Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private TextBox txtSifre;
        private Button btnGiris;
    }
}
