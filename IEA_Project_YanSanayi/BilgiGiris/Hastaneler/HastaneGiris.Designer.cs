namespace IEA_Project_YanSanayi.BilgiGiris.Hastaneler
{
    partial class HastaneGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.scHastane = new System.Windows.Forms.SplitContainer();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.txtHastaneBul = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtCariHAdi = new System.Windows.Forms.TextBox();
            this.txtHAdi = new System.Windows.Forms.TextBox();
            this.txtTipAdi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scHastane)).BeginInit();
            this.scHastane.Panel1.SuspendLayout();
            this.scHastane.Panel2.SuspendLayout();
            this.scHastane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scHastane
            // 
            this.scHastane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHastane.Location = new System.Drawing.Point(0, 60);
            this.scHastane.Name = "scHastane";
            this.scHastane.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHastane.Panel1
            // 
            this.scHastane.Panel1.Controls.Add(this.BtnDetayEkle);
            this.scHastane.Panel1.Controls.Add(this.txtHastaneBul);
            this.scHastane.Panel1.Controls.Add(this.txtVergiDairesi);
            this.scHastane.Panel1.Controls.Add(this.txtVergiNo);
            this.scHastane.Panel1.Controls.Add(this.txtTelefon);
            this.scHastane.Panel1.Controls.Add(this.txtAdres);
            this.scHastane.Panel1.Controls.Add(this.txtSehir);
            this.scHastane.Panel1.Controls.Add(this.txtCariHAdi);
            this.scHastane.Panel1.Controls.Add(this.txtHAdi);
            this.scHastane.Panel1.Controls.Add(this.txtTipAdi);
            this.scHastane.Panel1.Controls.Add(this.label9);
            this.scHastane.Panel1.Controls.Add(this.label5);
            this.scHastane.Panel1.Controls.Add(this.label7);
            this.scHastane.Panel1.Controls.Add(this.label6);
            this.scHastane.Panel1.Controls.Add(this.label8);
            this.scHastane.Panel1.Controls.Add(this.label3);
            this.scHastane.Panel1.Controls.Add(this.label4);
            this.scHastane.Panel1.Controls.Add(this.label2);
            // 
            // scHastane.Panel2
            // 
            this.scHastane.Panel2.Controls.Add(this.Liste);
            this.scHastane.Size = new System.Drawing.Size(992, 470);
            this.scHastane.SplitterDistance = 270;
            this.scHastane.TabIndex = 3;
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.Location = new System.Drawing.Point(766, 215);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnDetayEkle.TabIndex = 23;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = true;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // txtHastaneBul
            // 
            this.txtHastaneBul.Location = new System.Drawing.Point(688, 181);
            this.txtHastaneBul.Name = "txtHastaneBul";
            this.txtHastaneBul.Size = new System.Drawing.Size(221, 20);
            this.txtHastaneBul.TabIndex = 22;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(809, 100);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 20;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtVergiNo.Location = new System.Drawing.Point(809, 138);
            this.txtVergiNo.Mask = "00000000000";
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(100, 20);
            this.txtVergiNo.TabIndex = 21;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(809, 60);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(153, 123);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(495, 115);
            this.txtAdres.TabIndex = 17;
            this.txtAdres.Text = "";
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(809, 27);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(100, 21);
            this.txtSehir.TabIndex = 18;
            // 
            // txtCariHAdi
            // 
            this.txtCariHAdi.Location = new System.Drawing.Point(153, 55);
            this.txtCariHAdi.Name = "txtCariHAdi";
            this.txtCariHAdi.Size = new System.Drawing.Size(495, 20);
            this.txtCariHAdi.TabIndex = 15;
            // 
            // txtHAdi
            // 
            this.txtHAdi.Location = new System.Drawing.Point(153, 25);
            this.txtHAdi.Name = "txtHAdi";
            this.txtHAdi.Size = new System.Drawing.Size(495, 20);
            this.txtHAdi.TabIndex = 10;
            // 
            // txtTipAdi
            // 
            this.txtTipAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipAdi.FormattingEnabled = true;
            this.txtTipAdi.Location = new System.Drawing.Point(153, 90);
            this.txtTipAdi.Name = "txtTipAdi";
            this.txtTipAdi.Size = new System.Drawing.Size(495, 21);
            this.txtTipAdi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(688, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Vergi No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(688, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şehir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(688, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vergi Dairesi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(688, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefon";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(25, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cari Adı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hastane Tipi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hastane Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.BackgroundColor = System.Drawing.Color.White;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.TipAdi,
            this.Tel,
            this.Sehir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle2;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Size = new System.Drawing.Size(992, 196);
            this.Liste.TabIndex = 1;
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
            this.Adi.HeaderText = "Hastane Adı";
            this.Adi.Name = "Adi";
            // 
            // TipAdi
            // 
            this.TipAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipAdi.HeaderText = "Hastane Tipi";
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 92;
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
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.exit;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(932, 12);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(48, 39);
            this.BtnKapat.TabIndex = 2;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.clear;
            this.BtnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTemizle.Location = new System.Drawing.Point(308, 12);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(48, 39);
            this.BtnTemizle.TabIndex = 2;
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.icons8_delete_30;
            this.BtnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSil.Location = new System.Drawing.Point(219, 12);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(48, 39);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.icons8_refresh_64;
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuncelle.Location = new System.Drawing.Point(133, 12);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(48, 39);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.save;
            this.BtnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKaydet.Location = new System.Drawing.Point(43, 12);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(48, 39);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // HastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 530);
            this.Controls.Add(this.scHastane);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.label1);
            this.Name = "HastaneGiris";
            this.Text = "HastaneGiris";
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.scHastane.Panel1.ResumeLayout(false);
            this.scHastane.Panel1.PerformLayout();
            this.scHastane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHastane)).EndInit();
            this.scHastane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.SplitContainer scHastane;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.TextBox txtHastaneBul;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox txtVergiNo;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.TextBox txtCariHAdi;
        private System.Windows.Forms.TextBox txtHAdi;
        private System.Windows.Forms.ComboBox txtTipAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
    }
}