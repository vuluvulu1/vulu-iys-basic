namespace Masaustu
{
    partial class RaporFormu
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
            lblBaslangic = new Label();
            dtpBaslangic = new DateTimePicker();
            lblBitis = new Label();
            dtpBitis = new DateTimePicker();
            btnGoster = new Button();
            grpGenel = new GroupBox();
            lblAcilan = new Label();
            lblTamamlanan = new Label();
            lblIptal = new Label();
            lblToplamTutar = new Label();
            lblTahsil = new Label();
            lblKalan = new Label();
            lblTeknisyenler = new Label();
            dgvTeknisyenler = new DataGridView();
            lblParcalar = new Label();
            dgvParcalar = new DataGridView();
            grpGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeknisyenler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(20, 18);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.TabIndex = 0;
            lblBaslangic.Text = "Başlangıç";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Format = DateTimePickerFormat.Short;
            dtpBaslangic.Location = new Point(100, 15);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(130, 23);
            dtpBaslangic.TabIndex = 1;
            // 
            // lblBitis
            // 
            lblBitis.AutoSize = true;
            lblBitis.Location = new Point(260, 18);
            lblBitis.Name = "lblBitis";
            lblBitis.TabIndex = 2;
            lblBitis.Text = "Bitiş";
            // 
            // dtpBitis
            // 
            dtpBitis.Format = DateTimePickerFormat.Short;
            dtpBitis.Location = new Point(300, 15);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(130, 23);
            dtpBitis.TabIndex = 3;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(480, 14);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(120, 25);
            btnGoster.TabIndex = 4;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // grpGenel
            // 
            grpGenel.Controls.Add(lblAcilan);
            grpGenel.Controls.Add(lblTamamlanan);
            grpGenel.Controls.Add(lblIptal);
            grpGenel.Controls.Add(lblToplamTutar);
            grpGenel.Controls.Add(lblTahsil);
            grpGenel.Controls.Add(lblKalan);
            grpGenel.Location = new Point(20, 55);
            grpGenel.Name = "grpGenel";
            grpGenel.Size = new Size(600, 110);
            grpGenel.TabIndex = 5;
            grpGenel.Text = "Genel";
            // 
            // lblAcilan
            // 
            lblAcilan.AutoSize = true;
            lblAcilan.Location = new Point(15, 25);
            lblAcilan.Name = "lblAcilan";
            lblAcilan.TabIndex = 6;
            lblAcilan.Text = "Açılan iş: -";
            // 
            // lblTamamlanan
            // 
            lblTamamlanan.AutoSize = true;
            lblTamamlanan.Location = new Point(15, 50);
            lblTamamlanan.Name = "lblTamamlanan";
            lblTamamlanan.TabIndex = 7;
            lblTamamlanan.Text = "Tamamlanan iş: -";
            // 
            // lblIptal
            // 
            lblIptal.AutoSize = true;
            lblIptal.Location = new Point(15, 75);
            lblIptal.Name = "lblIptal";
            lblIptal.TabIndex = 8;
            lblIptal.Text = "İptal edilen iş: -";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(300, 25);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.TabIndex = 9;
            lblToplamTutar.Text = "Toplam tutar: -";
            // 
            // lblTahsil
            // 
            lblTahsil.AutoSize = true;
            lblTahsil.Location = new Point(300, 50);
            lblTahsil.Name = "lblTahsil";
            lblTahsil.TabIndex = 10;
            lblTahsil.Text = "Tahsil edilen: -";
            // 
            // lblKalan
            // 
            lblKalan.AutoSize = true;
            lblKalan.Location = new Point(300, 75);
            lblKalan.Name = "lblKalan";
            lblKalan.TabIndex = 11;
            lblKalan.Text = "Tahsil edilmeyen: -";
            // 
            // lblTeknisyenler
            // 
            lblTeknisyenler.AutoSize = true;
            lblTeknisyenler.Location = new Point(20, 178);
            lblTeknisyenler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTeknisyenler.Name = "lblTeknisyenler";
            lblTeknisyenler.TabIndex = 12;
            lblTeknisyenler.Text = "Teknisyenler";
            // 
            // dgvTeknisyenler
            // 
            dgvTeknisyenler.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTeknisyenler.Location = new Point(20, 198);
            dgvTeknisyenler.Name = "dgvTeknisyenler";
            dgvTeknisyenler.Size = new Size(600, 130);
            dgvTeknisyenler.TabIndex = 13;
            // 
            // lblParcalar
            // 
            lblParcalar.AutoSize = true;
            lblParcalar.Location = new Point(20, 343);
            lblParcalar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParcalar.Name = "lblParcalar";
            lblParcalar.TabIndex = 14;
            lblParcalar.Text = "En çok kullanılan parçalar";
            // 
            // dgvParcalar
            // 
            dgvParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvParcalar.Location = new Point(20, 363);
            dgvParcalar.Name = "dgvParcalar";
            dgvParcalar.Size = new Size(600, 140);
            dgvParcalar.TabIndex = 15;
            // 
            // RaporFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 520);
            Controls.Add(dgvParcalar);
            Controls.Add(lblParcalar);
            Controls.Add(dgvTeknisyenler);
            Controls.Add(lblTeknisyenler);
            Controls.Add(grpGenel);
            Controls.Add(btnGoster);
            Controls.Add(dtpBitis);
            Controls.Add(lblBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(lblBaslangic);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RaporFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Raporlar";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeknisyenler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcalar).EndInit();
            grpGenel.ResumeLayout(false);
            grpGenel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslangic;
        private DateTimePicker dtpBaslangic;
        private Label lblBitis;
        private DateTimePicker dtpBitis;
        private Button btnGoster;
        private GroupBox grpGenel;
        private Label lblAcilan;
        private Label lblTamamlanan;
        private Label lblIptal;
        private Label lblToplamTutar;
        private Label lblTahsil;
        private Label lblKalan;
        private Label lblTeknisyenler;
        private DataGridView dgvTeknisyenler;
        private Label lblParcalar;
        private DataGridView dgvParcalar;
    }
}
