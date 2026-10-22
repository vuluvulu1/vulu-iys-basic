namespace Paketleyici
{
    partial class PaketleyiciFormu
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
            lblAciklama = new Label();
            lblApiAdresi = new Label();
            txtApiAdresi = new TextBox();
            btnHazirla = new Button();
            lblDurum = new Label();
            SuspendLayout();
            //
            // lblBaslik
            //
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBaslik.Location = new Point(20, 16);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "İşletmeye özel paket";
            //
            // lblAciklama
            //
            lblAciklama.AutoSize = true;
            lblAciklama.ForeColor = Color.FromArgb(184, 154, 124);
            lblAciklama.Location = new Point(22, 46);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Program işletmenin API'sine bağlanıp tek exe olarak Dagitim'e konur.";
            //
            // lblApiAdresi
            //
            lblApiAdresi.AutoSize = true;
            lblApiAdresi.Location = new Point(20, 86);
            lblApiAdresi.Name = "lblApiAdresi";
            lblApiAdresi.TabIndex = 2;
            lblApiAdresi.Text = "API adresi";
            //
            // txtApiAdresi
            //
            txtApiAdresi.BackColor = Color.FromArgb(43, 26, 16);
            txtApiAdresi.BorderStyle = BorderStyle.FixedSingle;
            txtApiAdresi.ForeColor = Color.FromArgb(243, 230, 214);
            txtApiAdresi.Location = new Point(110, 83);
            txtApiAdresi.Name = "txtApiAdresi";
            txtApiAdresi.PlaceholderText = "https://isletme-adi.onrender.com";
            txtApiAdresi.Size = new Size(290, 23);
            txtApiAdresi.TabIndex = 3;
            //
            // btnHazirla
            //
            btnHazirla.BackColor = Color.FromArgb(181, 128, 79);
            btnHazirla.Cursor = Cursors.Hand;
            btnHazirla.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnHazirla.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnHazirla.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnHazirla.FlatStyle = FlatStyle.Flat;
            btnHazirla.ForeColor = Color.FromArgb(26, 17, 10);
            btnHazirla.Location = new Point(110, 120);
            btnHazirla.Name = "btnHazirla";
            btnHazirla.Size = new Size(290, 34);
            btnHazirla.TabIndex = 4;
            btnHazirla.Text = "Paketi hazırla";
            btnHazirla.UseVisualStyleBackColor = false;
            btnHazirla.Click += btnHazirla_Click;
            //
            // lblDurum
            //
            lblDurum.ForeColor = Color.FromArgb(184, 154, 124);
            lblDurum.Location = new Point(20, 168);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(380, 40);
            lblDurum.TabIndex = 5;
            //
            // PaketleyiciFormu
            //
            AcceptButton = btnHazirla;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(420, 220);
            Controls.Add(lblDurum);
            Controls.Add(btnHazirla);
            Controls.Add(txtApiAdresi);
            Controls.Add(lblApiAdresi);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            ForeColor = Color.FromArgb(243, 230, 214);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PaketleyiciFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vulu İYS - Paketleyici";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private Label lblApiAdresi;
        private TextBox txtApiAdresi;
        private Button btnHazirla;
        private Label lblDurum;
    }
}
