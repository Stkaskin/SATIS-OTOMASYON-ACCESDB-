namespace Birlestirme
{
    partial class baslangis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesovaDataSet1 = new Birlestirme.pesovaDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.satislarTableAdapter = new Birlestirme.pesovaDataSet1TableAdapters.satislarTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesovaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // satislarBindingSource
            // 
            this.satislarBindingSource.DataMember = "satislar";
            this.satislarBindingSource.DataSource = this.pesovaDataSet1;
            // 
            // pesovaDataSet1
            // 
            this.pesovaDataSet1.DataSetName = "pesovaDataSet1";
            this.pesovaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Birlestirme.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(850, 696);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.satislarBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Birlestirme.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(65, 104);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ShowBackButton = false;
            this.reportViewer2.ShowContextMenu = false;
            this.reportViewer2.ShowCredentialPrompts = false;
            this.reportViewer2.ShowDocumentMapButton = false;
            this.reportViewer2.ShowFindControls = false;
            this.reportViewer2.ShowPageNavigationControls = false;
            this.reportViewer2.ShowParameterPrompts = false;
            this.reportViewer2.ShowProgress = false;
            this.reportViewer2.ShowPromptAreaButton = false;
            this.reportViewer2.ShowRefreshButton = false;
            this.reportViewer2.ShowStopButton = false;
            this.reportViewer2.ShowZoomControl = false;
            this.reportViewer2.Size = new System.Drawing.Size(850, 696);
            this.reportViewer2.TabIndex = 5;
            // 
            // satislarTableAdapter
            // 
            this.satislarTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.satislarBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Birlestirme.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(109, 161);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ShowBackButton = false;
            this.reportViewer3.ShowContextMenu = false;
            this.reportViewer3.ShowCredentialPrompts = false;
            this.reportViewer3.ShowDocumentMapButton = false;
            this.reportViewer3.ShowFindControls = false;
            this.reportViewer3.ShowPageNavigationControls = false;
            this.reportViewer3.ShowParameterPrompts = false;
            this.reportViewer3.ShowProgress = false;
            this.reportViewer3.ShowPromptAreaButton = false;
            this.reportViewer3.ShowRefreshButton = false;
            this.reportViewer3.ShowStopButton = false;
            this.reportViewer3.ShowZoomControl = false;
            this.reportViewer3.Size = new System.Drawing.Size(850, 696);
            this.reportViewer3.TabIndex = 6;
            this.reportViewer3.Visible = false;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.satislarBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Birlestirme.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(149, 206);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ShowBackButton = false;
            this.reportViewer4.ShowContextMenu = false;
            this.reportViewer4.ShowCredentialPrompts = false;
            this.reportViewer4.ShowDocumentMapButton = false;
            this.reportViewer4.ShowFindControls = false;
            this.reportViewer4.ShowPageNavigationControls = false;
            this.reportViewer4.ShowParameterPrompts = false;
            this.reportViewer4.ShowProgress = false;
            this.reportViewer4.ShowPromptAreaButton = false;
            this.reportViewer4.ShowRefreshButton = false;
            this.reportViewer4.ShowStopButton = false;
            this.reportViewer4.ShowZoomControl = false;
            this.reportViewer4.Size = new System.Drawing.Size(850, 696);
            this.reportViewer4.TabIndex = 7;
            this.reportViewer4.Visible = false;
            // 
            // baslangis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 749);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "baslangis";
            this.Load += new System.EventHandler(this.baslangis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesovaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private pesovaDataSet1 pesovaDataSet1;
        private pesovaDataSet1TableAdapters.satislarTableAdapter satislarTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;

    }
}