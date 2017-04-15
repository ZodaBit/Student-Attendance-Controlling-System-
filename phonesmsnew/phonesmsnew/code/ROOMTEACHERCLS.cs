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
    class ROOMTEACHERCLS
    {
       
        

        public static string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\Users\Arsema\Documents\Visual Studio 2010\Projects\phonesmsnew\phonesmsnew\school.mdf"";Integrated Security=True;User Instance=True";
        public SqlConnection con = new SqlConnection(conString);

        #region storedstudent attendance in the database
        public bool STOREDSTUDENTATT( string stuname , string stulname , string grade , string section , string date , string stustatus)
        {
            int inserted = 0;
            string sqlInserteUser = "INSERT INTO ATTSTATUS (Stu_Name, Stu_Lname, Stu_Grade, Stu_Sec, Stu_Att_Date, Stu_Staus ) VALUES (@stuname, @stulname, @grade, @section, @date, @stustatus )";
            SqlCommand cmd = new SqlCommand(sqlInserteUser, con);

           
            cmd.Parameters.AddWithValue("@stuname",stuname);
            cmd.Parameters.AddWithValue("@stulname",stulname);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@section", section);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@stustatus",stustatus);

            try
            {
                con.Open();
                inserted = cmd.ExecuteNonQuery();
            }
           /* catch (Exception err)
            {

            }*/
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
        #region  getallstudentattendance
        public DataSet GETALLATT()
        {
            string sqlAllUsers = "SELECT * FROM ATTSTATUS ";
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
        #region update student attendance 
        public bool UPDATESTUDENTATT(string status, string stuatid)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE ATTSTATUS SET Stu_Status=@status WHERE Id=@stuatid";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@status",status);
            
            cmd.Parameters.AddWithValue("@stuatid",stuatid);


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
        #region searchATTSTUDENTBYNAME
        public DataSet SEARCHSTUDENTATTBYNAME(string atstuname)
        {
            string sqlSearchUserbyname = "SELECT * FROM ATTSTATUS  WHERE Stu_Name=@atstuname";
            SqlCommand cmd = new SqlCommand(sqlSearchUserbyname, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@atstuname", atstuname);

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

        #region insertteacher
        public bool InsertTeachers(string fname, string lname,string status)
        {
            int inserted = 0;
            string sqlInsertetch = "INSERT INTO ROOMTEACHER (Teaher_Name,Teacher_Lname,Teacher_Status) VALUES (@fname,@lname, @status)";
            SqlCommand cmd = new SqlCommand(sqlInsertetch, con);

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@status", status);
           

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
        #region getallTeacher
        public DataSet GetAllTeachers()
        {
            string sqlAlltech = "SELECT * FROM ROOMTEACHER ";
            SqlCommand cmd = new SqlCommand(sqlAlltech, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet dataset = new DataSet();

            try
            {
                con.Open();
                adp.Fill(dataset, "All teachers");
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
        #region update roomteacher 
        public bool UpdateRoomTeacher(string tch_id,string fname, string lname, string status)
        {
            int Updated = 0;
            string sqlUpdatetch = "UPDATE ROOMTEACHER SET   Teaher_Name=@fname,Teacher_Lname=@lname,Teacher_Status=@status WHERE Teacher_Id=@tch_id";


            SqlCommand cmd = new SqlCommand(sqlUpdatetch, con);

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@tch_id", tch_id);
            


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
        #region deletst Room Teacher
        public bool DeletRoomTeacher(string tch_id)
        {
            int deleted = 0;
            string sqlDeletetch = "DELETE FROM ROOMTEACHER WHERE Teacher_Id=@tch_id";
            SqlCommand cmd = new SqlCommand(sqlDeletetch, con);

            cmd.Parameters.AddWithValue("@tch_id", tch_id);

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
        
        #region searchTeacherby name
        public DataSet SearchTeahertByName(string tchname)
        {
            string sqlSearchbyname = "SELECT * FROM ROOMTEACHER WHERE Teaher_Name=@tch_name";
            SqlCommand cmd = new SqlCommand(sqlSearchbyname, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Parameters.AddWithValue("@tch_name", tchname);

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
    }
}
