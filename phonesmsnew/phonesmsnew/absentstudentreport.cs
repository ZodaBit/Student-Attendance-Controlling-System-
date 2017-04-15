using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phonesmsnew
{
    public partial class absentstudentreport : Form
    {
        public absentstudentreport()
        {
            InitializeComponent();
        }

        private void absentstudentreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet6.ATTSTATUS' table. You can move, or remove it, as needed.
            this.ATTSTATUSTableAdapter.Fill(this.schoolDataSet6.ATTSTATUS);

            this.reportViewer1.RefreshReport();
        }
    }
}
