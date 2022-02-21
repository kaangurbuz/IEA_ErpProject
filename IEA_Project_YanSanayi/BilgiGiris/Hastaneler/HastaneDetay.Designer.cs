namespace IEA_Project_YanSanayi.BilgiGiris.Hastaneler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetayEkle = new System.Windows.Forms.Panel();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartman = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtGsm = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.lblHastaneAdi = new System.Windows.Forms.Label();
            this.lblHastaneId = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetayEkle.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(800, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hastane Detay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetayEkle
            // 
            this.pnlDetayEkle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlDetayEkle.Controls.Add(this.txtYetkili);
            this.pnlDetayEkle.Controls.Add(this.label2);
            this.pnlDetayEkle.Controls.Add(this.label3);
            this.pnlDetayEkle.Controls.Add(this.label4);
            this.pnlDetayEkle.Controls.Add(this.label5);
            this.pnlDetayEkle.Controls.Add(this.label6);
            this.pnlDetayEkle.Controls.Add(this.txtDepartman);
            this.pnlDetayEkle.Controls.Add(this.txtTel);
            this.pnlDetayEkle.Controls.Add(this.txtGsm);
            this.pnlDetayEkle.Controls.Add(this.txtEmail);
            this.pnlDetayEkle.Controls.Add(this.BtnEkle);
            this.pnlDetayEkle.Location = new System.Drawing.Point(36, 129);
            this.pnlDetayEkle.Name = "pnlDetayEkle";
            this.pnlDetayEkle.Size = new System.Drawing.Size(715, 128);
            this.pnlDetayEkle.TabIndex = 6;
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(3, 56);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(100, 20);
            this.txtYetkili.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yetkili Adi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(117, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Departman";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(263, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(384, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "GSM";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(506, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txtDepartman
            // 
            this.txtDepartman.FormattingEnabled = true;
            this.txtDepartman.Location = new System.Drawing.Point(120, 56);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(121, 21);
            this.txtDepartman.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(263, 57);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 2;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(384, 57);
            this.txtGsm.Mask = "(999) 000-0000";
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 20);
            this.txtGsm.TabIndex = 3;
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
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHastaneAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHastaneAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHastaneAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHastaneAdi.Location = new System.Drawing.Point(101, 90);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(257, 23);
            this.lblHastaneAdi.TabIndex = 7;
            this.lblHastaneAdi.Text = "***";
            this.lblHastaneAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHastaneId
            // 
            this.lblHastaneId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHastaneId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHastaneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblHastaneId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHastaneId.Location = new System.Drawing.Point(35, 90);
            this.lblHastaneId.Name = "lblHastaneId";
            this.lblHastaneId.Size = new System.Drawing.Size(60, 23);
            this.lblHastaneId.TabIndex = 8;
            this.lblHastaneId.Text = "***";
            this.lblHastaneId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.BackgroundColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle5;
            this.Liste.Location = new System.Drawing.Point(39, 281);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Liste.Size = new System.Drawing.Size(715, 130);
            this.Liste.TabIndex = 11;
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
            // HastaneDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlDetayEkle);
            this.Controls.Add(this.lblHastaneAdi);
            this.Controls.Add(this.lblHastaneId);
            this.Controls.Add(this.label1);
            this.Name = "HastaneDetay";
            this.Text = "HastaneDetay";
            this.Load += new System.EventHandler(this.HastaneDetay_Load);
            this.pnlDetayEkle.ResumeLayout(false);
            this.pnlDetayEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDetayEkle;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtDepartman;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtGsm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button BtnEkle;
        public System.Windows.Forms.Label lblHastaneAdi;
        public System.Windows.Forms.Label lblHastaneId;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}