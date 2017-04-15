 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace phonesmsnew
{
    public partial class ROOMTEACHER : Form 
    {
        string user;
        code.ManageDb dbcode = new code.ManageDb();
        code.ROOMTEACHERCLS dbrooms = new code.ROOMTEACHERCLS();
       
        DataTable getallstudent=new DataTable();
        public ROOMTEACHER()
        {
            InitializeComponent();
        }

        public ROOMTEACHER(string tempuser)
        {
            user = tempuser;
            InitializeComponent();
        }

        private void selectroomgobtn_Click(object sender, EventArgs e)
        {
          //DataSet  allstudent = dbcode.GetallStudentBySection(gradselectroomcomboBox1.Text, secselectroomcomboBox2.Text);
           //dgvselectedstudent.DataSource = allstudent.Tables[0];

             getallstudent = dbcode.GetallStudentBySection(gradselectroomcomboBox1.Text, secselectroomcomboBox2.Text);
            dgvselectedstudent.DataSource = getallstudent;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = dgvselectedstudent.Rows.Count - 1; i >= 0; i--)
                {
                    if ((bool)dgvselectedstudent.Rows[i].Cells[0].FormattedValue)
                    {

                        
                        getallstudent.Rows.RemoveAt(i);

      
                    }
                }
                SMSA frmsm = new SMSA(getallstudent);
                frmsm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                
            }
  
           
        }

        private void chanceAccountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHANGEPA frms = new CHANGEPA(user);
            frms.Show();
        }

        private void backUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BACKUP FRMSD = new BACKUP();
            FRMSD.Show();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 lfrms = new Form1();
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string status;
            string ab = "absent";
            string pr = "present";
            foreach (DataGridViewRow r in dgvselectedstudent.Rows)
            {
                if (r.Cells[0].Value != null)
                {
                    if ((Boolean)r.Cells[0].Value == true)
                    {
                        r.Cells[0].Value = ab;
                         status = ab;
                    }
                    else
                    {
                        r.Cells[0].Value = pr;
                        status = pr;
                    }
                }
                if (r.Cells["Stu_Fname"].Value == null)
                {
                    break;
                }
                string stufname = r.Cells["Stu_Fname"].Value.ToString();
                string stulname = r.Cells["Stu_Lname"].Value.ToString();

                string statuss = "present";
                bool inserted;

                inserted = dbrooms.STOREDSTUDENTATT(stufname, stulname, gradselectroomcomboBox1.Text, secselectroomcomboBox2.Text, attdateTimePicker1.Text, statuss);


                if (inserted == true)
                {

                    MessageBox.Show("student add sucsussfully ");
                }
                else
                {
                    MessageBox.Show("studend not add crated");
                }
            }

        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            absentstudentreport frms = new absentstudentreport();
            frms.Show();
        }

       
        

        
       
    }
}
