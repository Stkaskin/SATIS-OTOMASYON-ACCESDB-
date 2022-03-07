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
    public partial class hesapdefteri : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public static  DataSet ds1 = new DataSet();
        public static DataSet dsgit = new DataSet();
        BindingSource bs1 = new BindingSource();
        BindingSource bs2 = new BindingSource();
        int yazdırsayfa = 0;
        bool detayvaryok;
        int sayfa = 1;
        string islemtipi;
        decimal kalanbak = 0, toplamborc=0, odenenpara=0;
         OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
        public hesapdefteri()
        {
            InitializeComponent();
        }

        private void hesapdefteri_Load(object sender, EventArgs e)
        {
            if (baglanti.State== ConnectionState.Closed) baglanti.Open();
            vericek();
            label6.DataBindings.Add("Text", bs, "isim");
            label7.DataBindings.Add("Text", bs, "turu");
            label8.DataBindings.Add("Text", bs, "tel");
            label10.DataBindings.Add("Text", bs, "adres");
            label15.DataBindings.Add("Text", bs, "eposta");
            label17.DataBindings.Add("Text", bs, "musterikod");



        }
        private void bagla()
        {
         
        }
        public void vericek()
        {
           
         ds = new DataSet();
         
          ds1 = new DataSet();
          bs1 = new BindingSource();
          bs2 = new BindingSource();
        
            bs1 = new BindingSource();
            string komut = "SELECT * FROM musteri";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);

            ds.Clear();
            da.Fill(ds, "tablo");
            bs.DataSource = ds.Tables["tablo"];
            comboBox1.DisplayMember = "isim";
            comboBox1.ValueMember = "musterikod";

            comboBox1.DataSource = dataGridView2.DataSource = bs;
            dataGridView2.Columns["musterikod"].Visible = false;
          
            dataGridView2.Columns["tel"].Visible = false;
            dataGridView2.Columns["adres"].Visible = false;
            dataGridView2.Columns["eposta"].Visible = false;
            bagla();
            if (dataGridView1.Rows.Count == 0) duzenlebutton.Enabled = false;
            else duzenlebutton.Enabled = true;
            // label12.DataBindings.Clear();
           if (gizlilabel1.DataBindings.Count==0) gizlilabel1.DataBindings.Add("Text", bs1, "satiskodu");
           if (gizlilabel2.DataBindings.Count == 0) gizlilabel2.DataBindings.Add("Text", bs1, "islemtipi");

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sayfa = 1;
            detayvaryok = true;
            gecisyap();
            
           
            
         //
        }
        private void bakiyehesap()
        {
           
           
            kalanbak = odenenpara = toplamborc = 0;
            tbakiye.Text = todeme.Text = kbakiye.Text = "0";
            OleDbCommand kom = new OleDbCommand("SELECT Sum(satisrapor.tutar) AS Toplatutar FROM satisrapor WHERE (((satisrapor.musteri)=@kod)) GROUP BY satisrapor.islemtipi",baglanti);
            kom.Parameters.AddWithValue("@kod", comboBox1.SelectedValue);
            
            OleDbDataReader oku = kom.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToDecimal(oku["Toplatutar"].ToString()) < 0) { odenenpara = Convert.ToDecimal(oku["Toplatutar"]); todeme.Text = odenenpara.ToString(); }
                else {  toplamborc = Convert.ToDecimal(oku["Toplatutar"]); tbakiye.Text = toplamborc.ToString();  }

               // MessageBox.Show(oku["Toplatutar"].ToString());
               // MessageBox.Show(oku["satisrapor.islemtipi"].ToString());
                
            }
            kalanbak = toplamborc + odenenpara; kbakiye.Text = kalanbak.ToString();
          
        }

       
        public void gecisyap()
        {
            if (detayvaryok)
            {

                if (sayfa == 1)
                {
                    bs1 = new BindingSource();
                    ds1 = new DataSet();
                    dataGridView1.DataSource = null;//databindignsden kurtulur
                    dataGridView1.Columns.Clear(); dataGridView1.Rows.Clear();

                    string komut = "SELECT satisrapor.satiskodu, satisrapor.islemtipi, satisrapor.tutar, satisrapor.zaman FROM satisrapor INNER JOIN musteri ON satisrapor.musteri = musteri.musterikod WHERE (((satisrapor.musteri)=@kod)) Order By zaman Asc";

                    OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@kod", comboBox1.SelectedValue);

                    ds1.Clear(); //bs1 = new BindingSource();
                    da.Fill(ds1, "tablo");

                    bs1.DataSource = ds1.Tables["tablo"];
                    dataGridView1.DataSource = bs1;
                    
                    dataGridView1.Columns["satiskodu"].HeaderText = "İşlem Kodu";
                    dataGridView1.Columns["satiskodu"].Visible = false;
                    dataGridView1.Columns["islemtipi"].HeaderText = "Yapılan İşlem";
                    dataGridView1.Columns["tutar"].HeaderText = "Tutar";
                    dataGridView1.Columns["zaman"].HeaderText = "Zaman";
                    bakiyehesap();
                    gizlilabel1.DataBindings.Clear();
                    gizlilabel1.DataBindings.Add("Text", bs1, "satiskodu");
                    gizlilabel2.DataBindings.Clear();
                    gizlilabel2.DataBindings.Add("Text", bs1, "islemtipi");
                   
                    button1.Visible = false;
                    button2.Visible = true;
                     panel3.Visible=false;
                     yazdırsayfa = 1;
                }
                else if (sayfa == 2)
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (gizlilabel2.Text == "Ödeme") { islemtipi = "Ödeme"; }
                        else islemtipi = "Satın Alındı";
                        ds1 = new DataSet();
                        bs2 = new BindingSource();
                        dataGridView1.DataSource = null;//databindignsden kurtulur
                        dataGridView1.Columns.Clear(); dataGridView1.Rows.Clear();

                        //"SELECT satislar.urunadi, satislar.fiyat, satislar.adet, satislar.tutar FROM satislar WHERE (((satislar.satiskodu)=[aa]))";
                      /*hatayla karsılasınca sil yenibak,eski*/// string komut = "SELECT satislar.urunadi, satislar.fiyat, satislar.adet, satislar.tutar FROM satislar WHERE (((satislar.satiskodu)=@deger))";
                        string komut = "SELECT satislar.urunadi, satislar.fiyat, satislar.adet, satislar.tutar, satislar.satiskodu, satisrapor.eskibakiye, satisrapor.yenibakiye, satisrapor.tutar AS toplamtutar, satislar.zaman FROM satisrapor INNER JOIN satislar ON satisrapor.satiskodu = satislar.satiskodu WHERE (((satislar.satiskodu)=@deger))";

                        OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
                        da.SelectCommand.Parameters.AddWithValue("@deger", gizlilabel1.Text);
                     

                        ds1.Clear(); //
                        da.Fill(ds1, "tablo4");
                        bs2.DataSource = ds1.Tables["tablo4"];
                        dataGridView1.DataSource = bs2;
                      
                        if (islemtipi == "Ödeme")
                        {
                            dataGridView1.Columns["urunadi"].HeaderText = "İşlem";
                       
                            dataGridView1.Columns[4].Visible = dataGridView1.Columns[2].Visible =
                                dataGridView1.Columns[1].Visible = dataGridView1.Columns[5].Visible =
                                 dataGridView1.Columns[6].Visible = dataGridView1.Columns[7].Visible =false;
                            dataGridView1.Columns[3].HeaderText = "Ödenen Miktar";
                            dataGridView1.Columns["zaman"].HeaderText = "İşlem Tarihi";

                            //dataGridView1.Columns["satislar.tutar"].HeaderText = "Ödenen Miktar";
                           // dataGridView1.Columns["satislar.tutar"].HeaderText = "Ödenen Miktar";
                            yazdırsayfa = 2;

                        }
                        else
                        {
                            dataGridView1.Columns["urunadi"].HeaderText = "Ürün Adı";
                            dataGridView1.Columns["fiyat"].HeaderText = "Fiyat";
                            dataGridView1.Columns[4].Visible = dataGridView1.Columns[5].Visible =
                               dataGridView1.Columns[6].Visible = dataGridView1.Columns[7].Visible = false;
                            dataGridView1.Columns[3].HeaderText = "Tutar";
                            dataGridView1.Columns["zaman"].HeaderText = "İşlem Tarihi";
                            yazdırsayfa = 3;

                        }
                        panel3.Visible = true;
                        eskibakiye.DataBindings.Clear(); tutarbakiye.DataBindings.Clear(); yenibakiye.DataBindings.Clear();
                        eskibakiye.DataBindings.Add("Text",bs2,"eskibakiye");
                        tutarbakiye.DataBindings.Add("Text", bs2, "tutar");
                        yenibakiye.DataBindings.Add("Text", bs2, "yenibakiye");
                       // tutarbakiye.Text = (Convert.ToDecimal(yenibakiye.Text) - Convert.ToDecimal(eskibakiye.Text)).ToString();
                      //  gizlilabel1.DataBindings.Clear();
                      // // gizlilabel1.DataBindings.Add("Text", bs1, "satisrapor.eskikabiye");
                       // gizlilabel2.DataBindings.Clear();
                     //   gizlilabel2.DataBindings.Add("Text", bs1, "islemtipi");
                        button1.Visible = true;
                        button2.Visible = false;
                    }


                }
                if (sayfa >= 2) sayfa = 2;
                else if (sayfa <= 1) sayfa = 1;
            }
            else 
            {
                sayfa = 1;
                dataGridView1.DataSource = null;//databindignsden kurtulur
                dataGridView1.Columns.Clear(); dataGridView1.Rows.Clear();
                bs1 = new BindingSource();
                ds1 = new DataSet();
                string komut = "SELECT urunadi, fiyat,adet, tutar,zaman FROM satislar WHERE (((musteri)=@kod)) Order By zaman Asc";

                OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@kod", comboBox1.SelectedValue);

                ds1.Clear(); //bs1 = new BindingSource();
                da.Fill(ds1, "tablo");

                bs1.DataSource = ds1.Tables["tablo"];
                dataGridView1.DataSource = bs1;
                dataGridView1.Columns["urunadi"].HeaderText = "Ürün/İşlem";
                dataGridView1.Columns["fiyat"].HeaderText = "Fiyat";
                dataGridView1.Columns["adet"].HeaderText = "Adet";
                dataGridView1.Columns["tutar"].HeaderText = "Tutar";
                dataGridView1.Columns["zaman"].HeaderText = "İşlem Zamanı";
                panel3.Visible = false;
                yazdırsayfa = 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayfa--;
            gecisyap();
        }



        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sayfa++;
            gecisyap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayfa++;
            gecisyap();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.ekleduz = true;
            musteri.StartPosition = FormStartPosition.CenterScreen;
            musteri.button1.Text = "Ekle";
            
            musteri.ShowDialog();
            
            vericek();
        }

        private void duzenlebutton_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.ekleduz = false;
            musteri.StartPosition = FormStartPosition.CenterScreen;
            musteri.textBox1.Text = label6.Text;
            if (label7.Text == "Bayi") musteri.comboBox1.SelectedIndex = 0;
            else musteri.comboBox1.SelectedIndex = 1;
            musteri.maskedTextBox1.Text = label8.Text;
            musteri.textBox4.Text = label15.Text;
            musteri.textBox5.Text = label10.Text;
            musteri.musterikodu = label17.Text;
            musteri.button1.Text = "Değiştir";
            musteri.ShowDialog();
            vericek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vericek();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baslangis f5 = new baslangis();
            f5.kim = "Sayın " + label6.Text + " Yaptığı İşlemler ";
            if (yazdırsayfa == 2 || yazdırsayfa==3)
            {
                f5.borc = eskibakiye.Text;
                f5.odenen = tutarbakiye.Text;
                f5.kalan = yenibakiye.Text;
            }
            else 
            {
               
                
                f5.borc = tbakiye.Text;
                f5.odenen = todeme.Text;
                f5.kalan = kbakiye.Text;
            }
            f5.zaman = DateTime.Now.ToString();
            f5.yazdırsayfa = yazdırsayfa;
            f5.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            detayvaryok = true;
            gecisyap();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            detayvaryok = false;
            gecisyap();
        }

        
    }
}
