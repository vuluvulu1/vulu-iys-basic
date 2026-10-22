namespace Masaustu
{
    partial class PersonelFormu
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
            dgvPersonel = new DataGridView();
            btnEkle = new Button();
            btnDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonel.Location = new Point(12, 12);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.Size = new Size(736, 390);
            dgvPersonel.TabIndex = 0;
            dgvPersonel.CellDoubleClick += dgvPersonel_CellDoubleClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.Location = new Point(12, 415);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 32);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Yeni personel";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDuzenle.Location = new Point(138, 415);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(120, 32);
            btnDuzenle.TabIndex = 2;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // PersonelFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 460);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(dgvPersonel);
            MinimumSize = new Size(500, 300);
            Name = "PersonelFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonel;
        private Button btnEkle;
        private Button btnDuzenle;
    }
}
