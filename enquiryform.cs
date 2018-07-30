using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace enquiry
{
    public partial class enquiryform : Form
    {
        private MySqlConnection con;
        private ErrorProvider ep = new ErrorProvider();
        string server;
        string database;
        string uid;
        string pwd;

        public enquiryform()
        {
            InitializeComponent();
        }

        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = "";
            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // resize();
            this.MaximizeBox = false;
            //  textboxcourseenquired.SelectedIndex = 0;
            InitializeDb();

            addToEnquiryList();

        }

        /* private void lblsubmit_Click(object sender, EventArgs e)
         {

           

         }
         */





        private void addToEnquiryList()
        {
            try
            {
                con.Open();
                string query = " SELECT distinct course_name from course";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    textboxcourseenquired.Items.Add(reader["course_name"].ToString());
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



     // validating phone no
        private void textboxphoneno_Leave_1(object sender, EventArgs e)
        {


            try
            {
                string pattern = @"(?<!\d)\d{10}(?!\d)";
                if (Regex.IsMatch(textboxphoneno.Text, pattern))
                {
                    ep.Clear();
                }
                else
                {
                    ep.SetError(this.textboxphoneno, "phone number must be of 10 digits");
                    //textboxphoneno.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        //validating email
        private void textboxemail_Leave_1(object sender, EventArgs e)
        {

            try
            {
                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (Regex.IsMatch(textboxemail.Text, pattern))
                {
                    ep.Clear();
                }
                else
                {
                    ep.SetError(this.textboxemail, "Please provide valid email address");
                    textboxemail.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }



        private bool validation()
        {
            if (textboxname.Text == "")
            {
                MessageBox.Show("Please enter name");
                textboxname.Focus();
                return false;
            }
            else if (textboxphoneno.Text == "")
            {
                MessageBox.Show("Please enter phone number");
                textboxphoneno.Focus();
                return false;
            }
            else if (textboxemail.Text == "")
            {
                MessageBox.Show("Please enter email id");
                textboxemail.Focus();
                return false;
            }
            else if (textboxcourseenquired.Text == "")
            {
                MessageBox.Show("Please enter course");
                textboxcourseenquired.Focus();
                return false;
            }
            else if (textboxcollege.Text == "")
            {
                MessageBox.Show("Please enter college");
                textboxcollege.Focus();
                return false;
            }
            else if (textboxedupur.Text == "")
            {
                MessageBox.Show("Please enter education pursuing");
                textboxedupur.Focus();
                return false;
            }
            else if (textboxbranch.Text == "")
            {
                MessageBox.Show("Please enter branch");
                textboxbranch.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void lblsubmit_Click_1(object sender, EventArgs e)
        {
            bool result;
            result = validation();

            if(result == true)
            {
                string query = "insert into enquiry(enq_date,enq_name,enq_pno,enq_email,course_enquired,enq_educationpursuing,enq_branch,enq_college)values('" + dtpdate.Text + "','" + textboxname.Text + "'," + textboxphoneno.Text + ",'" + textboxemail.Text + "','" + textboxcourseenquired.Text + "','" + textboxedupur.Text + "','" + textboxbranch.Text + "','" + txtboxcollege.Text + "')";

                try
                {   
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ADDED" );
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
        }
    } 
}
        
        
      
        
    


        

        

    
        

       

     

    



        
        
    


