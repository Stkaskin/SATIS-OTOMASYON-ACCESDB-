namespace WindowsFormsApplication14
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Fiyatc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.temmizle = new System.Windows.Forms.Button();
            this.duzenlebutton = new System.Windows.Forms.Button();
            this.eklebutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ek = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boyut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.turbilgi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stokkodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stokbilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.TextBox();
            this.arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Help;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Location = new System.Drawing.Point(651, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 63;
            this.button3.Text = "Bilgi/Yardım";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Gothic", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(37, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 27);
            this.label12.TabIndex = 61;
            this.label12.Text = "Yetki : Admin";
            // 
            // Fiyatc
            // 
            this.Fiyatc.HeaderText = "Fiyat";
            this.Fiyatc.Name = "Fiyatc";
            this.Fiyatc.ReadOnly = true;
            this.Fiyatc.Width = 80;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Ürün Adı";
            this.Urun.Name = "Urun";
            this.Urun.ReadOnly = true;
            this.Urun.Width = 240;
            // 
            // Kodu
            // 
            this.Kodu.HeaderText = "Kodu";
            this.Kodu.Name = "Kodu";
            this.Kodu.ReadOnly = true;
            this.Kodu.Width = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Gothic", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.label14.ForeColor = System.Drawing.Color.DarkCyan;
            this.label14.Location = new System.Drawing.Point(19, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 32);
            this.label14.TabIndex = 62;
            this.label14.Text = "Yetkili: BY Admin";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 60;
            this.button2.Text = "Özel Yetki Paneli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kodu,
            this.Urun,
            this.Fiyatc});
            this.dataGridView1.Location = new System.Drawing.Point(322, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 214);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "     ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Stoktaki Çeşit:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Help;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(633, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Bilgi/Yardım";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.DarkRed;
            this.silbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.silbutton.Enabled = false;
            this.silbutton.Location = new System.Drawing.Point(219, 398);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(75, 32);
            this.silbutton.TabIndex = 55;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(665, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // temmizle
            // 
            this.temmizle.BackColor = System.Drawing.Color.Snow;
            this.temmizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temmizle.Enabled = false;
            this.temmizle.Location = new System.Drawing.Point(304, 398);
            this.temmizle.Name = "temmizle";
            this.temmizle.Size = new System.Drawing.Size(75, 32);
            this.temmizle.TabIndex = 53;
            this.temmizle.Text = "Temizle";
            this.temmizle.UseVisualStyleBackColor = false;
            this.temmizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // duzenlebutton
            // 
            this.duzenlebutton.BackColor = System.Drawing.Color.Peru;
            this.duzenlebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duzenlebutton.Enabled = false;
            this.duzenlebutton.Location = new System.Drawing.Point(138, 398);
            this.duzenlebutton.Name = "duzenlebutton";
            this.duzenlebutton.Size = new System.Drawing.Size(75, 32);
            this.duzenlebutton.TabIndex = 52;
            this.duzenlebutton.Text = "Düzenle";
            this.duzenlebutton.UseVisualStyleBackColor = false;
            this.duzenlebutton.Click += new System.EventHandler(this.duzenlebutton_Click);
            // 
            // eklebutton
            // 
            this.eklebutton.BackColor = System.Drawing.Color.LawnGreen;
            this.eklebutton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.eklebutton.Enabled = false;
            this.eklebutton.Location = new System.Drawing.Point(53, 398);
            this.eklebutton.Name = "eklebutton";
            this.eklebutton.Size = new System.Drawing.Size(75, 32);
            this.eklebutton.TabIndex = 51;
            this.eklebutton.Text = "EKLE";
            this.eklebutton.UseVisualStyleBackColor = false;
            this.eklebutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Ek:";
            // 
            // ek
            // 
            this.ek.Location = new System.Drawing.Point(608, 346);
            this.ek.Name = "ek";
            this.ek.Size = new System.Drawing.Size(100, 20);
            this.ek.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Fiyat :";
            // 
            // fiyat
            // 
            this.fiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fiyat.Location = new System.Drawing.Point(608, 317);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(100, 20);
            this.fiyat.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Urdu Typesetting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(20)));
            this.label7.Location = new System.Drawing.Point(29, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Stok Kodu */ Ürün Adı*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Boyut";
            // 
            // boyut
            // 
            this.boyut.Location = new System.Drawing.Point(450, 346);
            this.boyut.Name = "boyut";
            this.boyut.Size = new System.Drawing.Size(100, 20);
            this.boyut.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ağırlık";
            // 
            // agirlik
            // 
            this.agirlik.Location = new System.Drawing.Point(450, 317);
            this.agirlik.Name = "agirlik";
            this.agirlik.Size = new System.Drawing.Size(100, 20);
            this.agirlik.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tür:";
            // 
            // turbilgi
            // 
            this.turbilgi.Location = new System.Drawing.Point(283, 343);
            this.turbilgi.Name = "turbilgi";
            this.turbilgi.Size = new System.Drawing.Size(100, 20);
            this.turbilgi.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Stokkodu";
            // 
            // stokkodu
            // 
            this.stokkodu.Enabled = false;
            this.stokkodu.Location = new System.Drawing.Point(108, 320);
            this.stokkodu.Name = "stokkodu";
            this.stokkodu.Size = new System.Drawing.Size(100, 20);
            this.stokkodu.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Stok Bilgisi:";
            // 
            // stokbilgi
            // 
            this.stokbilgi.Location = new System.Drawing.Point(108, 343);
            this.stokbilgi.Name = "stokbilgi";
            this.stokbilgi.Size = new System.Drawing.Size(100, 20);
            this.stokbilgi.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ürün Adı :";
            // 
            // urunad
            // 
            this.urunad.Location = new System.Drawing.Point(283, 313);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(100, 20);
            this.urunad.TabIndex = 34;
            // 
            // arama
            // 
            this.arama.Location = new System.Drawing.Point(162, 51);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(100, 20);
            this.arama.TabIndex = 33;
            this.arama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(885, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.temmizle);
            this.Controls.Add(this.duzenlebutton);
            this.Controls.Add(this.eklebutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ek);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boyut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agirlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.turbilgi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stokkodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stokbilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunad);
            this.Controls.Add(this.arama);
            this.Name = "Form1";
            this.Text = "ÜRÜN İŞLEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyatc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button temmizle;
        private System.Windows.Forms.Button duzenlebutton;
        private System.Windows.Forms.Button eklebutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boyut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agirlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox turbilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stokkodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stokbilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunad;
        private System.Windows.Forms.TextBox arama;
    }
}

