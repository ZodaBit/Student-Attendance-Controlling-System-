namespace phonesmsnew
{
    partial class absentstudentreport
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
            this.schoolDataSet6 = new phonesmsnew.schoolDataSet6();
            this.ATTSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ATTSTATUSTableAdapter = new phonesmsnew.schoolDataSet6TableAdapters.ATTSTATUSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTSTATUSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ATTSTATUSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "phonesmsnew.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(762, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // schoolDataSet6
            // 
            this.schoolDataSet6.DataSetName = "schoolDataSet6";
            this.schoolDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ATTSTATUSBindingSource
            // 
            this.ATTSTATUSBindingSource.DataMember = "ATTSTATUS";
            this.ATTSTATUSBindingSource.DataSource = this.schoolDataSet6;
            // 
            // ATTSTATUSTableAdapter
            // 
            this.ATTSTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // absentstudentreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "absentstudentreport";
            this.Text = "absentstudentreport";
            this.Load += new System.EventHandler(this.absentstudentreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTSTATUSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ATTSTATUSBindingSource;
        private schoolDataSet6 schoolDataSet6;
        private schoolDataSet6TableAdapters.ATTSTATUSTableAdapter ATTSTATUSTableAdapter;
    }
}