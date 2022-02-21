namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.txtFirmaBul = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtFAdi = new System.Windows.Forms.TextBox();
            this.txtTipAdi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScFirma = new System.Windows.Forms.SplitContainer();
            this.BtnFirmaTipTemizle = new System.Windows.Forms.Button();
            this.BtnSehirTemizle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).BeginInit();
            this.ScFirma.Panel1.SuspendLayout();
            this.ScFirma.Panel2.SuspendLayout();
            this.ScFirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDetayGoster
            // 
            this.BtnDetayGoster.Location = new System.Drawing.Point(780, 214);
            this.BtnDetayGoster.Name = "BtnDetayGoster";
            this.BtnDetayGoster.Size = new System.Drawing.Size(100, 23);
            this.BtnDetayGoster.TabIndex = 10;
            this.BtnDetayGoster.Text = "Detay Goster";
            this.BtnDetayGoster.UseVisualStyleBackColor = true;
            this.BtnDetayGoster.Visible = false;
            this.BtnDetayGoster.Click += new System.EventHandler(this.BtnDetayGoster_Click);
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.Location = new System.Drawing.Point(659, 214);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnDetayEkle.TabIndex = 9;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = true;
            this.BtnDetayEkle.Visible = false;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // txtFirmaBul
            // 
            this.txtFirmaBul.Location = new System.Drawing.Point(659, 180);
            this.txtFirmaBul.Name = "txtFirmaBul";
            this.txtFirmaBul.ReadOnly = true;
            this.txtFirmaBul.Size = new System.Drawing.Size(221, 20);
            this.txtFirmaBul.TabIndex = 8;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(780, 99);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtVergiNo.Location = new System.Drawing.Point(780, 137);
            this.txtVergiNo.Mask = "00000000000";
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(100, 20);
            this.txtVergiNo.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(124, 91);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(235, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(124, 122);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(235, 115);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.Text = "";
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(780, 23);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 4;
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(466, 23);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(140, 20);
            this.txtWeb.TabIndex = 1;
            // 
            // txtFAdi
            // 
            this.txtFAdi.Location = new System.Drawing.Point(124, 24);
            this.txtFAdi.Name = "txtFAdi";
            this.txtFAdi.Size = new System.Drawing.Size(235, 20);
            this.txtFAdi.TabIndex = 0;
            // 
            // txtTipAdi
            // 
            this.txtTipAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipAdi.FormattingEnabled = true;
            this.txtTipAdi.Location = new System.Drawing.Point(124, 59);
            this.txtTipAdi.Name = "txtTipAdi";
            this.txtTipAdi.Size = new System.Drawing.Size(235, 21);
            this.txtTipAdi.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(659, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vergi No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(659, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(399, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Web";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firma Tipi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.TipAdi,
            this.Tel,
            this.Sehir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle5;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Liste.Size = new System.Drawing.Size(913, 253);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Firma Adı";
            this.Adi.Name = "Adi";
            // 
            // TipAdi
            // 
            this.TipAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipAdi.HeaderText = "Firma Tipi";
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 77;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.Width = 68;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 56;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(659, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vergi Dairesi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScFirma
            // 
            this.ScFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScFirma.Location = new System.Drawing.Point(0, 48);
            this.ScFirma.Name = "ScFirma";
            this.ScFirma.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScFirma.Panel1
            // 
            this.ScFirma.Panel1.Controls.Add(this.BtnFirmaTipTemizle);
            this.ScFirma.Panel1.Controls.Add(this.BtnSehirTemizle);
            this.ScFirma.Panel1.Controls.Add(this.txtEmail);
            this.ScFirma.Panel1.Controls.Add(this.label10);
            this.ScFirma.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScFirma.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScFirma.Panel1.Controls.Add(this.txtFirmaBul);
            this.ScFirma.Panel1.Controls.Add(this.txtVergiDairesi);
            this.ScFirma.Panel1.Controls.Add(this.txtVergiNo);
            this.ScFirma.Panel1.Controls.Add(this.txtTelefon);
            this.ScFirma.Panel1.Controls.Add(this.txtAdres);
            this.ScFirma.Panel1.Controls.Add(this.txtSehir);
            this.ScFirma.Panel1.Controls.Add(this.txtWeb);
            this.ScFirma.Panel1.Controls.Add(this.txtFAdi);
            this.ScFirma.Panel1.Controls.Add(this.txtTipAdi);
            this.ScFirma.Panel1.Controls.Add(this.label9);
            this.ScFirma.Panel1.Controls.Add(this.label5);
            this.ScFirma.Panel1.Controls.Add(this.label8);
            this.ScFirma.Panel1.Controls.Add(this.label3);
            this.ScFirma.Panel1.Controls.Add(this.label7);
            this.ScFirma.Panel1.Controls.Add(this.label4);
            this.ScFirma.Panel1.Controls.Add(this.label6);
            this.ScFirma.Panel1.Controls.Add(this.label2);
            // 
            // ScFirma.Panel2
            // 
            this.ScFirma.Panel2.Controls.Add(this.Liste);
            this.ScFirma.Size = new System.Drawing.Size(913, 513);
            this.ScFirma.SplitterDistance = 256;
            this.ScFirma.TabIndex = 12;
            // 
            // BtnFirmaTipTemizle
            // 
            this.BtnFirmaTipTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.close;
            this.BtnFirmaTipTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFirmaTipTemizle.Location = new System.Drawing.Point(365, 59);
            this.BtnFirmaTipTemizle.Name = "BtnFirmaTipTemizle";
            this.BtnFirmaTipTemizle.Size = new System.Drawing.Size(21, 21);
            this.BtnFirmaTipTemizle.TabIndex = 13;
            this.BtnFirmaTipTemizle.UseVisualStyleBackColor = true;
            this.BtnFirmaTipTemizle.Click += new System.EventHandler(this.BtnFirmaTipTemizle_Click);
            // 
            // BtnSehirTemizle
            // 
            this.BtnSehirTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.close;
            this.BtnSehirTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSehirTemizle.Location = new System.Drawing.Point(886, 22);
            this.BtnSehirTemizle.Name = "BtnSehirTemizle";
            this.BtnSehirTemizle.Size = new System.Drawing.Size(21, 21);
            this.BtnSehirTemizle.TabIndex = 13;
            this.BtnSehirTemizle.UseVisualStyleBackColor = true;
            this.BtnSehirTemizle.Click += new System.EventHandler(this.BtnSehirTemizle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(466, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(399, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Email";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit1;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(866, 8);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(35, 35);
            this.BtnKapat.TabIndex = 11;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.clearIcon2;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(180, 7);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(35, 35);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_delete_303;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(124, 7);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(35, 35);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.save2;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(12, 7);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(35, 35);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.icons8_refresh_641;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(68, 7);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(35, 35);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(913, 561);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.ScFirma);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "FirmaGiris";
            this.Text = "FirmaGiris";
            this.Load += new System.EventHandler(this.FirmaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScFirma.Panel1.ResumeLayout(false);
            this.ScFirma.Panel1.PerformLayout();
            this.ScFirma.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).EndInit();
            this.ScFirma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDetayGoster;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.TextBox txtFirmaBul;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox txtVergiNo;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.TextBox txtFAdi;
        private System.Windows.Forms.ComboBox txtTipAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer ScFirma;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button BtnSehirTemizle;
        private System.Windows.Forms.Button BtnFirmaTipTemizle;
    }
}