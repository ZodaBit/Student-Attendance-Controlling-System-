using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace phonesmsnew
{
    public partial class SMSA : Form
    {
        code.ManageDb dbcode = new code.ManageDb();
        DataTable abssentstu = new DataTable();
        public SMSA()
        {
            InitializeComponent();
        }

        #region private coll varialbles
        SerialPort port = new SerialPort();
        code.SMSCODE objclsSMS = new code.SMSCODE();
        //ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();

        #endregion


        public SMSA(DataTable dt)
        {
            InitializeComponent();
            abssentstu = dt;
        }

        private void SMSA_Load(object sender, EventArgs e)
        {
            dgvabsent.DataSource = abssentstu;


            try
            {
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    this.cboPortName.Items.Add(port);
                }
                #endregion

                tabSMSapplication.TabPages.Remove(tbSendSMS);
                btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {

            }

           

        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Open communication port 
                this.port = objclsSMS.OpenPort(this.cboPortName.Text, Convert.ToInt32(this.cboBaudRate.Text), Convert.ToInt32(this.cboDataBits.Text), Convert.ToInt32(this.txtReadTimeOut.Text), Convert.ToInt32(this.txtWriteTimeOut.Text));

                if (this.port != null)
                {
                    this.gboPortSettings.Enabled = false;

                    this.statusbar1.Text = "Modem is connected at PORT " + this.cboPortName.Text;
                    
                   // MessageBox.Show("Modem is connected at PORT " + this.cboPortName.Text);


                    //Add tab pages
                    this.tabSMSapplication.TabPages.Add(tbSendSMS);
                    //MessageBox.Show("connected at" + this.cboPortName.Text);
                    this.lblConnectionStatus.Text = "Connected at " + this.cboPortName.Text;
                    this.btnDisconnect.Enabled = true;

                }

                else
                {
                    //MessageBox.Show("Invalid port settings");
                    this.statusbar1.Text = "Invalid port settings";
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.gboPortSettings.Enabled = true;
                objclsSMS.ClosePort(this.port);

                //Remove tab pages
                this.tabSMSapplication.TabPages.Remove(tbSendSMS);
                //MessageBox.Show("not connected");

                this.lblConnectionStatus.Text = "Not Connected";
                this.btnDisconnect.Enabled = false;
               

            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            //.............................................. Send SMS ....................................................
            try
            {

                if (objclsSMS.sendMsg(this.port, this.txtSIM.Text, this.txtMessage.Text))
                {
                   // MessageBox.Show("Message has sent successfully");
                    this.statusbar1.Text = "Message has sent successfully";


                }
                else
                {
                   // MessageBox.Show("Failed to send message");
                    this.statusbar1.Text = "Failed to send message";

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void sendsmstoall_Click(object sender, EventArgs e)
        {
            string Message1;
            for (int i = 0; i < dgvabsent.Rows.Count - 1; i++)
            {
                DataGridViewRow r = dgvabsent.Rows[i];
                string PhoneNumber = r.Cells["Pa_PhoneNum"].Value.ToString();
                string StudentName = r.Cells["Stu_Fname"].Value.ToString();
                Message1 = "Your kid " + StudentName + "have Missed Class Today Please vist us for detail.";

                //send sms
                try
                {

                    if (objclsSMS.sendMsg(this.port, PhoneNumber, Message1))
                    {
                        MessageBox.Show("Message has sent successfully");

                    }
                    else
                    {
                        MessageBox.Show("Failed to send message");

                    }

                }
                catch (Exception ex)
                {

                }

            }
        }

       

        
        
       
     
       

        
    }
}
