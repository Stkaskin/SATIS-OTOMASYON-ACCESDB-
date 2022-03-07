namespace Birlestirme
{
    partial class urunislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunislem));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yenikayit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listeurun = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(853, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Stoktaki Çeşit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(20)));
            this.label7.Location = new System.Drawing.Point(577, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Stok Kodu */ Ürün Adı*";
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(563, 74);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(177, 20);
            this.arama.TabIndex = 33;
            this.arama.TextChanged += new System.EventHandler(this.arama_TextChanged);
            this.arama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arama_KeyPress);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // yenikayit
            // 
            this.yenikayit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yenikayit.BackgroundImage")));
            this.yenikayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yenikayit.Location = new System.Drawing.Point(1067, 233);
            this.yenikayit.Name = "yenikayit";
            this.yenikayit.Size = new System.Drawing.Size(82, 42);
            this.yenikayit.TabIndex = 67;
            this.yenikayit.Text = "Yeni Ürün Gir";
            this.yenikayit.UseVisualStyleBackColor = true;
            this.yenikayit.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.BackgroundImage = global::Birlestirme.Properties.Resources.button1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1067, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 66;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkRed;
            this.silbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("silbutton.BackgroundImage")));
            this.silbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.silbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silbutton.Location = new System.Drawing.Point(1067, 324);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(82, 37);
            this.silbutton.TabIndex = 55;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.Transparent;
            this.yenile.Location = new System.Drawing.Point(964, 515);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(43, 29);
            this.yenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yenile.TabIndex = 54;
            this.yenile.TabStop = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 69;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // listeurun
            // 
            this.listeurun.AllowDrop = true;
            this.listeurun.AllowUserToAddRows = false;
            this.listeurun.AllowUserToDeleteRows = false;
            this.listeurun.AllowUserToOrderColumns = true;
            this.listeurun.AllowUserToResizeRows = false;
            this.listeurun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeurun.BackgroundColor = System.Drawing.Color.White;
            this.listeurun.Location = new System.Drawing.Point(150, 112);
            this.listeurun.MultiSelect = false;
            this.listeurun.Name = "listeurun";
            this.listeurun.ReadOnly = true;
            this.listeurun.RowHeadersVisible = false;
            this.listeurun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeurun.Size = new System.Drawing.Size(900, 397);
            this.listeurun.TabIndex = 59;
            this.listeurun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listeurun_CellDoubleClick);
            this.listeurun.SelectionChanged += new System.EventHandler(this.listeurun_Click);
            this.listeurun.Sorted += new System.EventHandler(this.listeurun_Sorted);
            this.listeurun.Click += new System.EventHandler(this.listeurun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "0";
            // 
            // urunislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1370, 728);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.yenikayit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.listeurun);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arama);
            this.DoubleBuffered = true;
            this.Name = "urunislem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yenile)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeurun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.PictureBox yenile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox arama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button yenikayit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView listeurun;
        private System.Windows.Forms.Label label1;
    }
}