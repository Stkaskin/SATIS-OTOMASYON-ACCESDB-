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
namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        //Global ekleme alanı
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Zehra\\Desktop\\Oyun Ve Uygulamalar\\Veritabanım\\Hırdavat Ürün.accdb");
        OleDbCommand komut = new OleDbCommand();
        bool sayiharf; int stokkodunubul, tutulacak;
        int stokcesit;
        //
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();
            listelenecek();
            dataGridView1.ClearSelection();
        }
        private void listelenecek()
        {
            dataGridView1.Rows.Clear();
            // listView1.Items.Clear();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From Ürün";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int satir = dataGridView1.Rows.Add();
                dataGridView1.Rows[satir].Cells[0].Value = oku["Kodu"];
                dataGridView1.Rows[satir].Cells[1].Value = oku["Ürün"].ToString();
                dataGridView1.Rows[satir].Cells[2].Value = oku["Fiyat"].ToString();
            }
            stokcesit++;
            label11.Text = dataGridView1.Rows.Count.ToString();
            baglanti.Close();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private void verilericek()
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select *from Ürün where Kodu=" + Convert.ToInt16(stokkodu.Text) + "";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                urunad.Text = oku["Ürün"].ToString();
                stokbilgi.Text = oku["Bilgi"].ToString();
                agirlik.Text = oku["AĞIRLIK"].ToString();
                boyut.Text = oku["BOYUT"].ToString();
                fiyat.Text = oku["Fiyat"].ToString();
                turbilgi.Text = oku["TÜR"].ToString();
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kodsira();
            baglanti.Open();
            stokcesit = dataGridView1.Rows.Count + 1;
            MessageBox.Show("Stoğa Eklendi \n Stok Kodunuz:" + stokkodunubul);
            //komut.Connection = baglanti;
            stokkodu.Text = stokkodunubul.ToString();
            if (fiyat.Text == "")
                fiyat.Text = "0";
            if (stokbilgi.Text == "")
                stokbilgi.Text = "0";
            komut.CommandText = "insert into ÜRÜN (Kodu,Ürün,TÜR,BOYUT,FİYAT,AĞIRLIK,Bilgi) values (" + stokkodunubul + ",'" + urunad.Text.ToString() + "','" + turbilgi.Text.ToString() + "','" + boyut.Text.ToString() + "','" + fiyat.Text.ToString() + "','" + agirlik.Text.ToString() + "','" + stokbilgi.Text.ToString() + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            listelenecek();
            temizle();
            eklebutton.Enabled = false;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[tutulacak].Selected = false;
            urunad.Focus();
        }
        private void stokkodu_TextChanged(object sender, EventArgs e)
        {
            if (agirlik.Text != "" || fiyat.Text != "" || stokbilgi.Text != "" || stokbilgi.Text != "" || boyut.Text != "" || turbilgi.Text != "" || stokkodu.Text != "" || urunad.Text != "") temmizle.Enabled = true;
            else { temmizle.Enabled = false; }
            if (stokkodu.Text != "" || urunad.Text != "")
            {
                eklebutton.Enabled = true; temmizle.Enabled = true;
                if (urunad.Text == "") eklebutton.Enabled = false;
            }
            else
            {
                eklebutton.Enabled = false; duzenlebutton.Enabled = false; silbutton.Enabled = false;
            }
            ilkharfbuyuk(urunad); ilkharfbuyuk(agirlik); ilkharfbuyuk(stokbilgi); ilkharfbuyuk(boyut); ilkharfbuyuk(turbilgi); ilkharfbuyuk(ek);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            temizle(); temmizle.Enabled = false;
        }
        private void temizle()
        {
            urunad.Clear(); stokbilgi.Clear(); stokbilgi.Clear(); fiyat.Clear(); stokkodu.Clear(); turbilgi.Clear(); agirlik.Clear(); boyut.Clear();
            stokkodu.Text = ""; duzenlebutton.Enabled = silbutton.Enabled = eklebutton.Enabled = temmizle.Enabled = false; dataGridView1.ClearSelection();
        }
        private void duzenlebutton_Click(object sender, EventArgs e)
        {
            if (urunad.Text != "" && stokkodu.Text != "")
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update  ÜRÜN set Ürün='" + urunad.Text + "',TÜR='" + turbilgi.Text + "',AĞIRLIK='" + agirlik.Text + "',BOYUT='" + boyut.Text + "',Bilgi='" + ek.Text + "',Fiyat='" + fiyat.Text + "" + "'where Kodu=" + stokkodu.Text + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                silbutton.Enabled = false;
                listelenecek();
                duzenlebutton.Enabled = false;
                int sayi = dataGridView1.Rows.Count;
                dataGridView1.Rows[sayi - 1].Selected = true;//Satır işaretleme
                dataGridView1.FirstDisplayedScrollingRowIndex = sayi - 1;
                duzenlebutton.Enabled = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listelenecek();
        }
        private void silbutton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            tutulacak = tutulacak = dataGridView1.SelectedRows[0].Index;
            komut.CommandText = "delete from ÜRÜN where Kodu=" + stokkodu.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            silbutton.Enabled = false;
            listelenecek();
            temizle();
            //dataGridView1.Rows[tutulacak].Selected = true;//Satır işaretleme
            if (tutulacak != dataGridView1.RowCount)
            {
                // dataGridView1.Rows[tutulacak].Selected = false;
                dataGridView1.FirstDisplayedScrollingRowIndex = tutulacak;
            }
            else
            {
                if (tutulacak != 0)
                {
                    // dataGridView1.Rows[tutulacak-1].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = tutulacak - 1;
                }
            }//İndexe yönelme
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ilkharfbuyuk(arama);
            dataGridView1.Rows.Clear();
            baglanti.Open();
            komut.Connection = baglanti;
            //    if ()komut.CommandText = "Select * From Ürün where Ürün like '%"+textBox1.Text+"%'";
            if (sayiharf)
            {
                komut.CommandText = "Select * From Ürün where Ürün like '%" + arama.Text + "%'";
            }
            else { komut.CommandText = "Select * From Ürün where Kodu like '%" + arama.Text + "%'"; }
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int satir = dataGridView1.Rows.Add();
                dataGridView1.Rows[satir].Cells[0].Value = oku["Kodu"];
                dataGridView1.Rows[satir].Cells[1].Value = oku["Ürün"].ToString();
                dataGridView1.Rows[satir].Cells[2].Value = oku["Fiyat"].ToString();
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            baglanti.Close();
            dataGridView1.ClearSelection();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (arama.Text == "")
            {
                if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 && e.KeyChar != (char)Keys.Back) sayiharf = false;
                else if (e.KeyChar != (char)Keys.Back) sayiharf = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Stok Kodu Otomatik Atanır \n Ürün Adını Girerek Kayıt Yapabilirsiniz\nArama için Stok Kodu Veya\n Ürün ismi giriniz.");
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                silbutton.Enabled = true;
                duzenlebutton.Enabled = true;
                stokkodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                verilericek();
                temmizle.Enabled = true;
                duzenlebutton.Enabled = true;
                eklebutton.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string strTemp = " [İsim] Text, [Soyisim] Text ";
           komut.Connection = baglanti;
           string isimsel="Yetki"+1;
           komut.CommandText = "create table isimsel(" + strTemp + ")";
           komut.ExecuteNonQuery();
           baglanti.Close();
        
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        void kodsira()
        {
            dataGridView1.Rows.Clear();
            baglanti.Open();
            komut.Connection = baglanti;
            for (int i = 1; ; i++)
            {
                OleDbCommand kom = new OleDbCommand();
                kom.Connection = baglanti;
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                kom.CommandText = "Select * From Ürün where Kodu like " + i + "";
                OleDbDataReader oku2 = kom.ExecuteReader();
                if (oku2.Read())
                {
                }
                else { stokkodunubul = i; break; }
            }
            baglanti.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("datagridviewde boş yere clickleyip sil basınca hata veriyor .");
        }
        private void ek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                eklebutton.PerformClick();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        void ilkharfbuyuk(TextBox texbox)
        {
            if (texbox.TextLength > 0)
            {
                texbox.Text = char.ToUpper(texbox.Text[0]).ToString() + texbox.Text.Substring(1);
                texbox.SelectionStart = texbox.TextLength;
            }
        }
        
        
    }
}
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\Zehra\Desktop\Oyun Ve Uygulamalar\Veritabanım\Hırdavat Ürün.accdb"