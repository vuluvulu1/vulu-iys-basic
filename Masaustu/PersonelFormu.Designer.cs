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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvPersonel = new DataGridView();
            btnEkle = new Button();
            btnDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 21, 9);
            dgvPersonel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersonel.BackgroundColor = Color.FromArgb(26, 17, 10);
            dgvPersonel.BorderStyle = BorderStyle.None;
            dgvPersonel.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPersonel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 26, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(184, 154, 124);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersonel.ColumnHeadersHeight = 32;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 17, 10);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.Padding = new Padding(4, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(74, 46, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(243, 230, 214);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPersonel.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonel.EnableHeadersVisualStyles = false;
            dgvPersonel.GridColor = Color.FromArgb(74, 46, 28);
            dgvPersonel.Location = new Point(12, 12);
            dgvPersonel.RowTemplate.Height = 28;
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.Size = new Size(736, 390);
            dgvPersonel.TabIndex = 0;
            dgvPersonel.CellDoubleClick += dgvPersonel_CellDoubleClick;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEkle.BackColor = Color.FromArgb(181, 128, 79);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderColor = Color.FromArgb(181, 128, 79);
            btnEkle.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 198, 153);
            btnEkle.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 198, 153);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.ForeColor = Color.FromArgb(26, 17, 10);
            btnEkle.Location = new Point(12, 415);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 32);
            btnEkle.TabIndex = 1;
            btnEkle.Tag = "ana";
            btnEkle.Text = "Yeni personel";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDuzenle.BackColor = Color.FromArgb(58, 36, 22);
            btnDuzenle.Cursor = Cursors.Hand;
            btnDuzenle.FlatAppearance.BorderColor = Color.FromArgb(58, 36, 22);
            btnDuzenle.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 128, 79);
            btnDuzenle.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 46, 28);
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.ForeColor = Color.FromArgb(243, 230, 214);
            btnDuzenle.Location = new Point(138, 415);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(120, 32);
            btnDuzenle.TabIndex = 2;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // PersonelFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 17, 10);
            ClientSize = new Size(760, 460);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(dgvPersonel);
            ForeColor = Color.FromArgb(243, 230, 214);
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
