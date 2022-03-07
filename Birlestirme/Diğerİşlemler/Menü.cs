using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
namespace Birlestirme
{
    public partial class Menü : Form
    {
       
        public static int panelsiras = -1;
       public string gecerlipersonel;
        Form formismi;

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
       


        public Menü()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            MessageBoxManager.Unregister();
            MessageBoxManager.Register();
            
        }





        private void button2_Click(object sender, EventArgs e)
        {
            //Form1 asda = new Form1();
            // form
        }

        private void Menü_Load(object sender, EventArgs e)
        {
         
            this.Size = MaximumSize;
            cagirilanform.Size = this.Size;
            MessageBoxManager.Yes = "Programı Kapat";
            MessageBoxManager.No = "Oturumu Kapat";
            MessageBoxManager.Cancel = "Vazgeç";
        
            if (baglanti.State == ConnectionState.Closed) { baglanti.Open(); }
            yetkicek();

        }

      
       

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 1 /*&& urunislem==1*/)//duzenle001
            {

                urunislem cagirform = null;
                if (Application.OpenForms["urunislem"] == null)
                {
                    cagirform = new urunislem();
                    formismi = cagirform;
                    cagir();
                    panelsiras = 1;   
                  //  MessageBox.Show("1");
                }
                else 
                {
                    cagirform =Application.OpenForms["urunislem"] as urunislem;
                    formismi = cagirform;
                    cagir();
                    panelsiras = 1; 
                   // MessageBox.Show("2"+"   "+cagirform);
                 
                }
               
            }
          
        }

        private void satışToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            


        }

        private void satisRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 5)
            {
              
                panelsiras = 5;
            }
        }

        private void personelİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            
        }

        private void adımlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void giirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menü_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Menü_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
       
        private void Menü_FormClosing(object sender, FormClosingEventArgs e)
        {

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();//çıkıs yap butonu
        }
        private void paneldoldur()
        {
            formismi.Dock = DockStyle.Fill;
            formismi.TopLevel = false;
            formismi.FormBorderStyle = FormBorderStyle.None;


            cagirilanform.Controls.Add(formismi);
            formismi.Show();
        }



        private void   cagir()
        {
          //  MessageBox.Show(Application.OpenForms.Count + "");
            if (ActiveForm != null) { cagirilanform.Controls.Clear(); }
            formismi.Dock = DockStyle.Fill;
            formismi.TopLevel = false;
            formismi.FormBorderStyle = FormBorderStyle.None;
            cagirilanform.Controls.Add(formismi);
            formismi.Show();
        }

        private void cagirilanform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stoktaİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void yetkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        

        private void yetkicek()
        {
            
        }

        private void toptanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void satislarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hatanız Nedir Acıklayın...Teşekkürler bildiriminiz için ..... Eklenecek.....@veritabanın rapor sistemi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void Menü_VisibleChanged(object sender, EventArgs e)
        {


            
            
        }

        private void ödemeYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void cagirilanform_ControlAdded(object sender, ControlEventArgs e)
        {
          
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Açık Formlar="+Application.OpenForms.Count);
        }

        private void üRÜNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (panelsiras != 1 /*&& urunislem==1*/)//duzenle001
            {
                if (formismi!=null)formismi.Close();

                urunislem cagirform = null;
                if (Application.OpenForms["urunislem"] == null)
                {
                    cagirform = new urunislem();
                    formismi = cagirform;
                    cagir();
                    panelsiras = 1;
                    //  MessageBox.Show("1");
                }
                else
                {
                    cagirform = Application.OpenForms["urunislem"] as urunislem;
                    formismi = cagirform;
                    cagir();
                    panelsiras = 1;
                    // MessageBox.Show("2"+"   "+cagirform);

                }

            }
        }

        private void satışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (panelsiras != 31)
            {
                if (formismi != null) formismi.Close();
                ;
                satisislem cagirform = null;
                if (Application.OpenForms["satisislem"] == null)
                {
                    cagirform = new satisislem();
                }
                else
                {
                    cagirform = Application.OpenForms["satisislem"] as satisislem;
                    formismi = cagirform;
                    cagirform.baglanti.Close();
                    cagirform.baglanti.Open();
                    cagirform.buttoncagir();
                }
                cagirform.gecerlipersonel = gecerlipersonel;

                formismi = cagirform;
                cagir();
                panelsiras = 31;

            }
        }

        private void ödemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelsiras != 60)
            {
                if (formismi != null) formismi.Close();

                odemeyap cagirform = null;
                if (Application.OpenForms["odemeyap"] == null)
                {
                    cagirform = new odemeyap();
                }
                else
                {
                    cagirform = Application.OpenForms["odemeyap"] as odemeyap;
                    formismi = cagirform;
                    cagirform.vericek();
                }
                formismi = cagirform;
                cagir();
                panelsiras = 60;

            }
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hesapdefteri hesapdefteri = new hesapdefteri();
        //    hesapdefteri.ShowDialog();
            if (panelsiras != 77)
            {
                if (formismi != null) formismi.Close();

                hesapdefteri cagirform = null;
                if (Application.OpenForms["hesapdefteri"] == null)
                {
                    cagirform = new hesapdefteri();
                }
                else
                {
                    cagirform = Application.OpenForms["hesapdefteri"] as hesapdefteri;
                  
                    cagirform.Close();
                    formismi = cagirform;
                    cagirform.gecisyap();
                }
                formismi = cagirform;
                
                cagir();
                panelsiras = 77;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void cagirilanform_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void cagirilanform_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }
        

      

       
    }
}
