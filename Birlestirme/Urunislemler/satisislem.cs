using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Birlestirme
{
    public partial class satisislem : Form
    {
        int stokkodunubul;
        int kod;
        int toplamtutar;
        int adet;
        public int ilkindextut;
        int saytime = 0;
        public string gecerlipersonel = "-1"; 
       public string tamkod,stokmiktari;
      
        bool yenisatis = true,butonlistegör=true;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        DataSet dsatis = new DataSet();
        BindingSource bsatis = new BindingSource();
        
      
        public int gelenmiktar;
       public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
       
        string tur, marka; int tutar;
        int endusukfiyat, enyuksekfiyat;

                
       
        public string urunismigönder, stokkodugönder,fiyatgönder;
        public satisislem()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            //önceden acık veritabanlarıyla ilişki keser
            musno.Location = label11.Location = new Point(7777,9999);
           
          
            verigönder();
            

            

         
            
            buttoncagir();
                
          
        }
       
        private void verigönder()
        {
            string seckomutu = "select urunkodu,urunadi,fiyat,adet,tutar from satis";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglanti);

            dsatis.Clear();
            da.Fill(dsatis, "satis");
            bsatis.DataSource = dsatis.Tables["satis"];
            dataGridView2.DataSource = bsatis;
            tutarhesapla();
        }

       
       
        string ürünismi = "";
      
       
        
        
      
       
        private void btnn(object sender, EventArgs e)
        {
           vericekgönder(((Button)sender).Name);
        }
        private void vericekgönder (string gecenkod)
        {
           
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = "Select *from Ürün where Urunkodu=@butonkod";
            komut.Parameters.AddWithValue("@butonkod", gecenkod);
            OleDbDataReader oku = komut.ExecuteReader();
            //

            while (oku.Read())
            {
          
               
                stokkodugönder = oku["Urunkodu"].ToString();
              
                urunismigönder = oku["Ürün"].ToString();
              
                tutar = 0;
                
                tutarhesapla();

            }
           
         
          
                
                 
             
                Satıssoru satissorum = new Satıssoru();
                satissorum.textBox1.Text = fiyatgönder;
                satissorum.urunlab.Text = urunismigönder;
               
                satissorum.kodtext.Text = stokkodugönder;
                satissorum.comboBox1.SelectedValue = musno.Text;
                satissorum.ShowDialog();
                baglanti.Close();
                baglanti.Open();
                verigönder();
                timer1.Enabled = true;
            
           
        
         
        }
     
        
        private void tutarhesapla()
        {
            if (dataGridView2.Rows.Count > 0)
            {
                button1.Enabled = button2.Enabled = button4.Enabled = true;
                OleDbCommand tutarhesap = new OleDbCommand("SELECT Sum(tutar)FROM satis", baglanti);
                OleDbDataReader oku = tutarhesap.ExecuteReader();

                if (oku.Read())
                {
                    toplamtutar = Convert.ToInt32(oku[0]);
                    label2.Text = toplamtutar.ToString();
                }
                else
                {
                    label2.Text = "0";
                }
               
            }
            else { tutar = 0;  button1.Enabled =button2.Enabled=button4.Enabled= false; }

            label2.Text = toplamtutar.ToString();
        }
        private void kodbul()
        {

            if (yenisatis)
            {
            
                for (int i = 1; ; i++)
           
                {

                Random yeni = new Random();
                kod = yeni.Next(1000, 10000);
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
                kom.CommandText = "Select * From satislar where satiskodu=@kod";
                kom.Parameters.AddWithValue("@kod",kod);
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {

                }
                else { yenisatis = false; break; }
           
                }


            }
               
            
            
        }
       
   
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Onayla";
                MessageBoxManager.No = "İptal Et";
              
                DialogResult cikissoru = new DialogResult();
                cikissoru = MessageBox.Show(gecerlikisi.Text+" Satışlar Eklensin Mi?", "Satış Onaylama", MessageBoxButtons.YesNo);
                if (cikissoru == DialogResult.Yes)
                {
                    decimal eskibak = 0, yeniborc = 0;

                    OleDbCommand komut = new OleDbCommand();
                    komut.Connection = baglanti;
                    kodbul();//SATİSRAPOR TABLOSUNA VE SATİSLAR TABLOSUNA SATİS TABLOSUNDAN VERİ CEKEREK EKLİYOR.
                    komut = new OleDbCommand("SELECT musteri.borc, Sum(satis.tutar) AS Toplatutar FROM musteri, satis GROUP BY musteri.borc, musteri.musterikod HAVING (((musteri.musterikod)=@kod))", baglanti);
                    komut.Parameters.AddWithValue("@kod", musno.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        eskibak = Convert.ToDecimal(oku["borc"]);
                        yeniborc = Convert.ToDecimal(oku["Toplatutar"]);
                     
                    }
                    komut = new OleDbCommand("INSERT INTO satisrapor ( satiskodu,tutar,zaman,musteri,islemtipi,eskibakiye,yenibakiye) SELECT satis.satiskodu, Sum(satis.tutar),@zam,@musterikodu,@islem,@eski,@yeni AS Toplatutar  FROM satis GROUP BY satis.satiskodu", baglanti);

                    komut.Parameters.AddWithValue("@zam", DateTime.Now.ToString());

                    komut.Parameters.AddWithValue("@musteri", musno.Text);

                    komut.Parameters.AddWithValue("@islem", "Satın Aldı");
                    komut.Parameters.AddWithValue("@eski", eskibak);
                    komut.Parameters.AddWithValue("@yeni", eskibak + yeniborc);
                  
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand("UPDATE musteri SET musteri.borc = @yeni WHERE (((musteri.musterikod)=@kod))", baglanti);//musteri borcu güncelle
                    komut.Parameters.AddWithValue("@yeni", eskibak + yeniborc);
                    komut.Parameters.AddWithValue("@kod", musno.Text);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand("INSERT INTO satislar (urunkodu,urunadi,satiskodu,fiyat,tutar,adet,musteri,zaman) SELECT urunkodu,urunadi,satiskodu,fiyat,tutar,adet,@musteri,@zam FROM satis", baglanti);

                    komut.Parameters.AddWithValue("@musteri", musno.Text);
                    komut.Parameters.AddWithValue("@zam", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                   

                    baglanti.Close();
                    baglanti.Open();
                    MessageBox.Show(gecerlikisi.Text + " \n Eski Bakiyesi=" + eskibak + " \n Alışveriş Tutarı=" + yeniborc + "\n Yeni Bakiyesi=" + (yeniborc + eskibak));
                    button2.PerformClick();
                    yenisatis = true;
                    label2.Text = "0";
                  
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            temizlegecicitablo();
           
        }
        private void temizlegecicitablo()
        {
            OleDbCommand silkomut = new OleDbCommand();
            silkomut.Connection = baglanti;
            silkomut.CommandText = "delete from satis";//sadece güncel satisları siler
            silkomut.ExecuteNonQuery();
            gecerlikisi.Text = "-";
            musno.Text = "-";
           
            verigönder();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (skodutut.Text != "")
            {
                OleDbCommand silkomut = new OleDbCommand();
                silkomut.Connection = baglanti;
                silkomut.CommandText = "delete from satis where urunkodu=@kod";//sadece güncel satislardaki belirli satisi siler
                silkomut.Parameters.AddWithValue("@text1", skodutut.Text);
                silkomut.ExecuteNonQuery();
                verigönder();
               
            }

        }
        
    
        private void butonn(Button btn)
        {
            tabPage1.Controls.Add(btn);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (filtrepanel.Visible) { filtrepanel.Visible = false;  }
            else { filtrepanel.Visible = true; }
            //visiblechanged event:
        }
        private void button6_Click(object sender, EventArgs e)
        {
         
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (butonlistegör)
            {

                butonlistegör = false;
              panel2.Visible = false;
               
              
            
                
                
            }
            else {  panel2.Visible = true;  butonlistegör = true; }
        
        }

        private void filtrepanel_VisibleChanged(object sender, EventArgs e)
        {
            if (!filtrepanel.Visible) filtrebutton.Text = "Filtrele";
            else { filtrebutton.Text = "Filtre Kapat"; /*markacombo.SelectedIndex = 0; turcombo.SelectedIndex = 0;*/ hScrollBar1.Value = 0; hScrollBar2.Value = 1000; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Location = hScrollBar1.Location;
            textBox2.Location = hScrollBar2.Location;

            if (hScrollBar1.Visible) { hScrollBar1.Visible = hScrollBar2.Visible = false; textBox1.Visible = textBox2.Visible = true; }
            else { hScrollBar1.Visible = hScrollBar2.Visible = true; textBox1.Visible = textBox2.Visible = false; }
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            label8.Text = textBox1.Text;
            label9.Text = textBox2.Text;

        }
        private void butontik(Button buton)
        {
            
        }
      
        private void button10_Click(object sender, EventArgs e)
        {
            OleDbCommand silkomut = new OleDbCommand();
            silkomut.Connection = baglanti;
            silkomut.CommandText = "delete  from satis";
            silkomut.ExecuteNonQuery();
            silkomut.CommandText = "delete  from satislar";
            silkomut.ExecuteNonQuery();
            silkomut.CommandText = "delete  from satisrapor";
            silkomut.ExecuteNonQuery();
            silkomut.CommandText = "UPDATE musteri SET musteri.borc = 0";
            silkomut.ExecuteNonQuery();
            verigönder();
        }

        private void satisislem_FormClosing(object sender, FormClosingEventArgs e)
        {
            button2.PerformClick();
           
           
        }
        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tutarhesapla();
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tutarhesapla();
        }

   
        public void buttoncagir()
        {
            int satir = 0, sütün = 0, feg = 0;
            tabPage1.Controls.Clear();
            OleDbCommand kom = new OleDbCommand();
            kom.Connection = baglanti;

            kom.CommandText = "Select urunkodu,Ürün From Ürün";//Stoktaki Ürünleri Büyükten kücüğe sıralar
            OleDbDataReader kodsiraoku = kom.ExecuteReader();

            while (kodsiraoku.Read())
            {
                
                Button btn = new Button();
                btn.Name = kodsiraoku["urunkodu"].ToString();

                btn.Text = kodsiraoku["Ürün"].ToString();
                btn.Location = new Point(satir * 80, sütün * 80);
                btn.Width = 70;
                btn.Height = 70;
                butonn(btn);

                if (satir == 5) { satir = 0; sütün++; }
                else { satir++; }
                btn.Click += btnn;
                feg++;
       
            }
           
        }

       

       
      

        private void satisislem_VisibleChanged(object sender, EventArgs e)
        {
        if (dataGridView2.RowCount>0) temizlegecicitablo();
        label2.Text = "0";
            //listede satir varsa delete atar veritabanındaki satis tablosuna
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (saytime == 5) { timer1.Enabled = false; saytime = 0; }
            else { baglanti.Close(); baglanti.Open(); verigönder(); }
            saytime++;
        }

    

       

       

       

       
    }
}
// tabPage1.BackgroundImage = Image.FromFile("Infinity200.gif");  resim ekle debugda     tabPage1.BackgroundImage = null;resmi kaldir