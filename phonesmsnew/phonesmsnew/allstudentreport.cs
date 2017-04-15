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
    public partial class allstudentreport : Form
    {
        public allstudentreport()
        {
            InitializeComponent();
        }

        private void allstudentreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet4.STUDENT' table. You can move, or remove it, as needed.
            this.STUDENTTableAdapter.Fill(this.schoolDataSet4.STUDENT);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
