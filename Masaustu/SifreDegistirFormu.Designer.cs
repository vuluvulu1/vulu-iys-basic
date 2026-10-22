namespace Masaustu
{
    partial class SifreDegistirFormu
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
            lblEski = new Label();
            txtEski = new TextBox();
            lblYeni = new Label();
            txtYeni = new TextBox();
            lblTekrar = new Label();
            txtTekrar = new TextBox();
            btnKaydet = new Button();
            btnVazgec = new Button();
            SuspendLayout();
            // 
            // lblEski
            // 
            lblEski.AutoSize = true;
            lblEski.Location = new Point(20, 23);
            lblEski.Name = "lblEski";
            lblEski.TabIndex = 0;
            lblEski.Text = "Eski şifre";
            // 
            // txtEski
            // 
            txtEski.BackColor = Color.FromArgb(43, 26, 16);
            txtEski.BorderStyle = BorderStyle.FixedSingle;
            txtEski.ForeColor = Color.FromArgb(243, 230, 214);
            txtEski.Location = new Point(150, 20);
            txtEski.Name = "txtEski";
            txtEski.Size = new Size(200, 23);
            txtEski.TabIndex = 1;
            txtEski.UseSystemPasswordChar = true;
            // 
            // lblYeni
            // 
            lblYeni.AutoSize = true;
            lblYeni.Location = new Point(20, 58);
            lblYeni.Name = "lblYeni";
            lblYeni.TabIndex = 2;
            lblYeni.Text = "Yeni şifre";
            // 
            // txtYeni
            // 
            txtYeni.BackColor = Color.FromArgb(43, 26, 16);
            txtYeni.BorderStyle = BorderStyle.FixedSingle;
            txtYeni.ForeColor = Color.FromArgb(243, 230, 214);
            txtYeni.Location = new Point(150, 55);
            txtYeni.Name = "txtYeni";
            txtYeni.Size = new Size(200, 23);
            txtYeni.TabIndex = 3;
            txtYeni.UseSystemPasswordChar = true;
            // 
            // lblTekrar
            // 
            lblTekrar.AutoSize = true;
            lblTekrar.Location = new Point(20, 93);
            lblTekrar.Name = "lblTekrar";
            lblTekrar.TabIndex = 4;
            lblTekrar.Text = "Yeni şifre (tekrar)";
            // 
            // txtTekrar
            // 
            txtTekrar.BackColor = Color.FromArgb(43, 26, 16);
            txtTekrar.BorderStyle = BorderStyle.FixedSingle;
            txtTekrar.ForeColor = Color.FromArgb(243, 230, 214);
            txtTekrar.Location = new Point(150, 90);
            txtTekrar.Name = "txtTekrar";
            txtTekrar.Size = new Size(200, 23);
            txtTekrar.TabIndex = 5;
            txtTekrar.UseSystemPasswordChar = true;
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
            btnKaydet.Location = new Point(140, 140);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 32);
            btnKaydet.TabIndex = 6;
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
            btnVazgec.Location = new Point(250, 140);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 7;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = false;
            // 
            // SifreDegistirFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVazgec;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(380, 190);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(txtTekrar);
            Controls.Add(lblTekrar);
            Controls.Add(txtYeni);
            Controls.Add(lblYeni);
            Controls.Add(txtEski);
            Controls.Add(lblEski);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ForeColor = Color.FromArgb(243, 230, 214);
            Name = "SifreDegistirFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şifre değiştir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEski;
        private TextBox txtEski;
        private Label lblYeni;
        private TextBox txtYeni;
        private Label lblTekrar;
        private TextBox txtTekrar;
        private Button btnKaydet;
        private Button btnVazgec;
    }
}
