using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace phonesmsnew.code
{
    public class ManageDb
    {
       //Data Source=yeshi;Initial Catalog=Music_DB;Integrated Security=True
        //Data Source=DARKBIT;Initial Catalog="C:\USERS\ARSEMA\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\PHONESMSNEW\PHONESMSNEW\SCHOOL.MDF";Integrated Security=True
        public static string conString = @"Data Source=DARKBIT;Initial Catalog=C:\USERS\ARSEMA\DOCUMENTS\VISUAL STUDIO 2010\PROJECTS\PHONESMSNEW\PHONESMSNEW\SCHOOL.MDF;Integrated Security=True";
        
        public SqlConnection con = new SqlConnection(conString);

        #region login users
        public DataSet LogUser(string username, string password, string role)
        {
            //Gets a user from fhe data base:= if avalabel it retuns info about the user if not it returns null

            string sqlGetUser = "SELECT * FROM PROUSER WHERE  User_Name=@user_name AND User_Pass=@user_pass";

            SqlCommand cmd = new SqlCommand(sqlGetUser, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@user_name", username);
            cmd.Parameters.AddWithValue("@user_pass", password);
            // cmd.Parameters.AddWithValue("@role", role);

            try
            {
                con.Open();
                adp.Fill(ds, "LogUser");
            }

            finally
            {
                con.Close();
            }

            return ds;

        }
        #endregion
        #region forger user passowrd
        public DataSet FORGETPASSWORD(string ans,string secq)
        {
            
           
            string sqlforget = "SELECT * FROM PROUSER WHERE User_Ans=@ans AND Secu_Qu=@secq";
            SqlCommand cmd = new SqlCommand(sqlforget, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@ans", ans);
            cmd.Parameters.AddWithValue("@secq", secq);

           try
            {
                con.Open();
                adp.Fill(ds, "forget");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return ds; 
        }
        #endregion

        #region  allabout users
        #region crateuser
        public bool CrateUser(string role, string user_name, string user_password)
        {
            int inserted = 0;
            string sqlInserteUser = "INSERT INTO PROUSER (Role,User_Name, User_Pass ) VALUES (@role,@user_name, @user_pass )";
            SqlCommand cmd = new SqlCommand(sqlInserteUser, con);

            cmd.Parameters.AddWithValue("@user_name", user_name);
            cmd.Parameters.AddWithValue("@user_pass", user_password);
            cmd.Parameters.AddWithValue("@role", role);
            


            try
            {
                con.Open();
                inserted = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (inserted > 0)     //inserte is SuccesFull
                return true;
            else                 //inserte Failled
                return false;
        }
        #endregion
        #region getalluser
        public DataSet GetAllUsers()
        {
            string sqlAllUsers = "SELECT * FROM PROUSER";
            SqlCommand cmd = new SqlCommand(sqlAllUsers, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet dataset = new DataSet();

            try
            {
                con.Open();
                adp.Fill(dataset, "All Users");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return dataset; // retun search result
        }
        #endregion
        #region updateuser
        public bool UpdateUser(string role, string user_name, string user_password, string user_id)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE PROUSER SET Role=@role,User_Name=@user_name,User_Pass=@user_password  WHERE User_Id=@user_id";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@user_name", user_name);
            cmd.Parameters.AddWithValue("@user_password", user_password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@user_id", user_id);


            try
            {
                con.Open();
                Updated = cmd.ExecuteNonQuery();
            }
            /* catch (Exception err)
             {

             }*/
            finally
            {
                con.Close();
            }

            if (Updated > 0)     //Update is SuccesFull
                return true;
            else                 //Update Failled
                return false;
        }
        #endregion
        #region deletuser
        public bool DeletUser(string user_id)
        {
            int deleted = 0;
            string sqlUpdateUser = "DELETE FROM PROUSER WHERE User_Id=@user_id";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@user_id", user_id);

            try
            {
                con.Open();
                deleted = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (deleted > 0)     //delete is SuccesFull
                return true;
            else                 //delete Failled
                return false;

        }
        #endregion
        #region searchuserbyid
        public DataSet SearchUser(string userId)
        {
            string sqlSearchUser = "SELECT * FROM PROUSER WHERE User_Id=@user_id";
            SqlCommand cmd = new SqlCommand(sqlSearchUser, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@user_id", userId);

            try
            {
                con.Open();
                adp.Fill(ds, "Search Result");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }
        #endregion
        #region searchuserbyname
        public DataSet SearchUserByName(string userId)
        {
            string sqlSearchUserbyname = "SELECT * FROM PROUSER WHERE User_Name=@user_name";
            SqlCommand cmd = new SqlCommand(sqlSearchUserbyname, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@user_name", userId);

            try
            {
                con.Open();
                adp.Fill(ds, "Search Result");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }
        #endregion
        #endregion
       
        #region insertstudent
        public bool InsertStudent(string fname, string lname, string sex,string grade,string sec,string date,string pafname,string palname,string pasex,string phone)
        {
            int inserted = 0;
            string sqlInserteStudent = "INSERT INTO STUDENT (Stu_Fname,Stu_Lname,Stu_Sex,Stu_Grade,Stu_Sec,Stu_Date,Pa_Fname,Pa_Lname,Pa_sex,Pa_PhoneNum) VALUES (@fname,@lname, @sex,@grade,@sec,@date ,@pafname,@palname,@pasex,@phone)";
            SqlCommand cmd = new SqlCommand(sqlInserteStudent, con);

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname",lname);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@grade",grade);
            cmd.Parameters.AddWithValue("@sec", sec);
            cmd.Parameters.AddWithValue("@date",date);
            cmd.Parameters.AddWithValue("@pafname",pafname);
            cmd.Parameters.AddWithValue("@palname", palname);
            cmd.Parameters.AddWithValue("@pasex", pasex);
            cmd.Parameters.AddWithValue("@phone",phone);


            try
            {
                
                con.Open();
                inserted = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (inserted > 0)     //inserte is SuccesFull
                return true;
            else                 //inserte Failled
                return false;
        }
        #endregion
        #region getallstudent
        public DataSet GetAllStudent()
        {
            string sqlAllStudent = "SELECT * FROM STUDENT";
            SqlCommand cmd = new SqlCommand(sqlAllStudent, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet dataset = new DataSet();

            try
            {
                con.Open();
                adp.Fill(dataset, "All Student");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return dataset; // retun search result
        }
        #endregion
        #region updatestudent
        public bool UpdateStudent(string stu_id, string fname, string lname, string sex, string grade, string sec, string date, string pafname, string palname, string pasex, string phone)
        {
            int Updated = 0;
            string sqlUpdateStudent = "UPDATE STUDENT SET   Stu_Fname=@fname,Stu_Lname=@lname,Stu_Sex=@sex,Stu_Grade=@grade,Stu_Sec=@sec,Stu_Date=@date,Pa_Fname=@pafname,Pa_Lname=@palname,Pa_sex=@pasex,Pa_PhoneNum=@phone WHERE Stu_Id=@stu_id";
           
                 
            SqlCommand cmd = new SqlCommand(sqlUpdateStudent, con);

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@sec", sec);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@pafname", pafname);
            cmd.Parameters.AddWithValue("@palname", palname);
            cmd.Parameters.AddWithValue("@pasex", pasex);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@stu_id", stu_id);


            try
            {
                con.Open();
                Updated = cmd.ExecuteNonQuery();
            }
             catch (Exception err)
             {

             }
            finally
            {
                con.Close();
            }

            if (Updated > 0)     //Update is SuccesFull
                return true;
            else                 //Update Failled
                return false;
        }
        #endregion
        #region deletstudent
        public bool DeletStudent(string stu_id)
        {
            int deleted = 0;
            string sqlDeleteStudent = "DELETE FROM STUDENT WHERE Stu_Id=@stu_id";
            SqlCommand cmd = new SqlCommand(sqlDeleteStudent, con);

            cmd.Parameters.AddWithValue("@stu_id", stu_id);

            try
            {
                con.Open();
                deleted = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            if (deleted > 0)     //delete is SuccesFull
                return true;
            else                 //delete Failled
                return false;

        }
        #endregion
        #region searchuserbyid
        public DataSet SearchStudent(string stuId)
        {
            string sqlSearchStudent = "SELECT * FROM STUDENT WHERE Stu_Id=@stu_id";
            SqlCommand cmd = new SqlCommand(sqlSearchStudent, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@stu_id", stuId);

            try
            {
                con.Open();
                adp.Fill(ds, "Search Result");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }
        #endregion
        #region searchustudentbyname
        public DataSet SearchStudentByName(string stuname)
        {
            string sqlSearchstudentbyname = "SELECT * FROM STUDENT WHERE Stu_Fname=@Stu_name";
            SqlCommand cmd = new SqlCommand(sqlSearchstudentbyname, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@Stu_name", stuname);

            try
            {
                con.Open();
                adp.Fill(ds, "Search Result");
            }
            catch (Exception err)
            {

            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }
        #endregion


        public DataTable GetallStudentBySection(string grade,string sec)
        {
             //string sqlAllStudentbygrade = "SELECT * FROM STUDENT WHERE Stu_Grade=@grade AND Stu_Sec=@sec";
             string sqlInserteUser = "SELECT Stu_Fname,Stu_Lname,Pa_Fname,Pa_sex,Pa_PhoneNum FROM STUDENT WHERE Stu_Grade=@grade AND Stu_Sec=@sec";
             SqlCommand cmd = new SqlCommand(sqlInserteUser, con);

             SqlDataAdapter adp = new SqlDataAdapter(cmd);

             DataTable dt = new DataTable("all users");
             //DataTable dt = new DataTable();
             cmd.Parameters.AddWithValue("@grade", grade);
             cmd.Parameters.AddWithValue("@sec", sec);

             try
             {
                 con.Open();
                 adp.Fill(dt);
             }
             catch (Exception err)
             {

             }
             finally
             {
                 con.Close();
             }

             return dt;
         
        }

   
       

    }
}
