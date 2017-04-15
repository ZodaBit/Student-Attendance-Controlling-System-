namespace phonesmsnew
{
    partial class allstudentreport
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
            this.schoolDataSet4 = new phonesmsnew.schoolDataSet4();
            this.STUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STUDENTTableAdapter = new phonesmsnew.schoolDataSet4TableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.STUDENTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "phonesmsnew.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(621, 382);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // schoolDataSet4
            // 
            this.schoolDataSet4.DataSetName = "schoolDataSet4";
            this.schoolDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STUDENTBindingSource
            // 
            this.STUDENTBindingSource.DataMember = "STUDENT";
            this.STUDENTBindingSource.DataSource = this.schoolDataSet4;
            // 
            // STUDENTTableAdapter
            // 
            this.STUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // allstudentreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 382);
            this.Controls.Add(this.reportViewer1);
            this.Name = "allstudentreport";
            this.Text = "allstudentreport";
            this.Load += new System.EventHandler(this.allstudentreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource STUDENTBindingSource;
        private schoolDataSet4 schoolDataSet4;
        private schoolDataSet4TableAdapters.STUDENTTableAdapter STUDENTTableAdapter;

    }
}