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
            btnMusteriler = new Button();
            btnServis = new Button();
            btnStok = new Button();
            btnPersonel = new Button();
            btnRapor = new Button();
            btnSifre = new Button();
            btnCikis = new Button();
            lblHosgeldin = new Label();
            grpOzet = new GroupBox();
            lblAcikIs = new Label();
            lblTeslimBekleyen = new Label();
            lblBugunAcilan = new Label();
            lblKritikStok = new Label();
            lblOdenmemis = new Label();
            btnYenile = new Button();
            grpOzet.SuspendLayout();
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(20, 20);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(180, 40);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // btnServis
            // 
            btnServis.Location = new Point(20, 70);
            btnServis.Name = "btnServis";
            btnServis.Size = new Size(180, 40);
            btnServis.TabIndex = 1;
            btnServis.Text = "Servis kayıtları";
            btnServis.UseVisualStyleBackColor = true;
            btnServis.Click += btnServis_Click;
            // 
            // btnStok
            // 
            btnStok.Location = new Point(20, 120);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(180, 40);
            btnStok.TabIndex = 2;
            btnStok.Text = "Stok";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnPersonel
            // 
            btnPersonel.Location = new Point(20, 170);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(180, 40);
            btnPersonel.TabIndex = 3;
            btnPersonel.Text = "Personel";
            btnPersonel.UseVisualStyleBackColor = true;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(20, 220);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(180, 40);
            btnRapor.TabIndex = 4;
            btnRapor.Text = "Raporlar";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnSifre
            // 
            btnSifre.Location = new Point(20, 290);
            btnSifre.Name = "btnSifre";
            btnSifre.Size = new Size(180, 40);
            btnSifre.TabIndex = 5;
            btnSifre.Text = "Şifre değiştir";
            btnSifre.UseVisualStyleBackColor = true;
            btnSifre.Click += btnSifre_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(20, 340);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(180, 40);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Location = new Point(230, 20);
            lblHosgeldin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.TabIndex = 7;
            lblHosgeldin.Text = "Hoş geldin";
            // 
            // grpOzet
            // 
            grpOzet.Controls.Add(lblAcikIs);
            grpOzet.Controls.Add(lblTeslimBekleyen);
            grpOzet.Controls.Add(lblBugunAcilan);
            grpOzet.Controls.Add(lblKritikStok);
            grpOzet.Controls.Add(lblOdenmemis);
            grpOzet.Location = new Point(230, 60);
            grpOzet.Name = "grpOzet";
            grpOzet.Size = new Size(380, 230);
            grpOzet.TabIndex = 8;
            grpOzet.Text = "Özet";
            // 
            // lblAcikIs
            // 
            lblAcikIs.AutoSize = true;
            lblAcikIs.Location = new Point(20, 35);
            lblAcikIs.Font = new Font("Segoe UI", 11F);
            lblAcikIs.Name = "lblAcikIs";
            lblAcikIs.TabIndex = 9;
            lblAcikIs.Text = "Açık iş: -";
            // 
            // lblTeslimBekleyen
            // 
            lblTeslimBekleyen.AutoSize = true;
            lblTeslimBekleyen.Location = new Point(20, 70);
            lblTeslimBekleyen.Font = new Font("Segoe UI", 11F);
            lblTeslimBekleyen.Name = "lblTeslimBekleyen";
            lblTeslimBekleyen.TabIndex = 10;
            lblTeslimBekleyen.Text = "Teslim bekleyen: -";
            // 
            // lblBugunAcilan
            // 
            lblBugunAcilan.AutoSize = true;
            lblBugunAcilan.Location = new Point(20, 105);
            lblBugunAcilan.Font = new Font("Segoe UI", 11F);
            lblBugunAcilan.Name = "lblBugunAcilan";
            lblBugunAcilan.TabIndex = 11;
            lblBugunAcilan.Text = "Bugün açılan: -";
            // 
            // lblKritikStok
            // 
            lblKritikStok.AutoSize = true;
            lblKritikStok.Location = new Point(20, 140);
            lblKritikStok.Font = new Font("Segoe UI", 11F);
            lblKritikStok.Name = "lblKritikStok";
            lblKritikStok.TabIndex = 12;
            lblKritikStok.Text = "Kritik stoktaki parça: -";
            // 
            // lblOdenmemis
            // 
            lblOdenmemis.AutoSize = true;
            lblOdenmemis.Location = new Point(20, 175);
            lblOdenmemis.Font = new Font("Segoe UI", 11F);
            lblOdenmemis.Name = "lblOdenmemis";
            lblOdenmemis.TabIndex = 13;
            lblOdenmemis.Text = "Ödenmemiş tutar: -";
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(230, 300);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(100, 30);
            btnYenile.TabIndex = 14;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 400);
            Controls.Add(btnYenile);
            Controls.Add(grpOzet);
            Controls.Add(lblHosgeldin);
            Controls.Add(btnCikis);
            Controls.Add(btnSifre);
            Controls.Add(btnRapor);
            Controls.Add(btnPersonel);
            Controls.Add(btnStok);
            Controls.Add(btnServis);
            Controls.Add(btnMusteriler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vulu İYS";
            Load += Form_Load;
            grpOzet.ResumeLayout(false);
            grpOzet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMusteriler;
        private Button btnServis;
        private Button btnStok;
        private Button btnPersonel;
        private Button btnRapor;
        private Button btnSifre;
        private Button btnCikis;
        private Label lblHosgeldin;
        private GroupBox grpOzet;
        private Label lblAcikIs;
        private Label lblTeslimBekleyen;
        private Label lblBugunAcilan;
        private Label lblKritikStok;
        private Label lblOdenmemis;
        private Button btnYenile;
    }
}
