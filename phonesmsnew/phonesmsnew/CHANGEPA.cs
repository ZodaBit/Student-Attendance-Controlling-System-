using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace phonesmsnew
{
    public partial class CHANGEPA : Form
    {     string users;
        public CHANGEPA()
        {
            InitializeComponent();
        }

        public CHANGEPA(string tempusername)
        {
            users = tempusername;
            InitializeComponent();
        }

        public static string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + "\\school.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con = new SqlConnection(conString);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();

                SqlCommand cmd = new SqlCommand("Select User_Pass FROM PROUSER WHERE User_Name='" + users + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (txtcurrentpasword.Text == reader[0].ToString())
                {
                    reader.Close();
                    if (txtnewpasword.Text == "" || txtconfirmpasworrd.Text == "")
                        MessageBox.Show("Enter a new password and confirm it.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (txtnewpasword.TextLength < 6)
                    {
                        MessageBox.Show("Please Enter Pass word Above six character.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtnewpasword.Text == txtconfirmpasworrd.Text && txtnewpasword.Text != "" && txtconfirmpasworrd.Text != "")
                    {
                        if (MessageBox.Show("Are you sure you want to change your password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SqlCommand cmd1 = new SqlCommand("UPDATE PROUSER set [User_Pass] ='" + txtnewpasword.Text.ToString() + "' WHERE User_Name='" + users + "';", con);
                            cmd1.CommandType = CommandType.Text;
                            cmd1.ExecuteNonQuery();


                            MessageBox.Show("Password successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    else
                        MessageBox.Show("The two password you entered didn't matched.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                    MessageBox.Show("Current Password didn't match with your Username.", "Password Error");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            txtcurrentpasword.Clear();
            txtconfirmpasworrd.Clear();
            txtnewpasword.Clear();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
