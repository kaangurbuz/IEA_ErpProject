namespace IEA_ErpProject.BilgiGiris.Urunler
{
    partial class UrunKayit
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
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scUrunKayit = new System.Windows.Forms.SplitContainer();
            this.pnlUrunKayitAlt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtFirmaKodu = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtKullanimSuresi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAciklamaEng = new System.Windows.Forms.TextBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtAciklamaTr = new System.Windows.Forms.TextBox();
            this.txtGTarih = new System.Windows.Forms.DateTimePicker();
            this.pbUrunResmi = new System.Windows.Forms.PictureBox();
            this.BtnUrunResmiEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scUrunKayit)).BeginInit();
            this.scUrunKayit.Panel1.SuspendLayout();
            this.scUrunKayit.Panel2.SuspendLayout();
            this.scUrunKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit1;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(1191, 8);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(35, 35);
            this.BtnKapat.TabIndex = 10;
            this.BtnKapat.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clearIcon2;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(135, 8);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(35, 35);
            this.BtnTemizle.TabIndex = 9;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_delete_303;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(94, 8);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(35, 35);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_refresh_641;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(53, 8);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(35, 35);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.save2;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(12, 8);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(35, 35);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1238, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Urun Kayit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scUrunKayit
            // 
            this.scUrunKayit.BackColor = System.Drawing.Color.LavenderBlush;
            this.scUrunKayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scUrunKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scUrunKayit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scUrunKayit.Location = new System.Drawing.Point(0, 48);
            this.scUrunKayit.Name = "scUrunKayit";
            this.scUrunKayit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scUrunKayit.Panel1
            // 
            this.scUrunKayit.Panel1.Controls.Add(this.BtnUrunResmiEkle);
            this.scUrunKayit.Panel1.Controls.Add(this.pbUrunResmi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtGTarih);
            this.scUrunKayit.Panel1.Controls.Add(this.txtKullanimSuresi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtAciklamaTr);
            this.scUrunKayit.Panel1.Controls.Add(this.txtFirmaKodu);
            this.scUrunKayit.Panel1.Controls.Add(this.txtSinif);
            this.scUrunKayit.Panel1.Controls.Add(this.txtUrunKodu);
            this.scUrunKayit.Panel1.Controls.Add(this.txtFirmaAdi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtAciklamaEng);
            this.scUrunKayit.Panel1.Controls.Add(this.txtUrunId);
            this.scUrunKayit.Panel1.Controls.Add(this.label7);
            this.scUrunKayit.Panel1.Controls.Add(this.label12);
            this.scUrunKayit.Panel1.Controls.Add(this.label6);
            this.scUrunKayit.Panel1.Controls.Add(this.label5);
            this.scUrunKayit.Panel1.Controls.Add(this.label10);
            this.scUrunKayit.Panel1.Controls.Add(this.label4);
            this.scUrunKayit.Panel1.Controls.Add(this.label8);
            this.scUrunKayit.Panel1.Controls.Add(this.label3);
            this.scUrunKayit.Panel1.Controls.Add(this.label2);
            // 
            // scUrunKayit.Panel2
            // 
            this.scUrunKayit.Panel2.Controls.Add(this.pnlUrunKayitAlt);
            this.scUrunKayit.Size = new System.Drawing.Size(1238, 713);
            this.scUrunKayit.SplitterDistance = 267;
            this.scUrunKayit.TabIndex = 11;
            // 
            // pnlUrunKayitAlt
            // 
            this.pnlUrunKayitAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUrunKayitAlt.Location = new System.Drawing.Point(0, 0);
            this.pnlUrunKayitAlt.Name = "pnlUrunKayitAlt";
            this.pnlUrunKayitAlt.Size = new System.Drawing.Size(1234, 438);
            this.pnlUrunKayitAlt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Kodu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(31, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Firma Kodu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(31, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Firma Adı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(31, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giriş Tarih";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightPink;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(31, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kullanım Süresi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(149, 24);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(159, 20);
            this.txtUrunId.TabIndex = 1;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(149, 59);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(159, 20);
            this.txtUrunKodu.TabIndex = 1;
            // 
            // txtFirmaKodu
            // 
            this.txtFirmaKodu.Location = new System.Drawing.Point(149, 94);
            this.txtFirmaKodu.Name = "txtFirmaKodu";
            this.txtFirmaKodu.Size = new System.Drawing.Size(159, 20);
            this.txtFirmaKodu.TabIndex = 1;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(149, 129);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(159, 20);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // txtKullanimSuresi
            // 
            this.txtKullanimSuresi.Location = new System.Drawing.Point(149, 199);
            this.txtKullanimSuresi.Name = "txtKullanimSuresi";
            this.txtKullanimSuresi.Size = new System.Drawing.Size(159, 20);
            this.txtKullanimSuresi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(445, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Açıklama Eng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightPink;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(445, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Açıklama Tr";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightPink;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(445, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sınıfı";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklamaEng
            // 
            this.txtAciklamaEng.Location = new System.Drawing.Point(563, 24);
            this.txtAciklamaEng.Multiline = true;
            this.txtAciklamaEng.Name = "txtAciklamaEng";
            this.txtAciklamaEng.Size = new System.Drawing.Size(328, 55);
            this.txtAciklamaEng.TabIndex = 1;
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(563, 164);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(159, 20);
            this.txtSinif.TabIndex = 1;
            // 
            // txtAciklamaTr
            // 
            this.txtAciklamaTr.Location = new System.Drawing.Point(563, 94);
            this.txtAciklamaTr.Multiline = true;
            this.txtAciklamaTr.Name = "txtAciklamaTr";
            this.txtAciklamaTr.Size = new System.Drawing.Size(328, 58);
            this.txtAciklamaTr.TabIndex = 1;
            // 
            // txtGTarih
            // 
            this.txtGTarih.Location = new System.Drawing.Point(149, 167);
            this.txtGTarih.Name = "txtGTarih";
            this.txtGTarih.Size = new System.Drawing.Size(159, 20);
            this.txtGTarih.TabIndex = 2;
            // 
            // pbUrunResmi
            // 
            this.pbUrunResmi.Location = new System.Drawing.Point(949, 18);
            this.pbUrunResmi.Name = "pbUrunResmi";
            this.pbUrunResmi.Size = new System.Drawing.Size(251, 201);
            this.pbUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrunResmi.TabIndex = 3;
            this.pbUrunResmi.TabStop = false;
            // 
            // BtnUrunResmiEkle
            // 
            this.BtnUrunResmiEkle.BackColor = System.Drawing.Color.LightPink;
            this.BtnUrunResmiEkle.ForeColor = System.Drawing.Color.DimGray;
            this.BtnUrunResmiEkle.Location = new System.Drawing.Point(1033, 225);
            this.BtnUrunResmiEkle.Name = "BtnUrunResmiEkle";
            this.BtnUrunResmiEkle.Size = new System.Drawing.Size(107, 38);
            this.BtnUrunResmiEkle.TabIndex = 4;
            this.BtnUrunResmiEkle.Text = "Ürün Resmi Ekle";
            this.BtnUrunResmiEkle.UseVisualStyleBackColor = false;
            this.BtnUrunResmiEkle.Click += new System.EventHandler(this.BtnUrunResmiEkle_Click);
            // 
            // UrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 761);
            this.Controls.Add(this.scUrunKayit);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "UrunKayit";
            this.Text = "UrunKayit";
            this.Load += new System.EventHandler(this.UrunKayit_Load);
            this.scUrunKayit.Panel1.ResumeLayout(false);
            this.scUrunKayit.Panel1.PerformLayout();
            this.scUrunKayit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scUrunKayit)).EndInit();
            this.scUrunKayit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer scUrunKayit;
        private System.Windows.Forms.Button BtnUrunResmiEkle;
        private System.Windows.Forms.PictureBox pbUrunResmi;
        private System.Windows.Forms.DateTimePicker txtGTarih;
        private System.Windows.Forms.TextBox txtKullanimSuresi;
        private System.Windows.Forms.TextBox txtAciklamaTr;
        private System.Windows.Forms.TextBox txtFirmaKodu;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtAciklamaEng;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUrunKayitAlt;
    }
}