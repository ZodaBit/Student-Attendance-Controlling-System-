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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int z;
       
        Form1 frmlog = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 2;

            if (z > 100)
            {
                this.Hide();

                
                this.timer1.Enabled = false;

                

                frmlog.Show();
                
                return;

            }
            this.progressBar1.Value = z;
        }
    }
}
