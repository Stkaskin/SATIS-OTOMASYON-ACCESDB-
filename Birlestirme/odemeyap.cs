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
    public partial class odemeyap : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");

        int kod;
        public odemeyap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Visible) dataGridView1.Visible = false;
            else dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            bs.Position = 1;
            bs.Position = 0;
        }

        private void odemeyap_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            vericek();
            comboBox1.Text = "";
            comboBox1.SelectedValue = -1;
            comboBox1.SelectedIndex = -1;

            textBox1.DataBindings.Clear();
            textBox1.Text = "";
            
            
        }
        public void vericek()
        {
            string komut = "SELECT musterikod,isim,borc FROM musteri";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            ds.Clear();
            da.Fill(ds, "tablom");
            bs.DataSource = ds.Tables["tablom"];
            comboBox1.ValueMember = "musterikod";
            comboBox1.DisplayMember = "isim";


            comboBox1.DataSource = dataGridView1.DataSource= bs;
            dataGridView1.Columns["musterikod"].Visible = false;
        }
        private void kodbul()
        {

           

                for (int i = 1; ; i++)
                {

                    Random yeni = new Random();
                    kod = yeni.Next(1000, 10000);
                    OleDbCommand kom = new OleDbCommand();
                    kom.Connection = baglanti;
                    kom.CommandText = "Select * From satisrapor where satiskodu=@kod";
                    kom.Parameters.AddWithValue("@kod", kod);
                    OleDbDataReader oku2 = kom.ExecuteReader();

                    if (oku2.Read())
                    {

                    }
                    else { break; }

                }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedValue != null && textBox4.Text != "" && textBox1.Text!="" && Convert.ToDecimal(textBox4.Text)<=Convert.ToDecimal(textBox1.Text) && Convert.ToDecimal(textBox4.Text)!=0)
            {
                MessageBoxManager.Yes = "Onayla";
                MessageBoxManager.No = "İptal Et";
              
                DialogResult cikissoru = new DialogResult();
                cikissoru = MessageBox.Show(comboBox1.Text+" Kişi Ödemesi Kabul Edilsin Mi?", "Ödeme Onaylama", MessageBoxButtons.YesNo);
                if (cikissoru == DialogResult.Yes)
                {
                    
                    kodbul();
                    decimal eskiborc = Convert.ToDecimal(textBox1.Text), odenen = Convert.ToDecimal(textBox4.Text);
                    if (odenen > 0) odenen = Convert.ToDecimal(textBox4.Text) * -1;
                   
                    string komutum = "insert into satisrapor (satiskodu,tutar,zaman,musteri,islemtipi,eskibakiye,yenibakiye) values (@kod,@tutar,@zaman,@musteri,@islemtip,@eski,@yeni)";
                    OleDbCommand komut = new OleDbCommand(komutum, baglanti);
                    komut.Parameters.AddWithValue("@kod", kod);
                    komut.Parameters.AddWithValue("@tutar", odenen);
                    komut.Parameters.AddWithValue("@zaman", DateTime.Now.ToString());
                    komut.Parameters.AddWithValue("@musteri", comboBox1.SelectedValue);
                    komut.Parameters.AddWithValue("@islemtipi", "Ödeme");
                    komut.Parameters.AddWithValue("@eski", eskiborc);
                    komut.Parameters.AddWithValue("@yeni", eskiborc + odenen);
                    komut.ExecuteNonQuery();
                    komutum = "insert into satislar (satiskodu,tutar,urunadi,musteri,zaman) values (@kod,@tutar,@urunadi,@musteri,@zaman)";
                    komut = new OleDbCommand(komutum, baglanti);
                    komut.Parameters.AddWithValue("@kod", kod);
                    komut.Parameters.AddWithValue("@tutar", odenen);
                    komut.Parameters.AddWithValue("@urunadi", "Ödeme");
                    komut.Parameters.AddWithValue("@musteri", comboBox1.SelectedValue);
                    komut.Parameters.AddWithValue("@zaman", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand("UPDATE musteri SET musteri.borc = @yeni WHERE (((musteri.musterikod)=@musterikodu))", baglanti);//musteri borcu güncelle
                    komut.Parameters.AddWithValue("@yeni", eskiborc + odenen);
                    komut.Parameters.AddWithValue("@musterikodu", comboBox1.SelectedValue);
                    komut.ExecuteNonQuery();

                    MessageBox.Show(comboBox1.Text + " Kişisi " + textBox4.Text + " TL Ödeme Yaptı\n Eski Bakiye=" + eskiborc + " \n Ödenen=" + odenen + " \n Kalan=" + (eskiborc + odenen),comboBox1.Text+" Bakiyesi");
                    vericek();
                    textBox4.Clear();

                    textBox1.DataBindings.Clear();
                    textBox1.Text = "";
                    comboBox1.Text = "";
                }
            }
            else 
            {
                
                  MessageBox.Show("Geçerli Bilgi Giriniz."); 
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        if (textBox1.DataBindings.Count==0) textBox1.DataBindings.Add("Text", bs, "borc");
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
         
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Menü.panelsiras = -1;
         //   Menü menü = new Menü();
           // menü.panelsiras = -1;
            
        }
               
    }
}
