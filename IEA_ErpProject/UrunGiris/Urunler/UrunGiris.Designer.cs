namespace IEA_ErpProject.UrunGiris.Urunler
{
    partial class UrunGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.scUrunGiris = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnListeSatirSil = new System.Windows.Forms.Button();
            this.BtnListeEkle = new System.Windows.Forms.Button();
            this.etiketId = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGirisTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCariTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGirisId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scUrunGiris)).BeginInit();
            this.scUrunGiris.Panel1.SuspendLayout();
            this.scUrunGiris.Panel2.SuspendLayout();
            this.scUrunGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(505, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Urun Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.LightPink;
            this.pnlUst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUst.Controls.Add(this.BtnPrint);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.BtnKapat);
            this.pnlUst.Controls.Add(this.BtnTemizle);
            this.pnlUst.Controls.Add(this.BtnSil);
            this.pnlUst.Controls.Add(this.BtnGuncelle);
            this.pnlUst.Controls.Add(this.BtnKaydet);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1295, 57);
            this.pnlUst.TabIndex = 4;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundImage = global::IEA_ErpProject.Properties.Resources.print;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint.Location = new System.Drawing.Point(176, 12);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(38, 38);
            this.BtnPrint.TabIndex = 10;
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit1;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(1244, 12);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(38, 38);
            this.BtnKapat.TabIndex = 9;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clearIcon2;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(135, 12);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(38, 38);
            this.BtnTemizle.TabIndex = 8;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_delete_303;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(94, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(38, 38);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_refresh_641;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(53, 12);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(38, 38);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.save2;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(12, 12);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(38, 38);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // scUrunGiris
            // 
            this.scUrunGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scUrunGiris.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scUrunGiris.Location = new System.Drawing.Point(0, 57);
            this.scUrunGiris.Name = "scUrunGiris";
            // 
            // scUrunGiris.Panel1
            // 
            this.scUrunGiris.Panel1.Controls.Add(this.Liste);
            this.scUrunGiris.Panel1.Controls.Add(this.panel1);
            // 
            // scUrunGiris.Panel2
            // 
            this.scUrunGiris.Panel2.BackColor = System.Drawing.Color.Pink;
            this.scUrunGiris.Panel2.Controls.Add(this.txtAciklama);
            this.scUrunGiris.Panel2.Controls.Add(this.label8);
            this.scUrunGiris.Panel2.Controls.Add(this.txtGirisTarihi);
            this.scUrunGiris.Panel2.Controls.Add(this.label7);
            this.scUrunGiris.Panel2.Controls.Add(this.txtFaturaNo);
            this.scUrunGiris.Panel2.Controls.Add(this.label6);
            this.scUrunGiris.Panel2.Controls.Add(this.txtGirisTuru);
            this.scUrunGiris.Panel2.Controls.Add(this.label5);
            this.scUrunGiris.Panel2.Controls.Add(this.txtCariAdi);
            this.scUrunGiris.Panel2.Controls.Add(this.label4);
            this.scUrunGiris.Panel2.Controls.Add(this.txtCariTur);
            this.scUrunGiris.Panel2.Controls.Add(this.label3);
            this.scUrunGiris.Panel2.Controls.Add(this.txtGirisId);
            this.scUrunGiris.Panel2.Controls.Add(this.label2);
            this.scUrunGiris.Size = new System.Drawing.Size(1295, 491);
            this.scUrunGiris.SplitterDistance = 1001;
            this.scUrunGiris.TabIndex = 5;
            // 
            // Liste
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.GirisAdet,
            this.Not,
            this.UrunId,
            this.Uts,
            this.UTarih,
            this.SKTarihi,
            this.Durum});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 42);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Liste.Size = new System.Drawing.Size(997, 445);
            this.Liste.TabIndex = 1;
            this.Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellClick);
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.BtnListeSatirSil);
            this.panel1.Controls.Add(this.BtnListeEkle);
            this.panel1.Controls.Add(this.etiketId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 42);
            this.panel1.TabIndex = 2;
            // 
            // BtnListeSatirSil
            // 
            this.BtnListeSatirSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.minus;
            this.BtnListeSatirSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnListeSatirSil.FlatAppearance.BorderSize = 0;
            this.BtnListeSatirSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListeSatirSil.Location = new System.Drawing.Point(918, 4);
            this.BtnListeSatirSil.Name = "BtnListeSatirSil";
            this.BtnListeSatirSil.Size = new System.Drawing.Size(35, 35);
            this.BtnListeSatirSil.TabIndex = 1;
            this.BtnListeSatirSil.UseVisualStyleBackColor = false;
            this.BtnListeSatirSil.Click += new System.EventHandler(this.BtnListeSatirSil_Click);
            // 
            // BtnListeEkle
            // 
            this.BtnListeEkle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.add;
            this.BtnListeEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnListeEkle.FlatAppearance.BorderSize = 0;
            this.BtnListeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListeEkle.Location = new System.Drawing.Point(959, 4);
            this.BtnListeEkle.Name = "BtnListeEkle";
            this.BtnListeEkle.Size = new System.Drawing.Size(35, 35);
            this.BtnListeEkle.TabIndex = 0;
            this.BtnListeEkle.UseVisualStyleBackColor = false;
            this.BtnListeEkle.Click += new System.EventHandler(this.BtnListeEkle_Click);
            // 
            // etiketId
            // 
            this.etiketId.BackColor = System.Drawing.Color.LightPink;
            this.etiketId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etiketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etiketId.Location = new System.Drawing.Point(505, 8);
            this.etiketId.Name = "etiketId";
            this.etiketId.Size = new System.Drawing.Size(214, 23);
            this.etiketId.TabIndex = 0;
            this.etiketId.Text = "***";
            this.etiketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAciklama.Location = new System.Drawing.Point(0, 311);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(286, 48);
            this.txtAciklama.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(0, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Açıklama";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisTarihi.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.txtGirisTarihi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtGirisTarihi.Location = new System.Drawing.Point(0, 268);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.Size = new System.Drawing.Size(286, 20);
            this.txtGirisTarihi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(0, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giriş Tarihi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFaturaNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFaturaNo.Location = new System.Drawing.Point(0, 225);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(286, 20);
            this.txtFaturaNo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(0, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fatura No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGirisTuru
            // 
            this.txtGirisTuru.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtGirisTuru.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGirisTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGirisTuru.FormattingEnabled = true;
            this.txtGirisTuru.Items.AddRange(new object[] {
            "Normal Giris",
            "Muhtelif Giris"});
            this.txtGirisTuru.Location = new System.Drawing.Point(0, 181);
            this.txtGirisTuru.Name = "txtGirisTuru";
            this.txtGirisTuru.Size = new System.Drawing.Size(286, 21);
            this.txtGirisTuru.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giriş Türü";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCariAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCariAdi.Location = new System.Drawing.Point(0, 110);
            this.txtCariAdi.Multiline = true;
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(286, 48);
            this.txtCariAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(0, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cari Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCariTur
            // 
            this.txtCariTur.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCariTur.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCariTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCariTur.FormattingEnabled = true;
            this.txtCariTur.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.txtCariTur.Location = new System.Drawing.Point(0, 66);
            this.txtCariTur.Name = "txtCariTur";
            this.txtCariTur.Size = new System.Drawing.Size(286, 21);
            this.txtCariTur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(0, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cari Türü";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGirisId
            // 
            this.txtGirisId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtGirisId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGirisId.Location = new System.Drawing.Point(0, 23);
            this.txtGirisId.Name = "txtGirisId";
            this.txtGirisId.ReadOnly = true;
            this.txtGirisId.Size = new System.Drawing.Size(286, 20);
            this.txtGirisId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giriş No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.ReadOnly = true;
            this.Barkod.Visible = false;
            this.Barkod.Width = 66;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            this.LotSeri.Width = 85;
            // 
            // GirisAdet
            // 
            this.GirisAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdet.HeaderText = "Giriş Adet";
            this.GirisAdet.Name = "GirisAdet";
            this.GirisAdet.Width = 77;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.NullValue = "**";
            this.Not.DefaultCellStyle = dataGridViewCellStyle2;
            this.Not.HeaderText = "Not";
            this.Not.Name = "Not";
            this.Not.Width = 49;
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.Visible = false;
            this.UrunId.Width = 64;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.FalseValue = "False";
            this.Uts.HeaderText = "UTS";
            this.Uts.Name = "Uts";
            this.Uts.TrueValue = "True";
            this.Uts.Width = 35;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Üretim Tarihi";
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 91;
            // 
            // SKTarihi
            // 
            this.SKTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SKTarihi.HeaderText = "Son Kullanma Tarihi";
            this.SKTarihi.Name = "SKTarihi";
            this.SKTarihi.ReadOnly = true;
            this.SKTarihi.Width = 115;
            // 
            // Durum
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.NullValue = false;
            this.Durum.DefaultCellStyle = dataGridViewCellStyle3;
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            // 
            // UrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1295, 548);
            this.Controls.Add(this.scUrunGiris);
            this.Controls.Add(this.pnlUst);
            this.Name = "UrunGiris";
            this.Text = "UrunGiris";
            this.Load += new System.EventHandler(this.UrunGiris_Load);
            this.pnlUst.ResumeLayout(false);
            this.scUrunGiris.Panel1.ResumeLayout(false);
            this.scUrunGiris.Panel2.ResumeLayout(false);
            this.scUrunGiris.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scUrunGiris)).EndInit();
            this.scUrunGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.SplitContainer scUrunGiris;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtGirisTarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtGirisTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtCariTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGirisId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnListeSatirSil;
        private System.Windows.Forms.Button BtnListeEkle;
        private System.Windows.Forms.Label etiketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
    }
}