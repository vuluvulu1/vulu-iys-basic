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
            txtTekrar.Location = new Point(150, 90);
            txtTekrar.Name = "txtTekrar";
            txtTekrar.Size = new Size(200, 23);
            txtTekrar.TabIndex = 5;
            txtTekrar.UseSystemPasswordChar = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(140, 140);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 32);
            btnKaydet.TabIndex = 6;
            btnKaydet.Tag = "ana";
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.DialogResult = DialogResult.Cancel;
            btnVazgec.Location = new Point(250, 140);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 7;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            // 
            // SifreDegistirFormu
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnVazgec;
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
