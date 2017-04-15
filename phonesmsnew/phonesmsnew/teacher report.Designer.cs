namespace phonesmsnew
{
    partial class teacher_report
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
            this.schoolDataSet5 = new phonesmsnew.schoolDataSet5();
            this.ROOMTEACHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ROOMTEACHERTableAdapter = new phonesmsnew.schoolDataSet5TableAdapters.ROOMTEACHERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROOMTEACHERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ROOMTEACHERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "phonesmsnew.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(670, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // schoolDataSet5
            // 
            this.schoolDataSet5.DataSetName = "schoolDataSet5";
            this.schoolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ROOMTEACHERBindingSource
            // 
            this.ROOMTEACHERBindingSource.DataMember = "ROOMTEACHER";
            this.ROOMTEACHERBindingSource.DataSource = this.schoolDataSet5;
            // 
            // ROOMTEACHERTableAdapter
            // 
            this.ROOMTEACHERTableAdapter.ClearBeforeFill = true;
            // 
            // teacher_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "teacher_report";
            this.Text = "teacher_report";
            this.Load += new System.EventHandler(this.teacher_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROOMTEACHERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ROOMTEACHERBindingSource;
        private schoolDataSet5 schoolDataSet5;
        private schoolDataSet5TableAdapters.ROOMTEACHERTableAdapter ROOMTEACHERTableAdapter;
    }
}