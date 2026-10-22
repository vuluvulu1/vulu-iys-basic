namespace Masaustu
{
    partial class MusterilerFormu
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
            txtArama = new TextBox();
            btnAra = new Button();
            dgvMusteriler = new DataGridView();
            btnEkle = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.Location = new Point(12, 12);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(300, 23);
            txtArama.TabIndex = 0;
            txtArama.PlaceholderText = "Ad soyad ya da telefon";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(320, 11);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(80, 25);
            btnAra.TabIndex = 1;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMusteriler.Location = new Point(12, 45);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(736, 380);
            dgvMusteriler.TabIndex = 2;
            dgvMusteriler.CellDoubleClick += dgvMusteriler_CellDoubleClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.Location = new Point(12, 435);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 32);
            btnEkle.TabIndex = 3;
            btnEkle.Tag = "ana";
            btnEkle.Text = "Yeni müşteri";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDuzenle.Location = new Point(128, 435);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(110, 32);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSil.Location = new Point(244, 435);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 32);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // MusterilerFormu
            // 
            AcceptButton = btnAra;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 480);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(dgvMusteriler);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            MinimumSize = new Size(500, 300);
            Name = "MusterilerFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteriler";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtArama;
        private Button btnAra;
        private DataGridView dgvMusteriler;
        private Button btnEkle;
        private Button btnDuzenle;
        private Button btnSil;
    }
}
