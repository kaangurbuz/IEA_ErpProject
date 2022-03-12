namespace IEA_ErpProject.KonsinyeIslemleri
{
    partial class LotBul
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Liste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Liste.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LotSeri,
            this.Barkod,
            this.Adet,
            this.Uts,
            this.UTarih,
            this.SKTarih});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Liste.DefaultCellStyle = dataGridViewCellStyle2;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            this.Liste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Liste.Size = new System.Drawing.Size(628, 281);
            this.Liste.TabIndex = 2;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.Name = "LotSeri";
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
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
            this.UTarih.HeaderText = "UTarih";
            this.UTarih.Name = "UTarih";
            this.UTarih.Visible = false;
            // 
            // SKTarih
            // 
            this.SKTarih.HeaderText = "SKTarih";
            this.SKTarih.Name = "SKTarih";
            this.SKTarih.Visible = false;
            // 
            // LotBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 281);
            this.Controls.Add(this.Liste);
            this.Name = "LotBul";
            this.Text = "LotBul";
            this.Load += new System.EventHandler(this.LotBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarih;
    }
}