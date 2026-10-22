namespace Masaustu
{
    partial class PersonelDuzenleFormu
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
            lblKullaniciAdi = new Label();
            txtKullaniciAdi = new TextBox();
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            chkStokYetkisi = new CheckBox();
            chkAktif = new CheckBox();
            lblSifre = new Label();
            txtSifre = new TextBox();
            lblSifreNotu = new Label();
            btnKaydet = new Button();
            btnVazgec = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(20, 23);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(120, 20);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(270, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(20, 58);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.TabIndex = 2;
            lblAdSoyad.Text = "Ad soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(120, 55);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(270, 23);
            txtAdSoyad.TabIndex = 3;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(20, 93);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.TabIndex = 4;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(120, 90);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(270, 23);
            txtTelefon.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(20, 128);
            lblRol.Name = "lblRol";
            lblRol.TabIndex = 6;
            lblRol.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Location = new Point(120, 125);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(150, 23);
            cmbRol.TabIndex = 7;
            // 
            // chkStokYetkisi
            // 
            chkStokYetkisi.AutoSize = true;
            chkStokYetkisi.Location = new Point(120, 160);
            chkStokYetkisi.Name = "chkStokYetkisi";
            chkStokYetkisi.TabIndex = 8;
            chkStokYetkisi.Text = "Stok yetkisi (stok kartlarını düzenleyebilir)";
            chkStokYetkisi.UseVisualStyleBackColor = true;
            // 
            // chkAktif
            // 
            chkAktif.AutoSize = true;
            chkAktif.Location = new Point(120, 190);
            chkAktif.Name = "chkAktif";
            chkAktif.TabIndex = 9;
            chkAktif.Text = "Aktif (pasif hesap giriş yapamaz)";
            chkAktif.UseVisualStyleBackColor = true;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(20, 228);
            lblSifre.Name = "lblSifre";
            lblSifre.TabIndex = 10;
            lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(120, 225);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(270, 23);
            txtSifre.TabIndex = 11;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblSifreNotu
            // 
            lblSifreNotu.AutoSize = true;
            lblSifreNotu.Location = new Point(120, 252);
            lblSifreNotu.ForeColor = SystemColors.GrayText;
            lblSifreNotu.Name = "lblSifreNotu";
            lblSifreNotu.TabIndex = 12;
            lblSifreNotu.Text = "En az 8 karakter.";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(180, 285);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 32);
            btnKaydet.TabIndex = 13;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.DialogResult = DialogResult.Cancel;
            btnVazgec.Location = new Point(290, 285);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 14;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            // 
            // PersonelDuzenleFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVazgec;
            ClientSize = new Size(420, 330);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(lblSifreNotu);
            Controls.Add(txtSifre);
            Controls.Add(lblSifre);
            Controls.Add(chkAktif);
            Controls.Add(chkStokYetkisi);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblKullaniciAdi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonelDuzenleFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblRol;
        private ComboBox cmbRol;
        private CheckBox chkStokYetkisi;
        private CheckBox chkAktif;
        private Label lblSifre;
        private TextBox txtSifre;
        private Label lblSifreNotu;
        private Button btnKaydet;
        private Button btnVazgec;
    }
}
