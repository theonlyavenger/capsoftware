using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;

namespace Dashboard
{
    public partial class notification : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {
            btnremove.Enabled = false;

            listBoxdisplay.HorizontalScrollbar = true;
            cbmessage.SelectedIndex = 0;
            this.MaximizeBox = false;
            rbselect.Checked = true;
            

            InitializeDb();


            displayData();
            


        }

        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = " ";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);

        }

        private void displayData()
        {
            try
            {
                con.Open();
                string query = "SELECT stud_id,stud_name,stud_alumni FROM student ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["stud_alumni"].ToString() != "YES")
                    {
                        clbstudlist.Items.Add(reader["stud_id"].ToString() + "   " + reader["stud_name"].ToString());//fetching & adding id & name to checkedlistbox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        
        private void addHistory(string source,string msg)
        {
            string date = DateTime.Now.ToString();
           
            try
            {
                con.Open();
                for (int i = 0; i < listBoxdisplay.Items.Count; i++)
                {
                    //inserting values into notification table
                    string query = "insert into notification (notification_date,notification_source,notification_destination,notification_message)values('" + date + "','" + source + "','"+listBoxdisplay.Items[i].ToString()+"','" + msg + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }



        private void btnsend_Click_1(object sender, EventArgs e)
        {
           
        }

        private void sendMail(string message)
        {
            foreach (string obj in listBoxdisplay.Items)
            {
               // MessageBox.Show(obj);
                ArrayList emailArray = new ArrayList();         //array creation for storing the emails
                con.Open();
                string query = "SELECT stud_email FROM student where stud_id='"+obj+"'";  //fetching emailid using object
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    emailArray.Add(reader["stud_email"]);            //adding all the emails from db to array
                }
                foreach (string email in emailArray)
                {


                    try
                    {
                        SendEmailApi(email, "Computronics: Notification", message); //sending mail to each emailid present in the array
                        MessageBox.Show("Mail sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Message not emailed: " + ex.Message.ToString());
                    }
                    finally
                    {
                        con.Close();
                        reader.Close();
                    }
                }

            }
        }
        //mail API for sending mails
        public static void SendEmailApi(string emailTo, string subject, string body)
        {
            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                Credentials = new NetworkCredential("myapi0@outlook.com", "MyTestApi1"),
                EnableSsl = true
            };

            client.Send("myapi0@outlook.com", emailTo, subject, body);
        }





        private void btnsms_Click(object sender, EventArgs e)
        {

        }

      
   

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            btnremove.Enabled = true;
            foreach (string item in clbstudlist.CheckedItems)//for each checked item in the listbox
            {
                listBoxdisplay.Items.Add(item);//adding only the checked items from checkedlistbox to the listbox
                listBoxdisplay.SelectedIndex = 0;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            for (int v = 0; v < listBoxdisplay.SelectedItems.Count; v++)
            {
               
                listBoxdisplay.Items.Remove(listBoxdisplay.SelectedItems[v]);
               
            }
             
        }

        private void listBoxdisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxdisplay.SelectedIndex = 0;
            }
            catch (Exception)
            {

                btnremove.Enabled = false;
            }
            
        }

        private void rbselect_CheckedChanged(object sender, EventArgs e)
        {
            cbmessage.Enabled = true;
            tbmessage.Enabled = false;
          
        }

        private void tbmessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtype_CheckedChanged(object sender, EventArgs e)
        {
            cbmessage.Enabled = false;
            tbmessage.Enabled = true;
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (rbtype.Checked == true)
            {
                rbselect.Checked = false;
                string message = tbmessage.Text.ToString();
                sendMail(message);              //selecting text from typed message and then sendmail
                addHistory("mail", message);
            }
            else if (rbselect.Checked == true)
            {

                string message = cbmessage.SelectedItem.ToString();
                sendMail(message);              //selecting text from template and then sendmail
                addHistory("mail", message);
            }
            tbmessage.Clear();
            this.Cursor = Cursors.Default;
        }
    }
}