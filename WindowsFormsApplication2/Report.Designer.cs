namespace WindowsFormsApplication2
{
    partial class Report
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
            this.SalesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IMSDataSet = new WindowsFormsApplication2.IMSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalesOrderTableAdapter = new WindowsFormsApplication2.IMSDataSetTableAdapters.SalesOrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesOrderBindingSource
            // 
            this.SalesOrderBindingSource.DataMember = "SalesOrder";
            this.SalesOrderBindingSource.DataSource = this.IMSDataSet;
            // 
            // IMSDataSet
            // 
            this.IMSDataSet.DataSetName = "IMSDataSet";
            this.IMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "IMSDataSet_SalesOrder";
            reportDataSource1.Value = this.SalesOrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(903, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalesOrderTableAdapter
            // 
            this.SalesOrderTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 478);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesOrderBindingSource;
        private IMSDataSet IMSDataSet;
        private WindowsFormsApplication2.IMSDataSetTableAdapters.SalesOrderTableAdapter SalesOrderTableAdapter;
    }
}