namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    partial class DoktorGiris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGiris));
            this.txtDoktorBul = new System.Windows.Forms.TextBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMuayenehane = new System.Windows.Forms.RichTextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtDAdi = new System.Windows.Forms.TextBox();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.txtHastane1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScDoktor = new System.Windows.Forms.SplitContainer();
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.txtDTarih = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGsm = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtHastane3 = new System.Windows.Forms.ComboBox();
            this.txtHastane2 = new System.Windows.Forms.ComboBox();
            this.txtUnvan = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUnvanTemizle = new System.Windows.Forms.Button();
            this.BtnHastane2Temizle = new System.Windows.Forms.Button();
            this.BtnHastane1Temizle = new System.Windows.Forms.Button();
            this.BtnHastane3Temizle = new System.Windows.Forms.Button();
            this.BtnSehirTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScDoktor)).BeginInit();
            this.ScDoktor.Panel1.SuspendLayout();
            this.ScDoktor.Panel2.SuspendLayout();
            this.ScDoktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoktorBul
            // 
            this.txtDoktorBul.Location = new System.Drawing.Point(676, 181);
            this.txtDoktorBul.Name = "txtDoktorBul";
            this.txtDoktorBul.ReadOnly = true;
            this.txtDoktorBul.Size = new System.Drawing.Size(204, 20);
            this.txtDoktorBul.TabIndex = 8;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(780, 111);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(100, 20);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtVergiNo.Location = new System.Drawing.Point(780, 141);
            this.txtVergiNo.Mask = "00000000000";
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(100, 20);
            this.txtVergiNo.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(780, 21);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtMuayenehane
            // 
            this.txtMuayenehane.Location = new System.Drawing.Point(430, 119);
            this.txtMuayenehane.Name = "txtMuayenehane";
            this.txtMuayenehane.Size = new System.Drawing.Size(240, 102);
            this.txtMuayenehane.TabIndex = 3;
            this.txtMuayenehane.Text = "";
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(124, 200);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(266, 21);
            this.txtSehir.TabIndex = 4;
            // 
            // txtDAdi
            // 
            this.txtDAdi.Location = new System.Drawing.Point(124, 54);
            this.txtDAdi.Name = "txtDAdi";
            this.txtDAdi.Size = new System.Drawing.Size(266, 20);
            this.txtDAdi.TabIndex = 1;
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
            // txtHastane1
            // 
            this.txtHastane1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHastane1.FormattingEnabled = true;
            this.txtHastane1.Location = new System.Drawing.Point(124, 89);
            this.txtHastane1.Name = "txtHastane1";
            this.txtHastane1.Size = new System.Drawing.Size(266, 21);
            this.txtHastane1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(676, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vergi No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Doktor Adı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hastane-1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Unvan,
            this.Adi,
            this.Tel1,
            this.Tel2,
            this.Gsm,
            this.Email,
            this.Sehir});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle11;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // Unvan
            // 
            this.Unvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Unvan.HeaderText = "Unvan";
            this.Unvan.Name = "Unvan";
            this.Unvan.Width = 64;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Doktor Adı";
            this.Adi.Name = "Adi";
            // 
            // Tel1
            // 
            this.Tel1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel1.HeaderText = "Telefon-1";
            this.Tel1.Name = "Tel1";
            this.Tel1.Width = 77;
            // 
            // Tel2
            // 
            this.Tel2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel2.HeaderText = "Telefon-2";
            this.Tel2.Name = "Tel2";
            this.Tel2.Width = 77;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 53;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
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
            this.label7.Location = new System.Drawing.Point(676, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vergi Dairesi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(430, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Muayenehane";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(676, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
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
            this.label2.Text = "Unvan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScDoktor
            // 
            this.ScDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScDoktor.Location = new System.Drawing.Point(0, 48);
            this.ScDoktor.Name = "ScDoktor";
            this.ScDoktor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScDoktor.Panel1
            // 
            this.ScDoktor.Panel1.Controls.Add(this.BtnHastane1Temizle);
            this.ScDoktor.Panel1.Controls.Add(this.BtnSehirTemizle);
            this.ScDoktor.Panel1.Controls.Add(this.BtnHastane3Temizle);
            this.ScDoktor.Panel1.Controls.Add(this.BtnHastane2Temizle);
            this.ScDoktor.Panel1.Controls.Add(this.BtnUnvanTemizle);
            this.ScDoktor.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScDoktor.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScDoktor.Panel1.Controls.Add(this.txtDTarih);
            this.ScDoktor.Panel1.Controls.Add(this.txtDoktorBul);
            this.ScDoktor.Panel1.Controls.Add(this.txtEmail);
            this.ScDoktor.Panel1.Controls.Add(this.txtVergiDairesi);
            this.ScDoktor.Panel1.Controls.Add(this.txtVergiNo);
            this.ScDoktor.Panel1.Controls.Add(this.txtGsm);
            this.ScDoktor.Panel1.Controls.Add(this.txtTelefon2);
            this.ScDoktor.Panel1.Controls.Add(this.txtTelefon);
            this.ScDoktor.Panel1.Controls.Add(this.txtMuayenehane);
            this.ScDoktor.Panel1.Controls.Add(this.txtSehir);
            this.ScDoktor.Panel1.Controls.Add(this.txtDAdi);
            this.ScDoktor.Panel1.Controls.Add(this.txtHastane3);
            this.ScDoktor.Panel1.Controls.Add(this.txtHastane2);
            this.ScDoktor.Panel1.Controls.Add(this.txtUnvan);
            this.ScDoktor.Panel1.Controls.Add(this.txtHastane1);
            this.ScDoktor.Panel1.Controls.Add(this.label9);
            this.ScDoktor.Panel1.Controls.Add(this.label15);
            this.ScDoktor.Panel1.Controls.Add(this.label13);
            this.ScDoktor.Panel1.Controls.Add(this.label5);
            this.ScDoktor.Panel1.Controls.Add(this.label8);
            this.ScDoktor.Panel1.Controls.Add(this.label11);
            this.ScDoktor.Panel1.Controls.Add(this.label10);
            this.ScDoktor.Panel1.Controls.Add(this.label3);
            this.ScDoktor.Panel1.Controls.Add(this.label7);
            this.ScDoktor.Panel1.Controls.Add(this.label4);
            this.ScDoktor.Panel1.Controls.Add(this.label14);
            this.ScDoktor.Panel1.Controls.Add(this.label12);
            this.ScDoktor.Panel1.Controls.Add(this.label6);
            this.ScDoktor.Panel1.Controls.Add(this.label2);
            // 
            // ScDoktor.Panel2
            // 
            this.ScDoktor.Panel2.Controls.Add(this.Liste);
            this.ScDoktor.Size = new System.Drawing.Size(913, 513);
            this.ScDoktor.SplitterDistance = 256;
            this.ScDoktor.TabIndex = 12;
            // 
            // BtnDetayGoster
            // 
            this.BtnDetayGoster.Location = new System.Drawing.Point(780, 221);
            this.BtnDetayGoster.Name = "BtnDetayGoster";
            this.BtnDetayGoster.Size = new System.Drawing.Size(100, 23);
            this.BtnDetayGoster.TabIndex = 13;
            this.BtnDetayGoster.Text = "Detay Goster";
            this.BtnDetayGoster.UseVisualStyleBackColor = true;
            this.BtnDetayGoster.Visible = false;
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.Location = new System.Drawing.Point(676, 221);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnDetayEkle.TabIndex = 12;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = true;
            this.BtnDetayEkle.Visible = false;
            // 
            // txtDTarih
            // 
            this.txtDTarih.Location = new System.Drawing.Point(528, 21);
            this.txtDTarih.Name = "txtDTarih";
            this.txtDTarih.Size = new System.Drawing.Size(142, 20);
            this.txtDTarih.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(528, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(780, 81);
            this.txtGsm.Mask = "(999) 000-0000";
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 20);
            this.txtGsm.TabIndex = 5;
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(780, 51);
            this.txtTelefon2.Mask = "(999) 000-0000";
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon2.TabIndex = 5;
            // 
            // txtHastane3
            // 
            this.txtHastane3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHastane3.FormattingEnabled = true;
            this.txtHastane3.Location = new System.Drawing.Point(124, 161);
            this.txtHastane3.Name = "txtHastane3";
            this.txtHastane3.Size = new System.Drawing.Size(266, 21);
            this.txtHastane3.TabIndex = 2;
            // 
            // txtHastane2
            // 
            this.txtHastane2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtHastane2.FormattingEnabled = true;
            this.txtHastane2.Location = new System.Drawing.Point(124, 121);
            this.txtHastane2.Name = "txtHastane2";
            this.txtHastane2.Size = new System.Drawing.Size(266, 21);
            this.txtHastane2.TabIndex = 2;
            // 
            // txtUnvan
            // 
            this.txtUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnvan.FormattingEnabled = true;
            this.txtUnvan.Location = new System.Drawing.Point(124, 23);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(266, 21);
            this.txtUnvan.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(430, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Email";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(430, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Dogum Tarihi";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(12, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hastane-3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hastane-2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(676, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "GSM";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(676, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telefon2";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label1.Text = "Doktor Giris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUnvanTemizle
            // 
            this.BtnUnvanTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUnvanTemizle.BackgroundImage")));
            this.BtnUnvanTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUnvanTemizle.Location = new System.Drawing.Point(396, 22);
            this.BtnUnvanTemizle.Name = "BtnUnvanTemizle";
            this.BtnUnvanTemizle.Size = new System.Drawing.Size(23, 23);
            this.BtnUnvanTemizle.TabIndex = 14;
            this.BtnUnvanTemizle.UseVisualStyleBackColor = true;
            this.BtnUnvanTemizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnHastane2Temizle
            // 
            this.BtnHastane2Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastane2Temizle.BackgroundImage")));
            this.BtnHastane2Temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastane2Temizle.Location = new System.Drawing.Point(396, 119);
            this.BtnHastane2Temizle.Name = "BtnHastane2Temizle";
            this.BtnHastane2Temizle.Size = new System.Drawing.Size(23, 23);
            this.BtnHastane2Temizle.TabIndex = 14;
            this.BtnHastane2Temizle.UseVisualStyleBackColor = true;
            this.BtnHastane2Temizle.Click += new System.EventHandler(this.BtnHastane2Temizle_Click);
            // 
            // BtnHastane1Temizle
            // 
            this.BtnHastane1Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastane1Temizle.BackgroundImage")));
            this.BtnHastane1Temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastane1Temizle.Location = new System.Drawing.Point(396, 89);
            this.BtnHastane1Temizle.Name = "BtnHastane1Temizle";
            this.BtnHastane1Temizle.Size = new System.Drawing.Size(23, 23);
            this.BtnHastane1Temizle.TabIndex = 14;
            this.BtnHastane1Temizle.UseVisualStyleBackColor = true;
            this.BtnHastane1Temizle.Click += new System.EventHandler(this.BtnHastane1Temizle_Click);
            // 
            // BtnHastane3Temizle
            // 
            this.BtnHastane3Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastane3Temizle.BackgroundImage")));
            this.BtnHastane3Temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastane3Temizle.Location = new System.Drawing.Point(396, 161);
            this.BtnHastane3Temizle.Name = "BtnHastane3Temizle";
            this.BtnHastane3Temizle.Size = new System.Drawing.Size(23, 23);
            this.BtnHastane3Temizle.TabIndex = 14;
            this.BtnHastane3Temizle.UseVisualStyleBackColor = true;
            this.BtnHastane3Temizle.Click += new System.EventHandler(this.BtnHastane3Temizle_Click);
            // 
            // BtnSehirTemizle
            // 
            this.BtnSehirTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSehirTemizle.BackgroundImage")));
            this.BtnSehirTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSehirTemizle.Location = new System.Drawing.Point(396, 198);
            this.BtnSehirTemizle.Name = "BtnSehirTemizle";
            this.BtnSehirTemizle.Size = new System.Drawing.Size(23, 23);
            this.BtnSehirTemizle.TabIndex = 14;
            this.BtnSehirTemizle.UseVisualStyleBackColor = true;
            this.BtnSehirTemizle.Click += new System.EventHandler(this.BtnSehirTemizle_Click);
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(913, 561);
            this.Controls.Add(this.ScDoktor);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label1);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.Load += new System.EventHandler(this.DoktorGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScDoktor.Panel1.ResumeLayout(false);
            this.ScDoktor.Panel1.PerformLayout();
            this.ScDoktor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScDoktor)).EndInit();
            this.ScDoktor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDoktorBul;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox txtVergiNo;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RichTextBox txtMuayenehane;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.TextBox txtDAdi;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.ComboBox txtHastane1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer ScDoktor;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefon2;
        private System.Windows.Forms.ComboBox txtHastane3;
        private System.Windows.Forms.ComboBox txtHastane2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtGsm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txtUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DateTimePicker txtDTarih;
        private System.Windows.Forms.Button BtnDetayGoster;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.Button BtnHastane1Temizle;
        private System.Windows.Forms.Button BtnSehirTemizle;
        private System.Windows.Forms.Button BtnHastane3Temizle;
        private System.Windows.Forms.Button BtnHastane2Temizle;
        private System.Windows.Forms.Button BtnUnvanTemizle;
    }
}