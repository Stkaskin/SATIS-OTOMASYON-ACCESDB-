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
using System.Threading;
namespace Birlestirme
{
    public partial class urunislem : Form
    {
      
        public string[] duzenleler=new string[20];
        public bool duzenleonay = false;
        int abc = 0;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
       public  DataSet ds = new DataSet();
       public BindingSource bs = new BindingSource();
       
        bool sayiharf;public int tutulacak;
        
        public urunislem()
        {
            InitializeComponent(); CheckForIllegalCrossThreadCalls = false;
        }
        void ilkharfbuyuk(TextBox texbox)
        {
            if (texbox.TextLength > 0)
            {
                texbox.Text = char.ToUpper(texbox.Text[0]).ToString() + texbox.Text.Substring(1);
                texbox.SelectionStart = texbox.TextLength;
            }
        }
       
       
     
      
        private void Form11_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
           
         
            tekseferliktanımlama();

        }
        private void tekseferliktanımlama()
        {
            vericek_urun();//ilki
            label1.Text = listeurun.Rows.Count.ToString();//ilk
          
        }
        private void vericek_urun()
        {
            string seckomutu = "select * from ÜRÜN Order BY urunkodu  ASC";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglanti);
            
            ds.Clear();
            da.Fill(ds, "ÜRÜN");
            bs.DataSource = ds.Tables["ÜRÜN"];
            listeurun.DataSource = bs;
            label1.Text = listeurun.Rows.Count.ToString();
        }
        private void arama_TextChanged(object sender, EventArgs e)
        {
          
                OleDbCommand aramakomut = new OleDbCommand();
                aramakomut.Connection = baglanti;
               
                 string aramasayiharf = "Select * From ÜRÜN where Ürün like '%" + arama.Text + "%' OR Urunkodu like '%" + arama.Text + "%'";
                OleDbDataAdapter da = new OleDbDataAdapter(aramasayiharf, baglanti);
                ds.Clear();
                da.Fill(ds, "ÜRÜN");
                
                listeurun.Sort(listeurun.Columns[0], ListSortDirection.Ascending);
                listeurun.ClearSelection();
              
        }
        
        
        private void silbutton_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Onayla";
                MessageBoxManager.No = "İptal Et";
              
                DialogResult cikissoru = new DialogResult();
                cikissoru = MessageBox.Show(" Silme İşlemi Yapılsın Mı?", "Silme Onaylama", MessageBoxButtons.YesNo);
                if (cikissoru == DialogResult.Yes)
                {
                    OleDbCommand silkomut = new OleDbCommand();
                    silkomut.Connection = baglanti;
                    if (listeurun.CurrentRow.Cells[0].Value != null)
                    {
                        tutulacak = listeurun.CurrentRow.Cells[0].RowIndex;
                        silkomut.CommandText = "delete from ÜRÜN where UrunKodu=@kod";
                        silkomut.Parameters.AddWithValue("@kod", listeurun.CurrentRow.Cells[0].Value.ToString());
                    }
                    if (listeurun.CurrentRow.Cells[0].RowIndex > 0) { listeurun.FirstDisplayedScrollingRowIndex = tutulacak - 1; }
                    silkomut.ExecuteNonQuery();

                    silbutton.Enabled = false;
                    vericek_urun();
                }
          
        }
   
        private void yenile_Click(object sender, EventArgs e)
        {
            vericek_urun();
        }
        private void listeurun_Click(object sender, EventArgs e)
        {
            if (listeurun.SelectedRows.Count != 0)
            {
                silbutton.Enabled = true;
               
                duzenleler[0] = listeurun.CurrentRow.Cells[0].Value.ToString();
                button1.Enabled = true;

            }
        }
       
        private void arama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (arama.Text == "")
            {
                if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57 && e.KeyChar != (char)Keys.Back) sayiharf = false;
                else if (e.KeyChar != (char)Keys.Back) sayiharf = true;
            }
        }
       
       
        

        

        private void button1_Click(object sender, EventArgs e)
        {
      
            if (listeurun.Rows.Count>0 && listeurun.CurrentRow.Cells[0].Value != null)
            {
        
                urunduzenle urunduzenle = new urunduzenle();
               
                urunduzenle.stokkodu.DataBindings.Add("Text", bs, "urunkodu");
                
                urunduzenle.ShowDialog();
                if (baglanti.State != ConnectionState.Closed) { baglanti.Close(); baglanti.Open(); }
                vericek_urun();
                    
                    
              
           
                
            }
          
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            
               
                urunekle urunekle = new urunekle();
                urunekle.ShowDialog();
                baglanti.Close();
                baglanti.Open();
                vericek_urun();
                
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vericek_urun();
            listeurun.ClearSelection();
            
            
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listeurun.Enabled = true;
            listeurun.ClearSelection();
        }
        
       
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
              if (listeurun.InvokeRequired)
            {
                listeurun.Invoke(new MethodInvoker(delegate
                { vericek_urun();
                }));
            }
              else { MessageBox.Show("Bir hatayla karşılaşıldı hata kodu x101101"); }
        }
        private void listeurun_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("21312");
        }
        private void listeurun_Sorted(object sender, EventArgs e)
        {
            listeurun.ClearSelection();
        }

        private void listeurun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
