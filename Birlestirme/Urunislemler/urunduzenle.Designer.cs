namespace Birlestirme
{
    partial class urunduzenle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stokkodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.TextBox();
            this.temmizle = new System.Windows.Forms.Button();
            this.duzenlebutton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.yeniurunadi = new System.Windows.Forms.TextBox();
            this.Kodsabiti = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stokkodu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.urunad);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 326);
            this.panel1.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(421, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 67;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stokkodu";
            // 
            // stokkodu
            // 
            this.stokkodu.BackColor = System.Drawing.Color.AliceBlue;
            this.stokkodu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stokkodu.Enabled = false;
            this.stokkodu.Location = new System.Drawing.Point(89, 30);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(100, 20);
            this.stokkodu.TabIndex = 38;
            this.stokkodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Adı :";
            // 
            // urunad
            // 
            this.urunad.BackColor = System.Drawing.Color.AliceBlue;
            this.urunad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urunad.Enabled = false;
            this.urunad.Location = new System.Drawing.Point(89, 56);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(100, 20);
            this.urunad.TabIndex = 34;
            this.urunad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temmizle
            // 
            this.temmizle.BackColor = System.Drawing.Color.Snow;
            this.temmizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temmizle.Location = new System.Drawing.Point(96, 291);
            this.temmizle.Name = "temmizle";
            this.temmizle.Size = new System.Drawing.Size(75, 32);
            this.temmizle.TabIndex = 53;
            this.temmizle.Text = "Vazgeç";
            this.temmizle.UseVisualStyleBackColor = false;
            this.temmizle.Click += new System.EventHandler(this.temmizle_Click);
            // 
            // duzenlebutton
            // 
            this.duzenlebutton.BackColor = System.Drawing.Color.Peru;
            this.duzenlebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzenlebutton.Enabled = false;
            this.duzenlebutton.Location = new System.Drawing.Point(752, 328);
            this.duzenlebutton.Name = "duzenlebutton";
            this.duzenlebutton.Size = new System.Drawing.Size(75, 32);
            this.duzenlebutton.TabIndex = 52;
            this.duzenlebutton.Text = "Kaydet";
            this.duzenlebutton.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(572, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 66);
            this.label17.TabIndex = 67;
            this.label17.Text = "Değiştir         ===>";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            this.label17.MouseEnter += new System.EventHandler(this.label17_MouseEnter);
            this.label17.MouseLeave += new System.EventHandler(this.label17_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(80, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Yeni Ürün Adı :";
            // 
            // yeniurunadi
            // 
            this.yeniurunadi.BackColor = System.Drawing.Color.AliceBlue;
            this.yeniurunadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yeniurunadi.Location = new System.Drawing.Point(160, 47);
            this.yeniurunadi.Name = "yeniurunadi";
            this.yeniurunadi.Size = new System.Drawing.Size(100, 20);
            this.yeniurunadi.TabIndex = 36;
            this.yeniurunadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Kodsabiti
            // 
            this.Kodsabiti.BackColor = System.Drawing.Color.AliceBlue;
            this.Kodsabiti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kodsabiti.Enabled = false;
            this.Kodsabiti.Location = new System.Drawing.Point(161, 22);
            this.Kodsabiti.Name = "Kodsabiti";
            this.Kodsabiti.Size = new System.Drawing.Size(100, 20);
            this.Kodsabiti.TabIndex = 38;
            this.Kodsabiti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Değiştirilecek Ürün Stok Kodu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.temmizle);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.Kodsabiti);
            this.panel2.Controls.Add(this.yeniurunadi);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(752, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 326);
            this.panel2.TabIndex = 66;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(239, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 68;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // urunduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1184, 472);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.duzenlebutton);
            this.Name = "urunduzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunduzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.urunduzenle_FormClosing);
            this.Load += new System.EventHandler(this.urunduzenle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button temmizle;
        private System.Windows.Forms.Button duzenlebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox yeniurunadi;
        private System.Windows.Forms.TextBox Kodsabiti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox stokkodu;
        public System.Windows.Forms.TextBox urunad;
    }
}