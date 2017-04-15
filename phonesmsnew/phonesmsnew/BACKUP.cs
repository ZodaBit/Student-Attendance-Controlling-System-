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
    public partial class BACKUP : Form
    {
        public BACKUP()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {

                txtlocation.Text = fbd.SelectedPath.ToString();

                

            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string CurrentDatabasePath = Environment.CurrentDirectory + @"\school.mdf";

            //FolderBrowserDialog fbd = new FolderBrowserDialog();

            // if (fbd.ShowDialog() == DialogResult.OK)
            //{

            string PathtobackUp = txtlocation.Text;

            File.Copy(CurrentDatabasePath, PathtobackUp + @"\Backup.mdf", true);

            MessageBox.Show("Back Up SuccessFull! ");

            //}
            //MessageBox.Show("The Database is Backed up in the directory " + txtlocation.Text , "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BACKUP_Load(object sender, EventArgs e)
        {

        }
    }
}
