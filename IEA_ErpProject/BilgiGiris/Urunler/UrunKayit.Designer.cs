﻿namespace IEA_ErpProject.BilgiGiris.Urunler
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
            this.BtnUrunResmiEkle = new System.Windows.Forms.Button();
            this.pbUrunResmi = new System.Windows.Forms.PictureBox();
            this.txtGTarih = new System.Windows.Forms.DateTimePicker();
            this.txtKullanimSuresi = new System.Windows.Forms.TextBox();
            this.txtAciklamaTr = new System.Windows.Forms.TextBox();
            this.txtFirmaKodu = new System.Windows.Forms.TextBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtAciklamaEng = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUrunKayitAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtParaBirimi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinFiyat = new System.Windows.Forms.TextBox();
            this.GMDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNSPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KullanimDisi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUTFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUT_ACIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scUrunKayit)).BeginInit();
            this.scUrunKayit.Panel1.SuspendLayout();
            this.scUrunKayit.Panel2.SuspendLayout();
            this.scUrunKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).BeginInit();
            this.pnlUrunKayitAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
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
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
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
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
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
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
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
            this.scUrunKayit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scUrunKayit.Location = new System.Drawing.Point(0, 48);
            this.scUrunKayit.Name = "scUrunKayit";
            this.scUrunKayit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scUrunKayit.Panel1
            // 
            this.scUrunKayit.Panel1.Controls.Add(this.txtParaBirimi);
            this.scUrunKayit.Panel1.Controls.Add(this.BtnUrunResmiEkle);
            this.scUrunKayit.Panel1.Controls.Add(this.pbUrunResmi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtGTarih);
            this.scUrunKayit.Panel1.Controls.Add(this.txtMinFiyat);
            this.scUrunKayit.Panel1.Controls.Add(this.txtBirimFiyat);
            this.scUrunKayit.Panel1.Controls.Add(this.txtKullanimSuresi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtAciklamaTr);
            this.scUrunKayit.Panel1.Controls.Add(this.txtFirmaKodu);
            this.scUrunKayit.Panel1.Controls.Add(this.txtSinif);
            this.scUrunKayit.Panel1.Controls.Add(this.txtUrunKodu);
            this.scUrunKayit.Panel1.Controls.Add(this.txtFirmaAdi);
            this.scUrunKayit.Panel1.Controls.Add(this.txtAciklamaEng);
            this.scUrunKayit.Panel1.Controls.Add(this.txtUrunId);
            this.scUrunKayit.Panel1.Controls.Add(this.label11);
            this.scUrunKayit.Panel1.Controls.Add(this.label9);
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
            // BtnUrunResmiEkle
            // 
            this.BtnUrunResmiEkle.BackColor = System.Drawing.Color.LightPink;
            this.BtnUrunResmiEkle.ForeColor = System.Drawing.Color.DimGray;
            this.BtnUrunResmiEkle.Location = new System.Drawing.Point(1025, 225);
            this.BtnUrunResmiEkle.Name = "BtnUrunResmiEkle";
            this.BtnUrunResmiEkle.Size = new System.Drawing.Size(107, 38);
            this.BtnUrunResmiEkle.TabIndex = 4;
            this.BtnUrunResmiEkle.Text = "Ürün Resmi Ekle";
            this.BtnUrunResmiEkle.UseVisualStyleBackColor = false;
            this.BtnUrunResmiEkle.Click += new System.EventHandler(this.BtnUrunResmiEkle_Click);
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
            // txtGTarih
            // 
            this.txtGTarih.Location = new System.Drawing.Point(149, 167);
            this.txtGTarih.Name = "txtGTarih";
            this.txtGTarih.Size = new System.Drawing.Size(159, 20);
            this.txtGTarih.TabIndex = 2;
            // 
            // txtKullanimSuresi
            // 
            this.txtKullanimSuresi.Location = new System.Drawing.Point(149, 199);
            this.txtKullanimSuresi.Name = "txtKullanimSuresi";
            this.txtKullanimSuresi.Size = new System.Drawing.Size(159, 20);
            this.txtKullanimSuresi.TabIndex = 1;
            // 
            // txtAciklamaTr
            // 
            this.txtAciklamaTr.Location = new System.Drawing.Point(563, 94);
            this.txtAciklamaTr.Multiline = true;
            this.txtAciklamaTr.Name = "txtAciklamaTr";
            this.txtAciklamaTr.Size = new System.Drawing.Size(328, 58);
            this.txtAciklamaTr.TabIndex = 1;
            // 
            // txtFirmaKodu
            // 
            this.txtFirmaKodu.Location = new System.Drawing.Point(149, 94);
            this.txtFirmaKodu.Name = "txtFirmaKodu";
            this.txtFirmaKodu.ReadOnly = true;
            this.txtFirmaKodu.Size = new System.Drawing.Size(159, 20);
            this.txtFirmaKodu.TabIndex = 1;
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(563, 164);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(159, 20);
            this.txtSinif.TabIndex = 1;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(149, 59);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(159, 20);
            this.txtUrunKodu.TabIndex = 1;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Location = new System.Drawing.Point(149, 129);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(159, 20);
            this.txtFirmaAdi.TabIndex = 1;
            // 
            // txtAciklamaEng
            // 
            this.txtAciklamaEng.Location = new System.Drawing.Point(563, 24);
            this.txtAciklamaEng.Multiline = true;
            this.txtAciklamaEng.Name = "txtAciklamaEng";
            this.txtAciklamaEng.Size = new System.Drawing.Size(328, 55);
            this.txtAciklamaEng.TabIndex = 1;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(149, 24);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(159, 20);
            this.txtUrunId.TabIndex = 1;
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
            // pnlUrunKayitAlt
            // 
            this.pnlUrunKayitAlt.Controls.Add(this.Liste);
            this.pnlUrunKayitAlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUrunKayitAlt.Location = new System.Drawing.Point(0, 0);
            this.pnlUrunKayitAlt.Name = "pnlUrunKayitAlt";
            this.pnlUrunKayitAlt.Size = new System.Drawing.Size(1234, 438);
            this.pnlUrunKayitAlt.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GMDN,
            this.UNSPC,
            this.SB,
            this.KullanimDisi,
            this.UBB,
            this.SUT,
            this.SUTFiyat,
            this.SUT_ACIKLAMA,
            this.UTS});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1234, 438);
            this.Liste.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightPink;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(445, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Birim Fiyat";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(563, 199);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(159, 20);
            this.txtBirimFiyat.TabIndex = 1;
            // 
            // txtParaBirimi
            // 
            this.txtParaBirimi.FormattingEnabled = true;
            this.txtParaBirimi.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "TRY",
            "GBP",
            "PLN",
            "RUB",
            "JPY",
            "CNY"});
            this.txtParaBirimi.Location = new System.Drawing.Point(728, 198);
            this.txtParaBirimi.Name = "txtParaBirimi";
            this.txtParaBirimi.Size = new System.Drawing.Size(54, 21);
            this.txtParaBirimi.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightPink;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(445, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mininum Fiyat";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMinFiyat
            // 
            this.txtMinFiyat.Location = new System.Drawing.Point(563, 234);
            this.txtMinFiyat.Name = "txtMinFiyat";
            this.txtMinFiyat.Size = new System.Drawing.Size(159, 20);
            this.txtMinFiyat.TabIndex = 1;
            // 
            // GMDN
            // 
            this.GMDN.HeaderText = "GMDN";
            this.GMDN.Name = "GMDN";
            // 
            // UNSPC
            // 
            this.UNSPC.HeaderText = "UNSPC";
            this.UNSPC.Name = "UNSPC";
            // 
            // SB
            // 
            this.SB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SB.HeaderText = "SB";
            this.SB.Name = "SB";
            this.SB.Width = 27;
            // 
            // KullanimDisi
            // 
            this.KullanimDisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KullanimDisi.HeaderText = "Kul Disi";
            this.KullanimDisi.Name = "KullanimDisi";
            this.KullanimDisi.Width = 48;
            // 
            // UBB
            // 
            this.UBB.HeaderText = "UBB";
            this.UBB.Name = "UBB";
            // 
            // SUT
            // 
            this.SUT.HeaderText = "SUT";
            this.SUT.Name = "SUT";
            // 
            // SUTFiyat
            // 
            this.SUTFiyat.HeaderText = "SUT_FIYAT";
            this.SUTFiyat.Name = "SUTFiyat";
            // 
            // SUT_ACIKLAMA
            // 
            this.SUT_ACIKLAMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUT_ACIKLAMA.HeaderText = "SUT_ACIKLAMA";
            this.SUT_ACIKLAMA.Name = "SUT_ACIKLAMA";
            // 
            // UTS
            // 
            this.UTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTS.HeaderText = "UTS";
            this.UTS.Name = "UTS";
            this.UTS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UTS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UTS.Width = 54;
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
            this.pnlUrunKayitAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
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
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ComboBox txtParaBirimi;
        private System.Windows.Forms.TextBox txtMinFiyat;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn GMDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNSPC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KullanimDisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUTFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUT_ACIKLAMA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UTS;
    }
}