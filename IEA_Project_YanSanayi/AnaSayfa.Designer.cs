namespace IEA_Project_YanSanayi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TvMenu = new System.Windows.Forms.TreeView();
            this.BtnUrunGiris = new System.Windows.Forms.Button();
            this.BtnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlSolUst = new System.Windows.Forms.Panel();
            this.lblSolUstMenu = new System.Windows.Forms.Label();
            this.txtSolUstAra = new System.Windows.Forms.TextBox();
            this.BtnSolUstCollapse = new System.Windows.Forms.Button();
            this.BtnSolUstSearch = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1.SuspendLayout();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSolUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1187, 106);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1179, 80);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1179, 80);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 106);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1187, 5);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.splitContainer1);
            this.pnlSol.Controls.Add(this.pnlSolUst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 111);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(296, 430);
            this.pnlSol.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TvMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel2.Controls.Add(this.BtnUrunGiris);
            this.splitContainer1.Panel2.Controls.Add(this.BtnBilgiGiris);
            this.splitContainer1.Size = new System.Drawing.Size(296, 330);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.TabIndex = 5;
            // 
            // TvMenu
            // 
            this.TvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvMenu.Location = new System.Drawing.Point(0, 0);
            this.TvMenu.Name = "TvMenu";
            this.TvMenu.Size = new System.Drawing.Size(296, 176);
            this.TvMenu.TabIndex = 0;
            this.TvMenu.DoubleClick += new System.EventHandler(this.TvMenu_DoubleClick);
            // 
            // BtnUrunGiris
            // 
            this.BtnUrunGiris.Location = new System.Drawing.Point(103, 13);
            this.BtnUrunGiris.Name = "BtnUrunGiris";
            this.BtnUrunGiris.Size = new System.Drawing.Size(75, 52);
            this.BtnUrunGiris.TabIndex = 0;
            this.BtnUrunGiris.Text = "Urun Islemleri";
            this.BtnUrunGiris.UseVisualStyleBackColor = true;
            this.BtnUrunGiris.Click += new System.EventHandler(this.BtnUrunGiris_Click);
            // 
            // BtnBilgiGiris
            // 
            this.BtnBilgiGiris.Location = new System.Drawing.Point(12, 13);
            this.BtnBilgiGiris.Name = "BtnBilgiGiris";
            this.BtnBilgiGiris.Size = new System.Drawing.Size(75, 52);
            this.BtnBilgiGiris.TabIndex = 0;
            this.BtnBilgiGiris.Text = "Bilgi Giris Islemleri";
            this.BtnBilgiGiris.UseVisualStyleBackColor = true;
            this.BtnBilgiGiris.Click += new System.EventHandler(this.BtnBilgiGiris_Click);
            // 
            // pnlSolUst
            // 
            this.pnlSolUst.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSolUst.Controls.Add(this.lblSolUstMenu);
            this.pnlSolUst.Controls.Add(this.txtSolUstAra);
            this.pnlSolUst.Controls.Add(this.BtnSolUstCollapse);
            this.pnlSolUst.Controls.Add(this.BtnSolUstSearch);
            this.pnlSolUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolUst.Location = new System.Drawing.Point(0, 0);
            this.pnlSolUst.Name = "pnlSolUst";
            this.pnlSolUst.Size = new System.Drawing.Size(296, 100);
            this.pnlSolUst.TabIndex = 4;
            // 
            // lblSolUstMenu
            // 
            this.lblSolUstMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSolUstMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolUstMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSolUstMenu.Location = new System.Drawing.Point(4, 64);
            this.lblSolUstMenu.Name = "lblSolUstMenu";
            this.lblSolUstMenu.Size = new System.Drawing.Size(248, 23);
            this.lblSolUstMenu.TabIndex = 3;
            this.lblSolUstMenu.Text = "****";
            this.lblSolUstMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSolUstAra
            // 
            this.txtSolUstAra.Location = new System.Drawing.Point(4, 18);
            this.txtSolUstAra.Name = "txtSolUstAra";
            this.txtSolUstAra.Size = new System.Drawing.Size(248, 20);
            this.txtSolUstAra.TabIndex = 2;
            // 
            // BtnSolUstCollapse
            // 
            this.BtnSolUstCollapse.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.rightleft;
            this.BtnSolUstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSolUstCollapse.Location = new System.Drawing.Point(267, 66);
            this.BtnSolUstCollapse.Name = "BtnSolUstCollapse";
            this.BtnSolUstCollapse.Size = new System.Drawing.Size(23, 23);
            this.BtnSolUstCollapse.TabIndex = 1;
            this.BtnSolUstCollapse.UseVisualStyleBackColor = true;
            // 
            // BtnSolUstSearch
            // 
            this.BtnSolUstSearch.BackgroundImage = global::IEA_Project_YanSanayi.Properties.Resources.searchicon;
            this.BtnSolUstSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSolUstSearch.Location = new System.Drawing.Point(267, 18);
            this.BtnSolUstSearch.Name = "BtnSolUstSearch";
            this.BtnSolUstSearch.Size = new System.Drawing.Size(23, 23);
            this.BtnSolUstSearch.TabIndex = 0;
            this.BtnSolUstSearch.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter2.Location = new System.Drawing.Point(296, 111);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 430);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 541);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSolUst.ResumeLayout(false);
            this.pnlSolUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlSolUst;
        private System.Windows.Forms.Label lblSolUstMenu;
        private System.Windows.Forms.TextBox txtSolUstAra;
        private System.Windows.Forms.Button BtnSolUstCollapse;
        private System.Windows.Forms.Button BtnSolUstSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TvMenu;
        private System.Windows.Forms.Button BtnUrunGiris;
        private System.Windows.Forms.Button BtnBilgiGiris;
    }
}

