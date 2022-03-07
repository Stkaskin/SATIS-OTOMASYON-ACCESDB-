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
    
    public partial class Satıssoru : Form
    {
        public Satıssoru()
        {
            InitializeComponent();
        }

      
        public decimal fiyat, tutar, adet;  string stokmiktari;
        bool yenisatis = true; int kod;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        private void button1_Click(object sender, EventArgs e)
        {
        
           
            if (miktartext.Text != "" && miktartext.Text[0]!='0')
            {
                int miktar = Convert.ToInt32(miktartext.Text);
             
            
                this.Close();
            }
            else { MessageBox.Show("Geçerli Miktar Girin"); miktartext.Focus(); }
               
          
          
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Satıssoru_Load(object sender, EventArgs e)
        {   
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();



           
            getirkisi();
            comboBox1.Text = "";
            comboBox1.SelectedValue = -1;
            kontrolet();
            bak();
          
            textBox1.Focus();
          
            label7.Text = tutar.ToString();
            
        }
        private void getirkisi()
        {
            string komut = "SELECT musterikod,isim,borc FROM musteri";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            comboBox1.ValueMember = "musterikod";
            comboBox1.DisplayMember = "isim";


            comboBox1.DataSource = dataGridView1.DataSource = bs;

            dataGridView1.Columns["musterikod"].Visible = false;
           
        }
        
        private void kontrolet()
        {
            OleDbCommand ara = new OleDbCommand();
            ara.Connection = baglanti;
            ara.CommandText = "Select * From satis";
           // ara.Parameters.AddWithValue("@stokk", kodtext.Text);
            OleDbDataReader araoku = ara.ExecuteReader();
            if (araoku.Read())
            {
            //    textBox1.Text = araoku["fiyat"].ToString();
                satisislem satisislem = Application.OpenForms["satisislem"] as satisislem;
               // satisislem.gecerlikisi.Text = comboBox1.Text;
                comboBox1.SelectedValue = satisislem.musno.Text;
             //   MessageBox.Show(comboBox1.SelectedIndex+satisislem.musno.Text+"");
               // textBox1.ReadOnly = true;

              
               
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
                kom.CommandText = "Select * From satis where urunkodu=@kod";
                kom.Parameters.AddWithValue("@kod", kodtext.Text);
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {
                    textBox1.Text = oku2["fiyat"].ToString();
                    textBox1.ReadOnly = false;
                  
                }
              
            




            }
        }
        private void kodbul()
        {
            //satista satis kodu degerleri yoksa yeni bir kod olusturur bu kod satislar tablosuna ekleneceginden eşsiz bir değer olarak seçilmeli
            if (yenisatis)
            {

                for (int i = 1; ; i++)
                {

                    Random yeni = new Random();
                    kod = yeni.Next(1000, 10000);
                    OleDbCommand kom = new OleDbCommand();
                    kom.Connection = baglanti;
                    kom.CommandText = "Select * From satis where satiskodu=@kod";
                    kom.Parameters.AddWithValue("@kod", kod);
                    OleDbDataReader oku2 = kom.ExecuteReader();

                    if (oku2.Read())
                    {
                        textBox1.Text = oku2["fiyat"].ToString();
                    }
                    else { yenisatis = false; break; }
                   
                }


            }



        }
        private void eklendimi()
        {
        
            
            adet = 0;//sürekli 0 cek sonra adet olarak veritabanından cek
            OleDbCommand ara = new OleDbCommand();
            ara.Connection = baglanti;
            ara.CommandText = "Select * From satis where urunkodu=@stokk";
            ara.Parameters.AddWithValue("@stokk", kodtext.Text);
            OleDbDataReader araoku = ara.ExecuteReader();
            if (araoku.Read())
            {
              
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;

                int satiskodum = Convert.ToInt16(araoku["urunkodu"]);
                adet = Convert.ToInt16(araoku["adet"]);
                decimal fiyat = Convert.ToInt16(araoku["fiyat"]);

               
                

                    adet += Convert.ToInt32(miktartext.Text);
                    komut.CommandText = "update satis set adet=@text1,tutar=@text3 where urunkodu=@text2";
                    komut.Parameters.AddWithValue("@text1", adet);
                    komut.Parameters.AddWithValue("@text3", fiyat * adet);

                    komut.Parameters.AddWithValue("@text2", araoku["urunkodu"]);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    this.Close();

              

            }
            else
            {



                if (textBox1.Text != "" && miktartext.Text != "" && Convert.ToInt64(miktartext.Text) > 0 && comboBox1.SelectedValue != null)
                {

                    int miktari = Convert.ToInt32(miktartext.Text);
                    string tutar = (Convert.ToDecimal(textBox1.Text) * miktari).ToString();

                    bak();

                    OleDbCommand sat = new OleDbCommand();
                    sat.Connection = baglanti;
                    sat.CommandText = "insert into satis (satiskodu,urunadi,urunkodu,fiyat,adet,tutar) Values (@kodsatis,@text1,@text2,@text3,@text4,@tutar)";
                    sat.Parameters.AddWithValue("@kodsatis", kod);
                    sat.Parameters.AddWithValue("@text1", urunlab.Text);
                    sat.Parameters.AddWithValue("@text2", kodtext.Text);
                    sat.Parameters.AddWithValue("@text3", textBox1.Text);
                    sat.Parameters.AddWithValue("@text4", miktartext.Text);
                    sat.Parameters.AddWithValue("@tutar", tutar);

                    sat.ExecuteNonQuery();
                    adet = miktari;
                    satisislem satisislem = Application.OpenForms["satisislem"] as satisislem;
                    satisislem.gecerlikisi.Text = comboBox1.Text;
                    satisislem.musno.Text = comboBox1.SelectedValue.ToString();
                    baglanti.Close();

                    this.Close();

                }
                else { MessageBox.Show("Eksik Veya Hatalı Bilgi..!"); }

            

            }


        }
       
        private void bak()
        {

            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;

            komut.CommandText = "Select satiskodu from satis";
            komut.Parameters.AddWithValue("@butonkod", kod);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                kod = Convert.ToInt32(oku["satiskodu"]);
                comboBox1.Enabled = false;
                panel1.Visible = false;

            }
            else { kodbul(); comboBox1.Enabled = true; }//eğer ki satis tablosunda kod yoksa yeni kod olusturmak üzere kodbula gider eğer ki kod var ise var olan koddan devam eder boylelikle hatalar min cekilir...
        }















        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
       //stok kodunu cek veritabanında bütün değerleri ara yansıt ekle...

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (miktartext.Text != "" && textBox1.Text!="")
            {
                tutar = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(miktartext.Text);
                label7.Text = tutar.ToString();
            }
            else 
            {
                label7.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eklendimi();
           
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           
         
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) dataGridView1.Visible = false;
            else dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            bs.Position = 1;
            bs.Position = 0;
        }

       
    }
}
