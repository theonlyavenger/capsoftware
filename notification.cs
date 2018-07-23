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
namespace notification
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

            listBoxdisplay.HorizontalScrollbar = true;
            cbmessage.SelectedIndex = 0;
            this.MaximizeBox = false;
            rbselect.Checked = true;

            InitializeDb();


            displayData();
            resize();


        }

        private void InitializeDb()
        {
            server = "localhost";
            database = "compu";
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
                string query = "SELECT id,name,age,email FROM student ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    clbstudlist.Items.Add(reader["id"].ToString() + "   " + reader["name"].ToString());
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
        private void resize()
        {
            int x, y, a, b;
            y = panel1.Size.Height;
            x = panel1.Size.Width;

            a = grpboxmessage.Size.Height;
            b = grpboxmessage.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            grpboxmessage.Left = halfx;
            grpboxmessage.Top = halfy;
        }

        private void btnselect_Click_1(object sender, EventArgs e)
        {

            foreach (string item in clbstudlist.CheckedItems)
            {
               
               

               listBoxdisplay.Items.Add(item);//here

            }


        }
        private void rbselect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtype_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void mailApi()
        {


        }



        private void btnsend_Click_1(object sender, EventArgs e)
        {
            if (rbtype.Checked == true)
            {
                rbselect.Checked = false;
                string message = tbmessage.Text.ToString();
                sendMail(message);
            }
            else if (rbselect.Checked == true)
            {
                string message = cbmessage.SelectedItem.ToString();
                sendMail(message);
            }


            tbmessage.Clear();
        }

        private void sendMail(string message)
        {
            foreach (string obj in listBoxdisplay.Items)
            {
               // MessageBox.Show(obj);
                ArrayList emailArray = new ArrayList();
                con.Open();
                string query = "SELECT email FROM student where id='"+obj+"'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    emailArray.Add(reader["email"]);
                }
                foreach (string email in emailArray)
                {


                    try
                    {
                        SendEmailApi(email, "Computronics: Notification", message);
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











    }
}

