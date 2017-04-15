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
    public partial class Admin : Form
    {

        code.ManageDb dbcode = new code.ManageDb();
        code.ROOMTEACHERCLS dbroom = new code.ROOMTEACHERCLS();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            relodform();
        }
        public void relodform()
        {
            dgvuser.DataSource = dbcode.GetAllUsers().Tables[0];
            dgvstudent.DataSource = dbcode.GetAllStudent().Tables[0];
           // dgvtechers.DataSource = dbroom.GetAllTeachers().Tables[0];
        }

        #region when the user btn is cliked
        private void crateuserbtn_Click(object sender, EventArgs e)
        {
            
            if (rolecomboBox1.Text=="" || usertextBox1.Text == "" || passtextbox2.Text == "" )
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else if (passtextbox2.TextLength< 6)
            {
                MessageBox.Show(" Password length should be greater than 6 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (passtextbox2.Text != reptpasstextBox3.Text)
            {
                MessageBox.Show("Password did not match", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool inserted;
                inserted = dbcode.CrateUser(rolecomboBox1.Text, usertextBox1.Text, passtextbox2.Text);

                if (inserted == true)
                {
                    usertextBox1.Clear();
                    passtextbox2.Clear();
                    rolecomboBox1.SelectedIndex = -1;
                    MessageBox.Show("user sucsussfully crated");
                }
                else
                {
                    MessageBox.Show("user not crated");
                   
                }
                relodform();
            }
        

        }
    #endregion
        #region when the user cliked on the dtagridview
        private void dgvuser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow SelectedRow = null;
            try
            {

                SelectedRow = dgvuser.SelectedRows[0];
                if (SelectedRow.Cells["Role"].Value.ToString() == "ADMINISTRATOR" )
                {
                    roleupcombobox.SelectedIndex = 0;
                    
                }
                else 
                {
                    roleupcombobox.SelectedIndex = 1;
                    
                }

               
                // roleupcombobox.SelectedText = SelectedRow.Cells["Role"].Value.ToString();
                usernametextBox.Text = SelectedRow.Cells["User_Name"].Value.ToString();
                passuptextBox2.Text = SelectedRow.Cells["User_Pass"].Value.ToString();
                useridtextBox1.Text = SelectedRow.Cells["User_Id"].Value.ToString();
                
            }
            catch (Exception err)
            {
            }
        }
        #endregion
        #region when the user cliked on the update btn
        private void button1_Click(object sender, EventArgs e)
        {
            if (roleupcombobox.Text == "" || usernametextBox.Text == "" || passuptextBox2.Text == "" || useridtextBox1.Text=="")
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                bool valied = true;
                DialogResult result = MessageBox.Show("Are you Sure\n You Want UPdate a User", "Update",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {



                    if (valied == true)
                    {
                        bool Updated;
                        Updated = dbcode.UpdateUser(roleupcombobox.Text, usernametextBox.Text, passuptextBox2.Text, useridtextBox1.Text);
                        if (Updated == true)
                        {
                            usernametextBox.Clear();
                            passuptextBox2.Clear();
                            roleupcombobox.SelectedIndex = -1;
                            MessageBox.Show("user sucsussfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Unabel To Updated");
                        }
                        relodform();
                    }
                }
            }

        }
        #endregion
        #region when the user cliked on the delete btn
        private void deletuserbtn_Click(object sender, EventArgs e)
        {
            if (roleupcombobox.Text == "" || usernametextBox.Text == "" || passuptextBox2.Text == "" || useridtextBox1.Text == "" )
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you Sure\n You Want Delte a User", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool Result = dbcode.DeletUser(useridtextBox1.Text);
                    if (Result == true)
                    {
                        useridtextBox1.Clear();
                        passuptextBox2.Clear();
                        usernametextBox.Clear();
                        roleupcombobox.SelectedText = "";
                        MessageBox.Show("User Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed Plese Try Again");
                    }
                    relodform();
                }
            }

        }
#endregion
        #region when the user cliked on serch by id btn
        private void searchbyidbtn_Click(object sender, EventArgs e)
        {
            if (searchbyidtextBox5.Text != "")
            {
             MessageBox.Show("the user you looking for is not present in the system", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
               dbcode.SearchUser(searchbyidtextBox5.Text);
                dgvuser.DataSource = dbcode.SearchUser(searchbyidtextBox5.Text).Tables[0];
                
            }
        }
        #endregion
        #region when the user cliked on serch by name btn
        private void searchbynamebtn_Click(object sender, EventArgs e)
        {
           

            if (searchbynametextBox4.Text == "")
            {
                
                MessageBox.Show("the user you looking for is not present in the system", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dbcode.SearchUserByName(searchbynametextBox4.Text);
                dgvuser.DataSource = dbcode.SearchUserByName(searchbynametextBox4.Text).Tables[0];  
            }
        }
        #endregion

        #region when the user cliked on the user toolmenustrip 
        private void toolStripCrateuserbtn_Click(object sender, EventArgs e)
        {
            crateuserbtn_Click(null, null);
        }

        private void toolStripUpdateuserbtn_Click(object sender, EventArgs e)
        {

            button1_Click(null, null);
        }

        private void toolStripDeleteuserbtn_Click(object sender, EventArgs e)
        {
            deletuserbtn_Click(null, null);
        }

        private void toolStripSearchuserbtn_Click(object sender, EventArgs e)
        {
            searchbynamebtn_Click(null, null);
        }
#endregion



        #region when the student cliked on the save btn
        private void savestudentbtn_Click(object sender, EventArgs e)
        {
            if (stufnametextBox1.Text == "" || stulnametextBox2.Text == "" || stugendercomboBox1.Text == "" || stugradecomboBox2.Text == "" || stusectioncomboBox3.Text == "" || dateTimePicker1.Text == "" || stuparentnametextBox3.Text == "" || stupalnametextBox1.Text == "" || stupatypecomboBox1.Text == "" || stuPaphonetextBox.Text == "")
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                bool inserted;
                inserted = dbcode.InsertStudent(stufnametextBox1.Text, stulnametextBox2.Text, stugendercomboBox1.Text, stugradecomboBox2.Text, stusectioncomboBox3.Text, dateTimePicker1.Text, stuparentnametextBox3.Text, stupalnametextBox1.Text, stupatypecomboBox1.Text, stuPaphonetextBox.Text);


                if (inserted == true)
                {
                    stufnametextBox1.Clear();
                    stulnametextBox2.Clear();
                    stupalnametextBox1.Clear();
                    stupatypecomboBox1.SelectedIndex = -1;
                    stugendercomboBox1.SelectedIndex = -1;
                    stugradecomboBox2.SelectedIndex = -1;
                    stusectioncomboBox3.SelectedIndex = -1;
                    stuparentnametextBox3.Clear();
                    stuPaphonetextBox.Clear();
                    MessageBox.Show("student add sucsussfully ");
                }
                else
                {
                    MessageBox.Show("studend not add crated");
                }
                relodform();
            }
        }
        #endregion
        #region when the student cliked on the updatebtn
        private void stuupdatebtn_Click(object sender, EventArgs e)
        {
            if (stufnametextBox1.Text == "" || stulnametextBox2.Text == "" || stugendercomboBox1.Text == "" || stugradecomboBox2.Text == "" || stusectioncomboBox3.Text == "" || dateTimePicker1.Text == "" || stuparentnametextBox3.Text == "" || stupalnametextBox1.Text == "" || stupatypecomboBox1.Text == "" || stuPaphonetextBox.Text == "")
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                bool valied = true;
                DialogResult result = MessageBox.Show("Are you Sure\n You Want UPdate a Student", "Update",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    if (valied == true)
                    {
                        bool Updated;
                        Updated = dbcode.UpdateStudent(stuidtextBox.Text, stufnametextBox1.Text, stulnametextBox2.Text, stugendercomboBox1.Text, stugradecomboBox2.Text, stusectioncomboBox3.Text, dateTimePicker1.Text, stuparentnametextBox3.Text, stupalnametextBox1.Text, stupatypecomboBox1.Text, stuPaphonetextBox.Text);
                        if (Updated == true)
                        {
                            stufnametextBox1.Clear();
                            stulnametextBox2.Clear();
                            stupalnametextBox1.Clear();
                            stupatypecomboBox1.SelectedIndex = -1;
                            stugendercomboBox1.SelectedIndex = -1;
                            stugradecomboBox2.SelectedIndex = -1;
                            stusectioncomboBox3.SelectedIndex = -1;
                            stuparentnametextBox3.Clear();
                            stuPaphonetextBox.Clear();
                            stuidtextBox.Clear();
                            dateTimePicker1.Enabled = false;
                            MessageBox.Show("student  sucsussfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Unabel To Updated");
                        }
                        relodform();
                    }

                }
            }
        }
        #endregion
        #region when the student cliked on the datagridview

        private void dgvstudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedrow = null;
            try
            {

                selectedrow = dgvstudent.SelectedRows[0];

                if (selectedrow.Cells["Pa_sex"].Value.ToString() == "FATHER" || selectedrow.Cells["Stu_Sex"].Value.ToString() == "MALE" || selectedrow.Cells["Stu_Grade"].Value.ToString() == "GRADE 9" || selectedrow.Cells["Stu_Sec"].Value.ToString() == "A")
                {

                    stupatypecomboBox1.SelectedIndex = 0;
                    stugendercomboBox1.SelectedIndex = 0;
                    stugradecomboBox2.SelectedIndex = 0;
                    stusectioncomboBox3.SelectedIndex = 0;
                }
                else
                {

                    stupatypecomboBox1.SelectedIndex = 1;
                    stugendercomboBox1.SelectedIndex = 1;
                    stugradecomboBox2.SelectedIndex = 1;
                    stusectioncomboBox3.SelectedIndex = 1;
                }
                stuidtextBox.Text = selectedrow.Cells["Stu_Id"].Value.ToString();
                stufnametextBox1.Text = selectedrow.Cells["Stu_Fname"].Value.ToString();
                stulnametextBox2.Text = selectedrow.Cells["Stu_Lname"].Value.ToString();
                stupalnametextBox1.Text = selectedrow.Cells["Pa_Lname"].Value.ToString();
                stuparentnametextBox3.Text = selectedrow.Cells["Pa_Fname"].Value.ToString();
                stuPaphonetextBox.Text = selectedrow.Cells["Pa_PhoneNum"].Value.ToString();
                dateTimePicker1.Text = selectedrow.Cells["Stu_Date"].Value.ToString();
                dateTimePicker1.Enabled = true;




            }
            catch (Exception err)
            {
            }
        }
        #endregion
        #region when the student cliked  on the delete btn

        private void studeletebtn_Click(object sender, EventArgs e)
        {
            if (stufnametextBox1.Text == "" || stulnametextBox2.Text == "" || stugendercomboBox1.Text == "" || stugradecomboBox2.Text == "" || stusectioncomboBox3.Text == "" || dateTimePicker1.Text == "" || stuparentnametextBox3.Text == "" || stupalnametextBox1.Text == "" || stupatypecomboBox1.Text == "" || stuPaphonetextBox.Text == "")
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you Sure\n You Want Delete a Student", "Delete",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool Result = dbcode.DeletStudent(stuidtextBox.Text);
                    if (Result == true)
                    {
                        stufnametextBox1.Clear();
                        stulnametextBox2.Clear();
                        stupalnametextBox1.Clear();
                        stupatypecomboBox1.SelectedIndex = -1;
                        stugendercomboBox1.SelectedIndex = -1;
                        stugradecomboBox2.SelectedIndex = -1;
                        stusectioncomboBox3.SelectedIndex = -1;
                        stuparentnametextBox3.Clear();
                        stuPaphonetextBox.Clear();
                        stuidtextBox.Clear();
                        dateTimePicker1.Enabled = false;
                        MessageBox.Show("User Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed Plese Try Again");
                    }
                    relodform();
                }
            }
        }
        #endregion
        #region when the student clike on the refresh database
        private void clearbtn_Click(object sender, EventArgs e)
        {
            stufnametextBox1.Clear();
            stulnametextBox2.Clear();
            stupalnametextBox1.Clear();
            stupatypecomboBox1.SelectedIndex = -1;
            stugendercomboBox1.SelectedIndex = -1;
            stugradecomboBox2.SelectedIndex = -1;
            stusectioncomboBox3.SelectedIndex = -1;
            stuparentnametextBox3.Clear();
            stuPaphonetextBox.Clear();
            stuidtextBox.Clear();
            relodform();
        }
        #endregion
        #region when the student cliked on the serach btn by id

        private void stusearchbyidbtn_Click(object sender, EventArgs e)
        {
            if (stusearchbyidtextBox1.Text != "")
            {

                dbcode.SearchStudent(stusearchbyidtextBox1.Text);
                dgvstudent.DataSource = dbcode.SearchStudent(stusearchbyidtextBox1.Text).Tables[0];
            }
        }
        #endregion
        #region when the student cliked on the sersch btn by name
        private void stusearchbynamebtn_Click(object sender, EventArgs e)
        {
            if (stusearchbynametextBox2.Text != "")
            {
                dbcode.SearchStudentByName(stusearchbynametextBox2.Text);
                dgvstudent.DataSource = dbcode.SearchStudentByName(stusearchbynametextBox2.Text).Tables[0];
            }
        }
        #endregion

        #region when the student cliked on the student tool menustrip
        private void toolStripCratebtn_Click(object sender, EventArgs e)
        {
            crateuserbtn_Click(null, null);
        }

        private void toolStripUpdatedbtn_Click(object sender, EventArgs e)
        {
            stuupdatebtn_Click(null, null);
        }

        private void toolStripDeletebtn_Click(object sender, EventArgs e)
        {
            deletuserbtn_Click(null, null);
        }

        private void toolStripSearchbtn_Click(object sender, EventArgs e)
        {
            stusearchbyidbtn_Click(null, null);
        }
#endregion

        #region to lof off
        private void LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 LG = new Form1();
            LG.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LOGOUT_Click(null, null);
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            LOGOUT_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGOUT_Click(null, null);
        }
        #endregion

        #region when insert teacher button is cliked
        private void techcratebtn_Click(object sender, EventArgs e)
        {

            if (techfnametextBox.Text == "" || techlnametextBox.Text == "" || techedustatustextBox.Text == "" )
            {
                MessageBox.Show("You have left a Required field empty", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                bool inserted;
                inserted = dbroom.InsertTeachers(techfnametextBox.Text, techlnametextBox.Text, techedustatustextBox.Text);

                if (inserted == true)
                {
                    techfnametextBox.Clear();
                    techlnametextBox.Clear();
                    techedustatustextBox.Clear();
                    MessageBox.Show("Room Teacher add sucsussfully ");
                }
                else
                {
                    MessageBox.Show("Room Teacher not add successfully");
                }
                relodform();
            }

        }
        #endregion
       
        #region search teacher by thier name
        private void techbtn_Click(object sender, EventArgs e)
       {
           if (techsearchtextBox.Text != "")
           {

               MessageBox.Show("the teacher you looking for is not present in the system", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);     

           }
           else
           {
               dbroom.SearchTeahertByName(techsearchtextBox.Text);
               dgvtechers.DataSource = dbroom.SearchTeahertByName(techsearchtextBox.Text).Tables[0];
           }

        }
        #endregion
        #region when updateroomtehcher is clik
       
        private void techupdatebtn_Click(object sender, EventArgs e)
        {
            
                bool valied = true;
                DialogResult result = MessageBox.Show("Are you Sure\n You Want UPdate room teacher", "Update",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    if (valied == true)
                    {
                        bool Updated;
                        Updated = dbroom.UpdateRoomTeacher(techuseridtextbox.Text, techupfnametextBox.Text, techupfnametextBox.Text, techupedustatustextBox.Text);
                       
                        if (Updated == true)
                        {
                           techfnametextBox.Clear();
                            techlnametextBox.Clear();
                            techuseridtextbox.Clear();
                            techedustatustextBox.Clear();
                            MessageBox.Show("Room Teacher sucsussfully Updated");
                        }
                        else
                        {
                            MessageBox.Show("Unabel To Updated");
                        }
                        relodform();
                    }

                
            }
        } 
#endregion

      private void techdeletebtn_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Are you Sure\n You Want Delte a Room Teacher", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   
                    bool Result = dbroom.DeletRoomTeacher(techuseridtextbox.Text);
                    if (Result == true)
                    {
                        techuseridtextbox.Clear();
                        techfnametextBox.Clear();
                        techlnametextBox.Clear();
                        techedustatustextBox.Clear();
                        MessageBox.Show("Room Teacher Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed Plese Try Again");
                    }
                    relodform();
                }
            
        }

      

      private void dgvtechers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
          DataGridViewRow SelectedRow = null;
          try
          {
              
              SelectedRow=dgvtechers.SelectedRows[0];

             techupfnametextBox.Text = SelectedRow.Cells["Teaher_Name"].Value.ToString();
             techuplnametextBox.Text = SelectedRow.Cells["Teacher_Lname"].Value.ToString();
             techupedustatustextBox.Text = SelectedRow.Cells["Teacher_Status"].Value.ToString();
             //techuseridtextbox.Text = SelectedRow.Cells["Teacher_Id"].Value.ToString();
             techuseridtextbox.Text = SelectedRow.Cells["Teacher_Id"].Value.ToString();
          }
          catch (Exception err)
          {
          } 
      }


      #region administrator file menu stripe
      private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
      {
          BACKUP frms = new BACKUP();
         frms.Show();
      }

      private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
      {
          Form1 frmsd = new Form1();
          frmsd.Show();
          this.Hide();
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
          Application.Exit();
      }
      #endregion

      private void allStudentReportToolStripMenuItem_Click(object sender, EventArgs e)
      {
          allstudentreport frs = new allstudentreport();
          frs.Show();
      }

      private void allTeachersReportToolStripMenuItem_Click(object sender, EventArgs e)
      {

          teacher_report frs = new teacher_report();
          frs.Show();
      }

      private void techupedustatustextBox_TextChanged(object sender, EventArgs e)
      {
                }

      private void stufnametextBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void dgvstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void crateusertab_Click(object sender, EventArgs e)
      {

      }

     
      











    }
}
