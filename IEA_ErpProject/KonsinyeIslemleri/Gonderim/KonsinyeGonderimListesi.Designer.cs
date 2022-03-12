namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    partial class KonsinyeGonderimListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtGirisAra = new System.Windows.Forms.TextBox();
            this.BtnGonderimBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderimTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AciklaTr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gtarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderimmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.LightPink;
            this.pnlUst.Controls.Add(this.txtGirisAra);
            this.pnlUst.Controls.Add(this.BtnGonderimBul);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(862, 100);
            this.pnlUst.TabIndex = 5;
            // 
            // txtGirisAra
            // 
            this.txtGirisAra.Location = new System.Drawing.Point(602, 40);
            this.txtGirisAra.Name = "txtGirisAra";
            this.txtGirisAra.Size = new System.Drawing.Size(148, 20);
            this.txtGirisAra.TabIndex = 3;
            this.txtGirisAra.TextChanged += new System.EventHandler(this.txtGirisAra_TextChanged);
            // 
            // BtnGonderimBul
            // 
            this.BtnGonderimBul.Location = new System.Drawing.Point(512, 32);
            this.BtnGonderimBul.Name = "BtnGonderimBul";
            this.BtnGonderimBul.Size = new System.Drawing.Size(75, 34);
            this.BtnGonderimBul.TabIndex = 2;
            this.BtnGonderimBul.Text = "Gonderim Bul";
            this.BtnGonderimBul.UseVisualStyleBackColor = true;
            this.BtnGonderimBul.Click += new System.EventHandler(this.BtnGonderimBul_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konsinye Gönderim Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.Name = "Sira";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CariTur
            // 
            this.CariTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTur.HeaderText = "Cari Tür";
            this.CariTur.Name = "CariTur";
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // GonderimTarih
            // 
            this.GonderimTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.GonderimTarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.GonderimTarih.HeaderText = "Gönderim Tarih";
            this.GonderimTarih.Name = "GonderimTarih";
            // 
            // AciklaTr
            // 
            this.AciklaTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AciklaTr.HeaderText = "Açıklama";
            this.AciklaTr.Name = "AciklaTr";
            // 
            // Liste
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Adi,
            this.TipAdi,
            this.Gtarih,
            this.Aciklama,
            this.GonderimmId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 100);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Liste.Size = new System.Drawing.Size(862, 403);
            this.Liste.TabIndex = 6;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Sira";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 41;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Cari Tür";
            this.Adi.Name = "Adi";
            // 
            // TipAdi
            // 
            this.TipAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipAdi.HeaderText = "Cari Adi";
            this.TipAdi.Name = "TipAdi";
            this.TipAdi.Width = 50;
            // 
            // Gtarih
            // 
            this.Gtarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gtarih.HeaderText = "Gonderim Tarihi";
            this.Gtarih.Name = "Gtarih";
            this.Gtarih.Width = 97;
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Width = 75;
            // 
            // GonderimmId
            // 
            this.GonderimmId.HeaderText = "GonderimId";
            this.GonderimmId.Name = "GonderimmId";
            // 
            // KonsinyeGonderimListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 503);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "KonsinyeGonderimListesi";
            this.Text = "KonsinyeGonderimListesi";
            this.Load += new System.EventHandler(this.KonsinyeGirisListesi_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtGirisAra;
        private System.Windows.Forms.Button BtnGonderimBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderimTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn AciklaTr;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gtarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderimmId;
    }
}