namespace FinalProject
{
    partial class Form1
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
            adLabel = new Label();
            soyadLabel = new Label();
            numaraLabel = new Label();
            sinifsecLabel = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            sinifsecCombo = new ComboBox();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnBul = new Button();
            btnDersSecim = new Button();
            SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Location = new Point(226, 64);
            adLabel.Name = "adLabel";
            adLabel.Size = new Size(28, 20);
            adLabel.TabIndex = 0;
            adLabel.Text = "Ad";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.Location = new Point(204, 113);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new Size(50, 20);
            soyadLabel.TabIndex = 1;
            soyadLabel.Text = "Soyad";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.Location = new Point(192, 163);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new Size(62, 20);
            numaraLabel.TabIndex = 2;
            numaraLabel.Text = "Numara";
            // 
            // sinifsecLabel
            // 
            sinifsecLabel.AutoSize = true;
            sinifsecLabel.Location = new Point(166, 215);
            sinifsecLabel.Name = "sinifsecLabel";
            sinifsecLabel.Size = new Size(88, 20);
            sinifsecLabel.TabIndex = 3;
            sinifsecLabel.Text = "Sınıf Seçiniz";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(312, 61);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(159, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(312, 110);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(159, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(312, 160);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(159, 27);
            txtNumara.TabIndex = 6;
            // 
            // sinifsecCombo
            // 
            sinifsecCombo.FormattingEnabled = true;
            sinifsecCombo.Location = new Point(312, 212);
            sinifsecCombo.Name = "sinifsecCombo";
            sinifsecCombo.Size = new Size(159, 28);
            sinifsecCombo.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(330, 296);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(132, 34);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(192, 296);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 34);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(468, 296);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(132, 34);
            btnBul.TabIndex = 10;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSecim
            // 
            btnDersSecim.Location = new Point(330, 371);
            btnDersSecim.Name = "btnDersSecim";
            btnDersSecim.Size = new Size(132, 34);
            btnDersSecim.TabIndex = 11;
            btnDersSecim.Text = "Ders Seçimi";
            btnDersSecim.UseVisualStyleBackColor = true;
            btnDersSecim.Click += btnDersSecim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDersSecim);
            Controls.Add(btnBul);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(sinifsecCombo);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(sinifsecLabel);
            Controls.Add(numaraLabel);
            Controls.Add(soyadLabel);
            Controls.Add(adLabel);
            Name = "Form1";
            Text = "Öğrenci CRUD Ekranı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adLabel;
        private Label soyadLabel;
        private Label numaraLabel;
        private Label sinifsecLabel;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private ComboBox sinifsecCombo;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnBul;
        private Button btnDersSecim;
    }
}
