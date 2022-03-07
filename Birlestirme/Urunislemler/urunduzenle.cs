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
    public partial class urunduzenle : Form
    {
       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
        public urunduzenle()
        {
            InitializeComponent();
        }

        private void urunduzenle_Load(object sender, EventArgs e)
        {
            urunislem urunislem = (urunislem)Application.OpenForms["urunislem"];
            this.Size = new Size(750, 570);

            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            cagirherseyi();
          
            
           
           
        }
        private void cagirherseyi()
        {
            OleDbCommand komut = new OleDbCommand("Select * from ÜRÜN where urunkodu=@kod",baglanti);
            komut.Parameters.AddWithValue("@kod",stokkodu.Text);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                urunad.Text = oku["Ürün"].ToString();
               
            }

          
      
            

        }

        private void vericek_urun()
        {
         
           
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.BackColor = Color.Coral;
            label17.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.BackColor = Color.Aqua;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            urunislem urunislem = (urunislem)Application.OpenForms["urunislem"];
            this.Size = new Size(1200, 670);
            Kodsabiti.Text = urunislem.duzenleler[0];
          
        }

        private void temmizle_Click(object sender, EventArgs e)
        {
            this.Size = new Size(750, 570);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if ( yeniurunadi.Text != "")
            {
                string komutum = "update  ÜRÜN set Ürün=@urunadi where Urunkodu=@urunkodu";
                OleDbCommand duzenlekomut = new OleDbCommand(komutum,baglanti);
                duzenlekomut.Parameters.AddWithValue("@urunadi", yeniurunadi.Text);

                duzenlekomut.Parameters.AddWithValue("@urunkodu", Kodsabiti.Text);

                duzenlekomut.ExecuteNonQuery();
                urunislem urunislem = (urunislem)Application.OpenForms["urunislem"];
              
                urunislem.duzenleonay = true;
                this.Close();
            }
            else { MessageBox.Show("Boşlukları Doldurun"); }
        }

        private void urunduzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti.State != ConnectionState.Closed) baglanti.Close();
            
        }
    }
}
