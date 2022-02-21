namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    partial class HastaneDetay
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblHastaneId = new System.Windows.Forms.Label();
            this.lblHastaneAdi = new System.Windows.Forms.Label();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.ComboBox();
            this.txtGsm = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDetayEkle = new System.Windows.Forms.Panel();
            this.BtnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlDetayEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(913, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hastane Detay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHastaneId
            // 
            this.lblHastaneId.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblHastaneId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHastaneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHastaneId.ForeColor = System.Drawing.Color.DimGray;
            this.lblHastaneId.Location = new System.Drawing.Point(33, 72);
            this.lblHastaneId.Name = "lblHastaneId";
            this.lblHastaneId.Size = new System.Drawing.Size(60, 23);
            this.lblHastaneId.TabIndex = 5;
            this.lblHastaneId.Text = "***";
            this.lblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblHastaneAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHastaneAdi.ForeColor = System.Drawing.Color.DimGray;
            this.lblHastaneAdi.Location = new System.Drawing.Point(99, 72);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(257, 23);
            this.lblHastaneAdi.TabIndex = 5;
            this.lblHastaneAdi.Text = "***";
            this.lblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(3, 56);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(100, 20);
            this.txtYetkili.TabIndex = 0;
            // 
            // txtDepartman
            // 
            this.txtDepartman.FormattingEnabled = true;
            this.txtDepartman.Location = new System.Drawing.Point(120, 56);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(121, 21);
            this.txtDepartman.TabIndex = 1;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(384, 57);
            this.txtGsm.Mask = "(999) 000-0000";
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 20);
            this.txtGsm.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(263, 57);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(506, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(632, 56);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // Liste
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.GirisAdi,
            this.Yetkili,
            this.Departman,
            this.Telefon,
            this.Gsm,
            this.Email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle2;
            this.Liste.Location = new System.Drawing.Point(34, 268);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Size = new System.Drawing.Size(715, 281);
            this.Liste.TabIndex = 10;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            this.Sira.Width = 50;
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "GirisId";
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 61;
            // 
            // GirisAdi
            // 
            this.GirisAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdi.HeaderText = "GirisAdi";
            this.GirisAdi.Name = "GirisAdi";
            this.GirisAdi.Width = 67;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.Name = "Yetkili";
            // 
            // Departman
            // 
            this.Departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            this.Departman.Width = 84;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefon.HeaderText = "Tel";
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 47;
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
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yetkili Adi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(117, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Departman";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightPink;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(263, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightPink;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(384, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "GSM";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(506, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // pnlDetayEkle
            // 
            this.pnlDetayEkle.Controls.Add(this.txtYetkili);
            this.pnlDetayEkle.Controls.Add(this.label1);
            this.pnlDetayEkle.Controls.Add(this.label3);
            this.pnlDetayEkle.Controls.Add(this.label4);
            this.pnlDetayEkle.Controls.Add(this.label5);
            this.pnlDetayEkle.Controls.Add(this.label6);
            this.pnlDetayEkle.Controls.Add(this.txtDepartman);
            this.pnlDetayEkle.Controls.Add(this.txtTel);
            this.pnlDetayEkle.Controls.Add(this.txtGsm);
            this.pnlDetayEkle.Controls.Add(this.txtEmail);
            this.pnlDetayEkle.Controls.Add(this.BtnEkle);
            this.pnlDetayEkle.Location = new System.Drawing.Point(34, 111);
            this.pnlDetayEkle.Name = "pnlDetayEkle";
            this.pnlDetayEkle.Size = new System.Drawing.Size(715, 128);
            this.pnlDetayEkle.TabIndex = 0;
            // 
            // BtnKayit
            // 
            this.BtnKayit.Location = new System.Drawing.Point(795, 488);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(75, 61);
            this.BtnKayit.TabIndex = 11;
            this.BtnKayit.Text = "Kaydet";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // HastaneDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(913, 561);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.pnlDetayEkle);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.lblHastaneAdi);
            this.Controls.Add(this.lblHastaneId);
            this.Controls.Add(this.label2);
            this.Name = "HastaneDetay";
            this.Text = "HastaneDetay";
            this.Load += new System.EventHandler(this.HastaneDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlDetayEkle.ResumeLayout(false);
            this.pnlDetayEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblHastaneId;
        public System.Windows.Forms.Label lblHastaneAdi;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.ComboBox txtDepartman;
        private System.Windows.Forms.MaskedTextBox txtGsm;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDetayEkle;
        private System.Windows.Forms.Button BtnKayit;
    }
}