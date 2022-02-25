namespace IEA_ErpProject
{
    partial class AnaSayfa
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
            this.tabPGenel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.TvMenu = new System.Windows.Forms.TreeView();
            this.BtnUrunGiris = new System.Windows.Forms.Button();
            this.BtnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlSolUst = new System.Windows.Forms.Panel();
            this.btnSolUstCollapse = new System.Windows.Forms.Button();
            this.lblSolUstMenu = new System.Windows.Forms.Label();
            this.btnSolUstAra = new System.Windows.Forms.Button();
            this.txtSolUstAra = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.BtnStok = new System.Windows.Forms.Button();
            this.tabPGenel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.pnlSolUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPGenel
            // 
            this.tabPGenel.Controls.Add(this.tabPage1);
            this.tabPGenel.Controls.Add(this.tabPage2);
            this.tabPGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPGenel.Location = new System.Drawing.Point(0, 0);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.SelectedIndex = 0;
            this.tabPGenel.Size = new System.Drawing.Size(1398, 132);
            this.tabPGenel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.BtnKapat);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1390, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit1;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Location = new System.Drawing.Point(1307, 19);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(64, 64);
            this.BtnKapat.TabIndex = 12;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1390, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yonetim";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Pink;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 132);
            this.splitter1.Name = "splitter1";
            this.splitter1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter1.Size = new System.Drawing.Size(1398, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.Pink;
            this.pnlSol.Controls.Add(this.scMenu);
            this.pnlSol.Controls.Add(this.pnlSolUst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 135);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(337, 539);
            this.pnlSol.TabIndex = 2;
            // 
            // scMenu
            // 
            this.scMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 77);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.BackColor = System.Drawing.Color.Pink;
            this.scMenu.Panel1.Controls.Add(this.TvMenu);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.BackColor = System.Drawing.Color.LightPink;
            this.scMenu.Panel2.Controls.Add(this.BtnStok);
            this.scMenu.Panel2.Controls.Add(this.BtnUrunGiris);
            this.scMenu.Panel2.Controls.Add(this.BtnBilgiGiris);
            this.scMenu.Size = new System.Drawing.Size(337, 462);
            this.scMenu.SplitterDistance = 208;
            this.scMenu.TabIndex = 4;
            // 
            // TvMenu
            // 
            this.TvMenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.TvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TvMenu.ForeColor = System.Drawing.Color.DimGray;
            this.TvMenu.Location = new System.Drawing.Point(0, 0);
            this.TvMenu.Name = "TvMenu";
            this.TvMenu.Size = new System.Drawing.Size(333, 204);
            this.TvMenu.TabIndex = 0;
            this.TvMenu.DoubleClick += new System.EventHandler(this.TvMenu_DoubleClick);
            // 
            // BtnUrunGiris
            // 
            this.BtnUrunGiris.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnUrunGiris.ForeColor = System.Drawing.Color.DimGray;
            this.BtnUrunGiris.Location = new System.Drawing.Point(94, 17);
            this.BtnUrunGiris.Name = "BtnUrunGiris";
            this.BtnUrunGiris.Size = new System.Drawing.Size(74, 56);
            this.BtnUrunGiris.TabIndex = 1;
            this.BtnUrunGiris.Text = "Urun Islemleri";
            this.BtnUrunGiris.UseVisualStyleBackColor = false;
            this.BtnUrunGiris.Click += new System.EventHandler(this.BtnUrunGiris_Click);
            // 
            // BtnBilgiGiris
            // 
            this.BtnBilgiGiris.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnBilgiGiris.ForeColor = System.Drawing.Color.DimGray;
            this.BtnBilgiGiris.Location = new System.Drawing.Point(13, 17);
            this.BtnBilgiGiris.Name = "BtnBilgiGiris";
            this.BtnBilgiGiris.Size = new System.Drawing.Size(75, 56);
            this.BtnBilgiGiris.TabIndex = 0;
            this.BtnBilgiGiris.Text = "Bilgi Giris Islemleri";
            this.BtnBilgiGiris.UseVisualStyleBackColor = false;
            this.BtnBilgiGiris.Click += new System.EventHandler(this.BtnBilgiGiris_Click);
            // 
            // pnlSolUst
            // 
            this.pnlSolUst.BackColor = System.Drawing.Color.LightPink;
            this.pnlSolUst.Controls.Add(this.btnSolUstCollapse);
            this.pnlSolUst.Controls.Add(this.lblSolUstMenu);
            this.pnlSolUst.Controls.Add(this.btnSolUstAra);
            this.pnlSolUst.Controls.Add(this.txtSolUstAra);
            this.pnlSolUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolUst.Location = new System.Drawing.Point(0, 0);
            this.pnlSolUst.Name = "pnlSolUst";
            this.pnlSolUst.Size = new System.Drawing.Size(337, 77);
            this.pnlSolUst.TabIndex = 4;
            // 
            // btnSolUstCollapse
            // 
            this.btnSolUstCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstCollapse.BackgroundImage = global::IEA_ErpProject.Properties.Resources.rightleft;
            this.btnSolUstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstCollapse.Location = new System.Drawing.Point(304, 43);
            this.btnSolUstCollapse.Name = "btnSolUstCollapse";
            this.btnSolUstCollapse.Size = new System.Drawing.Size(25, 25);
            this.btnSolUstCollapse.TabIndex = 3;
            this.btnSolUstCollapse.UseVisualStyleBackColor = true;
            // 
            // lblSolUstMenu
            // 
            this.lblSolUstMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolUstMenu.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSolUstMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolUstMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSolUstMenu.ForeColor = System.Drawing.Color.DimGray;
            this.lblSolUstMenu.Location = new System.Drawing.Point(15, 44);
            this.lblSolUstMenu.Name = "lblSolUstMenu";
            this.lblSolUstMenu.Size = new System.Drawing.Size(283, 23);
            this.lblSolUstMenu.TabIndex = 2;
            this.lblSolUstMenu.Text = "****";
            this.lblSolUstMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolUstAra
            // 
            this.btnSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstAra.AutoSize = true;
            this.btnSolUstAra.BackgroundImage = global::IEA_ErpProject.Properties.Resources.searchicon;
            this.btnSolUstAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstAra.Location = new System.Drawing.Point(304, 8);
            this.btnSolUstAra.Name = "btnSolUstAra";
            this.btnSolUstAra.Size = new System.Drawing.Size(25, 25);
            this.btnSolUstAra.TabIndex = 1;
            this.btnSolUstAra.UseVisualStyleBackColor = true;
            // 
            // txtSolUstAra
            // 
            this.txtSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolUstAra.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSolUstAra.ForeColor = System.Drawing.Color.DimGray;
            this.txtSolUstAra.Location = new System.Drawing.Point(15, 8);
            this.txtSolUstAra.Name = "txtSolUstAra";
            this.txtSolUstAra.Size = new System.Drawing.Size(283, 20);
            this.txtSolUstAra.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Pink;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(337, 135);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 539);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // BtnStok
            // 
            this.BtnStok.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnStok.ForeColor = System.Drawing.Color.DimGray;
            this.BtnStok.Location = new System.Drawing.Point(174, 17);
            this.BtnStok.Name = "BtnStok";
            this.BtnStok.Size = new System.Drawing.Size(74, 56);
            this.BtnStok.TabIndex = 1;
            this.BtnStok.Text = "Stok Islemleri";
            this.BtnStok.UseVisualStyleBackColor = false;
            this.BtnStok.Click += new System.EventHandler(this.BtnStok_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1398, 674);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPGenel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabPGenel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.pnlSolUst.ResumeLayout(false);
            this.pnlSolUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPGenel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlSolUst;
        private System.Windows.Forms.Button btnSolUstAra;
        private System.Windows.Forms.TextBox txtSolUstAra;
        private System.Windows.Forms.Label lblSolUstMenu;
        private System.Windows.Forms.Button btnSolUstCollapse;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.TreeView TvMenu;
        private System.Windows.Forms.Button BtnBilgiGiris;
        private System.Windows.Forms.Button BtnUrunGiris;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Button BtnStok;
    }
}

