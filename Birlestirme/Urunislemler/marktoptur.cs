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
    public partial class marktoptur : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=pesova.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        public BindingSource bs = new BindingSource();
        public marktoptur()
        {
            InitializeComponent();
        }

        private void marktoptur_Load(object sender, EventArgs e)
        {

        }
        private void vericek_genel()
        {
            string seckomutu = "select personelkodu,personelisim,personelcinsiyet from Calisan";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, baglanti);
            string abc="Calisan";
            ds.Clear();
            da.Fill(ds, "[0]",abc);
            bs.DataSource = ds.Tables["Calisan"];
            dataGridView1.DataSource = bs;
            
           
                
        }
        
    }
}
