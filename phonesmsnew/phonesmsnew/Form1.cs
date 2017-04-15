using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace phonesmsnew
{
    public partial class Form1 : Form
    {

        code.ManageDb dbcode = new code.ManageDb();
        public Form1()
        {
            InitializeComponent();
        }
        Admin admins = new Admin();
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }
       
       private void btnLogIn_Click(object sender, EventArgs e)
       {
           if (usercombobox.Text == "" || textusername.Text == "" || textPassWord.Text == "")
           {
               MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

           }
           else
           {
                DataSet ds = dbcode.LogUser(textusername.Text, textPassWord.Text, usercombobox.Text);

                if (ds.Tables[0].Rows.Count==0)
                {
                    textusername.Clear();
                    textPassWord.Clear();
                    usercombobox.SelectedIndex = -1;
                    MessageBox.Show("You have type a wrong user name  or password");
                }
                    //there is valied user
                else
                {
                     DataRow row = ds.Tables[0].Rows[0];
                     if (row["Role"].ToString() == "ADMINISTRATOR")
                     {
                         admins.Show();
                         this.Hide();
                         
                        
                                                 
                     }
                     else //The user is teacher
                     {
                        ROOMTEACHER frmsds=new ROOMTEACHER(textusername.Text);
                         frmsds.Show();
                         this.Hide();
                         
                       
                        
                     }
                }
                
            }
           }

      
       private void butnexit_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       

       
    }
}
