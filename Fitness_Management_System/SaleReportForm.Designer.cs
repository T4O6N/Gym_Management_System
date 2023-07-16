namespace Fitness_Management_System
{
    partial class SaleReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.saleTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Fitness_Management_System.DataSet1();
            this.saleTbTableAdapter = new Fitness_Management_System.DataSet1TableAdapters.saleTbTableAdapter();
            this.saleTbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saleTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTbBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.saleTbBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fitness_Management_System.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 9);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 433);
            this.reportViewer1.TabIndex = 1;
            // 
            // saleTbBindingSource
            // 
            this.saleTbBindingSource.DataMember = "saleTb";
            this.saleTbBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saleTbTableAdapter
            // 
            this.saleTbTableAdapter.ClearBeforeFill = true;
            // 
            // saleTbBindingSource1
            // 
            this.saleTbBindingSource1.DataMember = "saleTb";
            this.saleTbBindingSource1.DataSource = this.dataSet1;
            // 
            // SaleReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SaleReportForm";
            this.Text = "SaleReportForm";
            this.Load += new System.EventHandler(this.SaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleTbBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource saleTbBindingSource;
        private DataSet1TableAdapters.saleTbTableAdapter saleTbTableAdapter;
        private System.Windows.Forms.BindingSource saleTbBindingSource1;
    }
}