namespace Masaustu
{
    partial class MusteriFormu
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
            lblAdSoyad = new Label();
            txtAdSoyad = new TextBox();
            lblTelefon = new Label();
            txtTelefon = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAdres = new Label();
            txtAdres = new TextBox();
            btnKaydet = new Button();
            btnVazgec = new Button();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(20, 23);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Ad soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(110, 20);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(280, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(20, 58);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(110, 55);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(280, 23);
            txtTelefon.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(20, 128);
            lblAdres.Name = "lblAdres";
            lblAdres.TabIndex = 6;
            lblAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(110, 125);
            txtAdres.Multiline = true;
            txtAdres.ScrollBars = ScrollBars.Vertical;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(280, 60);
            txtAdres.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(180, 200);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 32);
            btnKaydet.TabIndex = 8;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.DialogResult = DialogResult.Cancel;
            btnVazgec.Location = new Point(290, 200);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 9;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            // 
            // MusteriFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVazgec;
            ClientSize = new Size(420, 250);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(lblAdres);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefon);
            Controls.Add(lblTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(lblAdSoyad);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusteriFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private TextBox txtAdSoyad;
        private Label lblTelefon;
        private TextBox txtTelefon;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAdres;
        private TextBox txtAdres;
        private Button btnKaydet;
        private Button btnVazgec;
    }
}
