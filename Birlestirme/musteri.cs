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
    public partial class musteri : Form
    {
       
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
        public bool ekleduz;
        public string musterikodu;
        public musteri()
        {
            InitializeComponent();
        }
        private void musteri_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && maskedTextBox1.Text.Length == 14 && comboBox1.Text != "")
            {
                MessageBoxManager.Yes = "Onayla";
                MessageBoxManager.No = "İptal Et";
              
                DialogResult cikissoru = new DialogResult();
                cikissoru = MessageBox.Show(textBox1.Text+" Kişi Bilgileri Onaylansın Mı?", "Kişi Bilgileri", MessageBoxButtons.YesNo);
                if (cikissoru == DialogResult.Yes)
                {
                    string komutum;
                    OleDbCommand komut = new OleDbCommand();
                    if (ekleduz)
                    {
                        komutum = "insert into musteri (isim,turu,tel,adres,eposta) values (@ad,@tur,@tel,@adres,@epos)";




                    }
                    else
                    {
                        komutum = "update  musteri set isim=@ad,turu=@tur,tel=@tel,adres=@adres,eposta=@epos where musterikod=@kod";
                        komut = new OleDbCommand(komutum, baglanti);

                    }
                    komut = new OleDbCommand(komutum, baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox1.Text);
                    komut.Parameters.AddWithValue("@tur", comboBox1.Text);
                    komut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@adres", textBox5.Text);
                    komut.Parameters.AddWithValue("@epos", textBox4.Text);
                    komut.Parameters.AddWithValue("@kod", musterikodu);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(textBox1.Text+" Kişisi Eklendi");
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("Boşlukları Doldurun");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
