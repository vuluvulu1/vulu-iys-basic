namespace Masaustu
{
    partial class AnaForm
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
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblMarka = new Label();
            mnuMusteriler = new Label();
            mnuServis = new Label();
            mnuStok = new Label();
            mnuPersonel = new Label();
            mnuRapor = new Label();
            mnuSifre = new Label();
            mnuCikis = new Label();
            lblHosgeldin = new Label();
            lblOzetBasligi = new Label();
            pnlKart1 = new Panel();
            lblKartBaslik1 = new Label();
            lblAcikIs = new Label();
            pnlKart2 = new Panel();
            lblKartBaslik2 = new Label();
            lblTeslimBekleyen = new Label();
            pnlKart3 = new Panel();
            lblKartBaslik3 = new Label();
            lblBugunAcilan = new Label();
            pnlKart4 = new Panel();
            lblKartBaslik4 = new Label();
            lblKritikStok = new Label();
            pnlKart5 = new Panel();
            lblKartBaslik5 = new Label();
            lblOdenmemis = new Label();
            btnYenile = new Button();
            pnlMenu.SuspendLayout();
            pnlKart1.SuspendLayout();
            pnlKart2.SuspendLayout();
            pnlKart3.SuspendLayout();
            pnlKart4.SuspendLayout();
            pnlKart5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblMarka);
            pnlMenu.Controls.Add(mnuMusteriler);
            pnlMenu.Controls.Add(mnuServis);
            pnlMenu.Controls.Add(mnuStok);
            pnlMenu.Controls.Add(mnuPersonel);
            pnlMenu.Controls.Add(mnuRapor);
            pnlMenu.Controls.Add(mnuSifre);
            pnlMenu.Controls.Add(mnuCikis);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 440);
            pnlMenu.TabIndex = 0;
            pnlMenu.Tag = "menu";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(14, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(40, 40);
            picLogo.TabIndex = 1;
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabStop = false;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(60, 25);
            lblMarka.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarka.Name = "lblMarka";
            lblMarka.TabIndex = 2;
            lblMarka.Text = "vulu İYS";
            // 
            // mnuMusteriler
            // 
            mnuMusteriler.Cursor = Cursors.Hand;
            mnuMusteriler.Location = new Point(10, 80);
            mnuMusteriler.Padding = new Padding(10, 0, 0, 0);
            mnuMusteriler.Name = "mnuMusteriler";
            mnuMusteriler.Size = new Size(200, 38);
            mnuMusteriler.TabIndex = 3;
            mnuMusteriler.Tag = "menu";
            mnuMusteriler.Text = "Müşteriler";
            mnuMusteriler.TextAlign = ContentAlignment.MiddleLeft;
            mnuMusteriler.Click += mnuMusteriler_Click;
            // 
            // mnuServis
            // 
            mnuServis.Cursor = Cursors.Hand;
            mnuServis.Location = new Point(10, 122);
            mnuServis.Padding = new Padding(10, 0, 0, 0);
            mnuServis.Name = "mnuServis";
            mnuServis.Size = new Size(200, 38);
            mnuServis.TabIndex = 4;
            mnuServis.Tag = "menu";
            mnuServis.Text = "Servis kayıtları";
            mnuServis.TextAlign = ContentAlignment.MiddleLeft;
            mnuServis.Click += mnuServis_Click;
            // 
            // mnuStok
            // 
            mnuStok.Cursor = Cursors.Hand;
            mnuStok.Location = new Point(10, 164);
            mnuStok.Padding = new Padding(10, 0, 0, 0);
            mnuStok.Name = "mnuStok";
            mnuStok.Size = new Size(200, 38);
            mnuStok.TabIndex = 5;
            mnuStok.Tag = "menu";
            mnuStok.Text = "Stok";
            mnuStok.TextAlign = ContentAlignment.MiddleLeft;
            mnuStok.Click += mnuStok_Click;
            // 
            // mnuPersonel
            // 
            mnuPersonel.Cursor = Cursors.Hand;
            mnuPersonel.Location = new Point(10, 206);
            mnuPersonel.Padding = new Padding(10, 0, 0, 0);
            mnuPersonel.Name = "mnuPersonel";
            mnuPersonel.Size = new Size(200, 38);
            mnuPersonel.TabIndex = 6;
            mnuPersonel.Tag = "menu";
            mnuPersonel.Text = "Personel";
            mnuPersonel.TextAlign = ContentAlignment.MiddleLeft;
            mnuPersonel.Click += mnuPersonel_Click;
            // 
            // mnuRapor
            // 
            mnuRapor.Cursor = Cursors.Hand;
            mnuRapor.Location = new Point(10, 248);
            mnuRapor.Padding = new Padding(10, 0, 0, 0);
            mnuRapor.Name = "mnuRapor";
            mnuRapor.Size = new Size(200, 38);
            mnuRapor.TabIndex = 7;
            mnuRapor.Tag = "menu";
            mnuRapor.Text = "Raporlar";
            mnuRapor.TextAlign = ContentAlignment.MiddleLeft;
            mnuRapor.Click += mnuRapor_Click;
            // 
            // mnuSifre
            // 
            mnuSifre.Cursor = Cursors.Hand;
            mnuSifre.Location = new Point(10, 336);
            mnuSifre.Padding = new Padding(10, 0, 0, 0);
            mnuSifre.Name = "mnuSifre";
            mnuSifre.Size = new Size(200, 38);
            mnuSifre.TabIndex = 8;
            mnuSifre.Tag = "menu";
            mnuSifre.Text = "Şifre değiştir";
            mnuSifre.TextAlign = ContentAlignment.MiddleLeft;
            mnuSifre.Click += mnuSifre_Click;
            // 
            // mnuCikis
            // 
            mnuCikis.Cursor = Cursors.Hand;
            mnuCikis.Location = new Point(10, 378);
            mnuCikis.Padding = new Padding(10, 0, 0, 0);
            mnuCikis.Name = "mnuCikis";
            mnuCikis.Size = new Size(200, 38);
            mnuCikis.TabIndex = 9;
            mnuCikis.Tag = "menu";
            mnuCikis.Text = "Çıkış yap";
            mnuCikis.TextAlign = ContentAlignment.MiddleLeft;
            mnuCikis.Click += mnuCikis_Click;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Location = new Point(248, 26);
            lblHosgeldin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.TabIndex = 10;
            lblHosgeldin.Text = "Hoş geldin";
            // 
            // lblOzetBasligi
            // 
            lblOzetBasligi.AutoSize = true;
            lblOzetBasligi.Location = new Point(250, 56);
            lblOzetBasligi.ForeColor = SystemColors.GrayText;
            lblOzetBasligi.Name = "lblOzetBasligi";
            lblOzetBasligi.TabIndex = 11;
            lblOzetBasligi.Text = "Bugünün özeti";
            // 
            // pnlKart1
            // 
            pnlKart1.Controls.Add(lblKartBaslik1);
            pnlKart1.Controls.Add(lblAcikIs);
            pnlKart1.Location = new Point(250, 84);
            pnlKart1.Name = "pnlKart1";
            pnlKart1.Size = new Size(150, 84);
            pnlKart1.TabIndex = 12;
            pnlKart1.Tag = "kart";
            // 
            // lblKartBaslik1
            // 
            lblKartBaslik1.AutoSize = true;
            lblKartBaslik1.Location = new Point(12, 10);
            lblKartBaslik1.ForeColor = SystemColors.GrayText;
            lblKartBaslik1.Name = "lblKartBaslik1";
            lblKartBaslik1.TabIndex = 13;
            lblKartBaslik1.Text = "Açık iş";
            // 
            // lblAcikIs
            // 
            lblAcikIs.AutoSize = true;
            lblAcikIs.Location = new Point(10, 34);
            lblAcikIs.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAcikIs.Name = "lblAcikIs";
            lblAcikIs.TabIndex = 14;
            lblAcikIs.Text = "-";
            // 
            // pnlKart2
            // 
            pnlKart2.Controls.Add(lblKartBaslik2);
            pnlKart2.Controls.Add(lblTeslimBekleyen);
            pnlKart2.Location = new Point(412, 84);
            pnlKart2.Name = "pnlKart2";
            pnlKart2.Size = new Size(150, 84);
            pnlKart2.TabIndex = 15;
            pnlKart2.Tag = "kart";
            // 
            // lblKartBaslik2
            // 
            lblKartBaslik2.AutoSize = true;
            lblKartBaslik2.Location = new Point(12, 10);
            lblKartBaslik2.ForeColor = SystemColors.GrayText;
            lblKartBaslik2.Name = "lblKartBaslik2";
            lblKartBaslik2.TabIndex = 16;
            lblKartBaslik2.Text = "Teslim bekleyen";
            // 
            // lblTeslimBekleyen
            // 
            lblTeslimBekleyen.AutoSize = true;
            lblTeslimBekleyen.Location = new Point(10, 34);
            lblTeslimBekleyen.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTeslimBekleyen.Name = "lblTeslimBekleyen";
            lblTeslimBekleyen.TabIndex = 17;
            lblTeslimBekleyen.Text = "-";
            // 
            // pnlKart3
            // 
            pnlKart3.Controls.Add(lblKartBaslik3);
            pnlKart3.Controls.Add(lblBugunAcilan);
            pnlKart3.Location = new Point(574, 84);
            pnlKart3.Name = "pnlKart3";
            pnlKart3.Size = new Size(150, 84);
            pnlKart3.TabIndex = 18;
            pnlKart3.Tag = "kart";
            // 
            // lblKartBaslik3
            // 
            lblKartBaslik3.AutoSize = true;
            lblKartBaslik3.Location = new Point(12, 10);
            lblKartBaslik3.ForeColor = SystemColors.GrayText;
            lblKartBaslik3.Name = "lblKartBaslik3";
            lblKartBaslik3.TabIndex = 19;
            lblKartBaslik3.Text = "Bugün açılan";
            // 
            // lblBugunAcilan
            // 
            lblBugunAcilan.AutoSize = true;
            lblBugunAcilan.Location = new Point(10, 34);
            lblBugunAcilan.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBugunAcilan.Name = "lblBugunAcilan";
            lblBugunAcilan.TabIndex = 20;
            lblBugunAcilan.Text = "-";
            // 
            // pnlKart4
            // 
            pnlKart4.Controls.Add(lblKartBaslik4);
            pnlKart4.Controls.Add(lblKritikStok);
            pnlKart4.Location = new Point(250, 180);
            pnlKart4.Name = "pnlKart4";
            pnlKart4.Size = new Size(150, 84);
            pnlKart4.TabIndex = 21;
            pnlKart4.Tag = "kart";
            // 
            // lblKartBaslik4
            // 
            lblKartBaslik4.AutoSize = true;
            lblKartBaslik4.Location = new Point(12, 10);
            lblKartBaslik4.ForeColor = SystemColors.GrayText;
            lblKartBaslik4.Name = "lblKartBaslik4";
            lblKartBaslik4.TabIndex = 22;
            lblKartBaslik4.Text = "Kritik stoktaki parça";
            // 
            // lblKritikStok
            // 
            lblKritikStok.AutoSize = true;
            lblKritikStok.Location = new Point(10, 34);
            lblKritikStok.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.TabIndex = 23;
            lblKritikStok.Text = "-";
            // 
            // pnlKart5
            // 
            pnlKart5.Controls.Add(lblKartBaslik5);
            pnlKart5.Controls.Add(lblOdenmemis);
            pnlKart5.Location = new Point(412, 180);
            pnlKart5.Name = "pnlKart5";
            pnlKart5.Size = new Size(312, 84);
            pnlKart5.TabIndex = 24;
            pnlKart5.Tag = "kart";
            // 
            // lblKartBaslik5
            // 
            lblKartBaslik5.AutoSize = true;
            lblKartBaslik5.Location = new Point(12, 10);
            lblKartBaslik5.ForeColor = SystemColors.GrayText;
            lblKartBaslik5.Name = "lblKartBaslik5";
            lblKartBaslik5.TabIndex = 25;
            lblKartBaslik5.Text = "Ödenmemiş tutar (teslim edilenler)";
            // 
            // lblOdenmemis
            // 
            lblOdenmemis.AutoSize = true;
            lblOdenmemis.Location = new Point(10, 34);
            lblOdenmemis.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblOdenmemis.Name = "lblOdenmemis";
            lblOdenmemis.TabIndex = 26;
            lblOdenmemis.Text = "-";
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(250, 282);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(100, 30);
            btnYenile.TabIndex = 27;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 440);
            Controls.Add(btnYenile);
            Controls.Add(pnlKart5);
            Controls.Add(pnlKart4);
            Controls.Add(pnlKart3);
            Controls.Add(pnlKart2);
            Controls.Add(pnlKart1);
            Controls.Add(lblOzetBasligi);
            Controls.Add(lblHosgeldin);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vulu İYS";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlKart1.ResumeLayout(false);
            pnlKart1.PerformLayout();
            pnlKart2.ResumeLayout(false);
            pnlKart2.PerformLayout();
            pnlKart3.ResumeLayout(false);
            pnlKart3.PerformLayout();
            pnlKart4.ResumeLayout(false);
            pnlKart4.PerformLayout();
            pnlKart5.ResumeLayout(false);
            pnlKart5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private PictureBox picLogo;
        private Label lblMarka;
        private Label mnuMusteriler;
        private Label mnuServis;
        private Label mnuStok;
        private Label mnuPersonel;
        private Label mnuRapor;
        private Label mnuSifre;
        private Label mnuCikis;
        private Label lblHosgeldin;
        private Label lblOzetBasligi;
        private Panel pnlKart1;
        private Label lblKartBaslik1;
        private Label lblAcikIs;
        private Panel pnlKart2;
        private Label lblKartBaslik2;
        private Label lblTeslimBekleyen;
        private Panel pnlKart3;
        private Label lblKartBaslik3;
        private Label lblBugunAcilan;
        private Panel pnlKart4;
        private Label lblKartBaslik4;
        private Label lblKritikStok;
        private Panel pnlKart5;
        private Label lblKartBaslik5;
        private Label lblOdenmemis;
        private Button btnYenile;
    }
}
