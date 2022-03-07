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
    public partial class urunekle : Form
    {
        int bsmk1;
         DataSet ds = new DataSet();
         BindingSource bs = new BindingSource();
        BindingSource bstur = new BindingSource();
        BindingSource bsmarka = new BindingSource();
        BindingSource bsolcut = new BindingSource();
      
        int abc = 0;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");

         int stokkodunubul;
        bool cikisizin = false;
        public urunekle()
        {
            InitializeComponent();
        }
       
        private void urunekle_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();

       
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (urunad.Text == "" || urunad.Text == " ") { MessageBox.Show("Lütfen Ürün Adı Girin"); urunad.Focus(); }
        
         
            else
            {
                kodsira();

                OleDbCommand komut = new OleDbCommand();

                MessageBox.Show("Stoğa Eklendi \n Stok Kodunuz:" + bsmk1);
                komut.Connection = baglanti;

                komut.CommandText = "insert into ÜRÜN (Urunkodu,Ürün) Values (@stokkodunubul,@urunadi)";
                komut.Parameters.AddWithValue("@badi", bsmk1);
                komut.Parameters.AddWithValue("@urunadi", urunad.Text);
               
             //   komut.Parameters.AddWithValue("@olcutbirim", olcutbirim.Text);
              

                komut.ExecuteNonQuery();
           
            
                cikisizin = true;

            }

         
               
            
        }



        void kodsira()
        {
            
            for (int i = 1; ; i++)
            {

                Random yeni = new Random();
                bsmk1 = yeni.Next(1000, 10000);
               


                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
               
                kom.CommandText = "Select * From Ürün where Urunkodu like " + bsmk1 + "";
                OleDbDataReader oku2 = kom.ExecuteReader();

                if (oku2.Read())
                {

                }
                else { break; }
            }


        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            if (cikisizin)
            {
               
                Menü.panelsiras = -1;
                baglanti.Close(); baglanti.Open(); baglanti.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü.panelsiras = -1;
            baglanti.Close();
            this.Close();
        }

        

        private void fiyat_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //yeni Tür ekleme
            //yeni marka ekleme

        }
        private void turmarkaekle()
        {
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        


    }
}
