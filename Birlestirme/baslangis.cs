using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Birlestirme
{
    public partial class baslangis : Form
    {
        public string kim = "", borc, odenen, kalan, zaman;
        public int yazdırsayfa = -1;
        public baslangis()
        {
            InitializeComponent();
        }
       
        private void baslangis_Load(object sender, EventArgs e)
        {
           // reportViewer1.ShowPrintButton = "ss";

            reportViewer1.Visible = reportViewer2.Visible = reportViewer3.Visible =reportViewer4.Visible= false;
             reportViewer1.Location = reportViewer2.Location = reportViewer3.Location =reportViewer4.Location= new Point(5, 5);
            hangisayfa();
            

        
        }
        private void hangisayfa()
        {
            if (yazdırsayfa == 1)//sade görünümlü
            {
                reportViewer1.Visible = reportViewer2.Visible = reportViewer3.Visible = reportViewer4.Visible = false;
                reportViewer1.Visible = true;
                ReportDataSource rds = new ReportDataSource("DataSet1",
                          hesapdefteri.ds1.Tables["tablo"]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameterCollection deger = new ReportParameterCollection();
                deger.Add(new ReportParameter("ReportParameter1", kim));
                deger.Add(new ReportParameter("ReportParameter2", borc));
                deger.Add(new ReportParameter("ReportParameter3", odenen));
                deger.Add(new ReportParameter("ReportParameter4", kalan));
                deger.Add(new ReportParameter("ReportParameter5", zaman));
                this.reportViewer1.LocalReport.SetParameters(deger);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }

            else if (yazdırsayfa == 2)//ödeme fişi
            {
                reportViewer1.Visible = reportViewer2.Visible = reportViewer3.Visible = reportViewer4.Visible = false;
                reportViewer3.Visible = true;
                ReportDataSource rds = new ReportDataSource("DataSet1",
                          hesapdefteri.ds1.Tables["tablo4"]);
                this.reportViewer3.LocalReport.DataSources.Clear();
                this.reportViewer3.LocalReport.DataSources.Add(rds);

                ReportParameterCollection deger = new ReportParameterCollection();
                deger.Add(new ReportParameter("ReportParameter1", kim));
                deger.Add(new ReportParameter("ReportParameter2", borc));
                deger.Add(new ReportParameter("ReportParameter3", odenen));
                deger.Add(new ReportParameter("ReportParameter4", kalan));
                
                this.reportViewer3.LocalReport.SetParameters(deger);
                this.reportViewer3.LocalReport.Refresh();
                this.reportViewer3.RefreshReport();
            }
            else if (yazdırsayfa == 3) //satis fisi
            {
                reportViewer1.Visible = reportViewer2.Visible = reportViewer3.Visible = reportViewer4.Visible = false;
                reportViewer4.Visible = true; 
                ReportDataSource rds = new ReportDataSource("DataSet1",
                          hesapdefteri.ds1.Tables["tablo4"]);
                this.reportViewer4.LocalReport.DataSources.Clear();
                this.reportViewer4.LocalReport.DataSources.Add(rds);

                ReportParameterCollection deger = new ReportParameterCollection();
                deger.Add(new ReportParameter("ReportParameter1", kim));
                deger.Add(new ReportParameter("ReportParameter2", borc));
                deger.Add(new ReportParameter("ReportParameter3", odenen));
                deger.Add(new ReportParameter("ReportParameter4", kalan));
               
                this.reportViewer4.LocalReport.SetParameters(deger);
                this.reportViewer4.LocalReport.Refresh();
                this.reportViewer4.RefreshReport();
            }
            else if (yazdırsayfa == 4)//kisiye tüm satislar fisi
            {
                reportViewer1.Visible = reportViewer2.Visible = reportViewer3.Visible = reportViewer4.Visible = false;
                reportViewer2.Visible = true; reportViewer1.Location = reportViewer2.Location = reportViewer3.Location = new Point(5, 5);
                ReportDataSource rds = new ReportDataSource("DataSet1",
                          hesapdefteri.ds1.Tables["tablo"]);
                this.reportViewer2.LocalReport.DataSources.Clear();
                this.reportViewer2.LocalReport.DataSources.Add(rds);

                ReportParameterCollection deger = new ReportParameterCollection();
                deger.Add(new ReportParameter("ReportParameter1", kim));
                deger.Add(new ReportParameter("ReportParameter2", borc));
                deger.Add(new ReportParameter("ReportParameter3", odenen));
                deger.Add(new ReportParameter("ReportParameter4", kalan));
                deger.Add(new ReportParameter("ReportParameter5", zaman));
                this.reportViewer2.LocalReport.SetParameters(deger);
                this.reportViewer2.LocalReport.Refresh();
                this.reportViewer2.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (yazdırsayfa == 1) reportViewer1.PrintDialog();
            else if (yazdırsayfa == 2) reportViewer3.PrintDialog();
            else if (yazdırsayfa == 3) reportViewer4.PrintDialog();
            else if (yazdırsayfa == 4) reportViewer2.PrintDialog();

        }
        private void CaptureScreen()
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
