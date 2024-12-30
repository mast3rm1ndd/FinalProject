namespace FinalProject
{
    partial class DersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ogrBilgiLabel = new Label();
            derslerLabel = new Label();
            dataGridView1 = new DataGridView();
            btnKaydet = new Button();
            aDersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ogrBilgiLabel
            // 
            ogrBilgiLabel.AutoSize = true;
            ogrBilgiLabel.Location = new Point(66, 21);
            ogrBilgiLabel.Name = "ogrBilgiLabel";
            ogrBilgiLabel.Size = new Size(0, 20);
            ogrBilgiLabel.TabIndex = 0;
            // 
            // derslerLabel
            // 
            derslerLabel.AutoSize = true;
            derslerLabel.Location = new Point(66, 63);
            derslerLabel.Name = "derslerLabel";
            derslerLabel.Size = new Size(56, 20);
            derslerLabel.TabIndex = 1;
            derslerLabel.Text = "Dersler";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 269);
            dataGridView1.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(260, 388);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(278, 40);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // aDersLabel
            // 
            aDersLabel.AutoSize = true;
            aDersLabel.Location = new Point(459, 21);
            aDersLabel.Name = "aDersLabel";
            aDersLabel.Size = new Size(0, 20);
            aDersLabel.TabIndex = 4;
            // 
            // DersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aDersLabel);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(derslerLabel);
            Controls.Add(ogrBilgiLabel);
            Name = "DersForm";
            Text = "Ders Seçim Ekranı";
            Load += DersForm_Load;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ogrBilgiLabel;
        private Label derslerLabel;
        private DataGridView dataGridView1;
        private Button btnKaydet;
        private Label aDersLabel;
    }
}