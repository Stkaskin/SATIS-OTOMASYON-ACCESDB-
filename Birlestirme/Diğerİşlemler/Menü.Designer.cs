namespace Birlestirme
{
    partial class Menü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menü));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iŞLEMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üRÜNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cagirilanform = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iŞLEMLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1300, 29);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // iŞLEMLERToolStripMenuItem
            // 
            this.iŞLEMLERToolStripMenuItem.AutoSize = false;
            this.iŞLEMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üRÜNToolStripMenuItem,
            this.pERSONELToolStripMenuItem,
            this.satışToolStripMenuItem1,
            this.ödemeYapToolStripMenuItem});
            this.iŞLEMLERToolStripMenuItem.Name = "iŞLEMLERToolStripMenuItem";
            this.iŞLEMLERToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.iŞLEMLERToolStripMenuItem.Text = "İŞLEMLER";
            // 
            // üRÜNToolStripMenuItem
            // 
            this.üRÜNToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("üRÜNToolStripMenuItem.Image")));
            this.üRÜNToolStripMenuItem.Name = "üRÜNToolStripMenuItem";
            this.üRÜNToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.üRÜNToolStripMenuItem.Text = "ÜRÜN";
            this.üRÜNToolStripMenuItem.Click += new System.EventHandler(this.üRÜNToolStripMenuItem_Click);
            // 
            // pERSONELToolStripMenuItem
            // 
            this.pERSONELToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pERSONELToolStripMenuItem.Image")));
            this.pERSONELToolStripMenuItem.Name = "pERSONELToolStripMenuItem";
            this.pERSONELToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pERSONELToolStripMenuItem.Text = "Bayi/Müşteri";
            this.pERSONELToolStripMenuItem.Click += new System.EventHandler(this.pERSONELToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem1
            // 
            this.satışToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("satışToolStripMenuItem1.Image")));
            this.satışToolStripMenuItem1.Name = "satışToolStripMenuItem1";
            this.satışToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.satışToolStripMenuItem1.Text = "Satış";
            this.satışToolStripMenuItem1.Click += new System.EventHandler(this.satışToolStripMenuItem1_Click);
            // 
            // ödemeYapToolStripMenuItem
            // 
            this.ödemeYapToolStripMenuItem.Name = "ödemeYapToolStripMenuItem";
            this.ödemeYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ödemeYapToolStripMenuItem.Text = "Ödeme Yap";
            this.ödemeYapToolStripMenuItem.Click += new System.EventHandler(this.ödemeYapToolStripMenuItem_Click);
            // 
            // cagirilanform
            // 
            this.cagirilanform.BackColor = System.Drawing.Color.White;
            this.cagirilanform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cagirilanform.BackgroundImage")));
            this.cagirilanform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cagirilanform.Location = new System.Drawing.Point(0, 32);
            this.cagirilanform.Name = "cagirilanform";
            this.cagirilanform.Size = new System.Drawing.Size(1268, 661);
            this.cagirilanform.TabIndex = 79;
            this.cagirilanform.VisibleChanged += new System.EventHandler(this.cagirilanform_VisibleChanged);
            this.cagirilanform.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.cagirilanform_ControlAdded);
            this.cagirilanform.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.cagirilanform_ControlRemoved);
            this.cagirilanform.Paint += new System.Windows.Forms.PaintEventHandler(this.cagirilanform_Paint);
            // 
            // Menü
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1300, 728);
            this.Controls.Add(this.cagirilanform);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menü";
            this.ShowIcon = false;
            this.Text = "Sirket Takip Demo V.0.01";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menü_FormClosing);
            this.Load += new System.EventHandler(this.Menü_Load);
            this.VisibleChanged += new System.EventHandler(this.Menü_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem iŞLEMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üRÜNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel cagirilanform;
        private System.Windows.Forms.ToolStripMenuItem ödemeYapToolStripMenuItem;
    }
}