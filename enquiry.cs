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
    public partial class enquiry : Form
    {
        private MySqlConnection con;
        private ErrorProvider ep = new ErrorProvider();
        string server;
        string database;
        string uid;
        string pwd;

        public enquiry()
        {
            InitializeComponent();
        }

        private void resize()
        {
            int x, y, a, b;
            y = this.Size.Height;
            x = this.Size.Width;

            a = groupBox1.Size.Height;
            b = groupBox1.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            groupBox1.Left = halfx;
            groupBox1.Top = halfy;
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
            resize();
            this.MaximizeBox = false;
            textboxcourseenquired.SelectedIndex = 0;
            InitializeDb();
            
            addToEnquiryList();
           
        }

        private void lblsubmit_Click(object sender, EventArgs e)
        {

            string query = "insert into enquiry(enq_date,enq_name,enq_pno,enq_email,course_enquired,enq_educationpursuing,enq_branch,enq_college)values('" + dtpdate.Text + "','" + textboxname.Text + "'," + textboxphoneno.Text + ",'" + textboxemail.Text + "','" + textboxcourseenquired.Text + "','" + textboxcollege.Text + "','" + textboxedupur.Text + "','" + textboxbranch.Text + "')";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
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

        
        //validating name


        private void textboxname_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private bool ValidateName()
        {
            bool bstatus = true;
            if (textboxname.Text == "")
            {
                ep.SetError(textboxname, "Please enter your Name");
                bstatus = false;
            }
            else
                ep.SetError(textboxname, "");
            textboxname.Focus();
            return bstatus;
        }


        //validating email

        private void textboxemail_Leave(object sender, EventArgs e)
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
           
        //validate course
        private void textboxcourseenquired_Validating(object sender, CancelEventArgs e)
        {
            Validatecoursereq();
        }
        private bool Validatecoursereq()
        {
            bool bstatus = true;
            if (textboxcourseenquired.Text == "")
            {
                ep.SetError(textboxcourseenquired, "please enter  the course enquired");
                bstatus = false;
            }
            else
                ep.SetError(textboxcourseenquired, "");
            textboxcourseenquired.Focus();
            return bstatus;
        }

        //validating college
        private void txtboxcollege_Validating(object sender, CancelEventArgs e)
        {
        Validatecollege();
        }
        
        private bool Validatecollege()
        {
            bool bstatus = true;
            if (textboxcollege.Text == "")
            {
                ep.SetError(textboxcollege, "please enter  the college");
                bstatus = false;
            }
            else
                ep.SetError(textboxcollege, "");
            textboxcollege.Focus();
            return bstatus;
        }

        //edu pursuing
        private void textboxedupur_Validating(object sender, CancelEventArgs e)
        {
            Validateedupur();

        }
          private bool Validateedupur()
        {
            bool bstatus = true;
            if (textboxedupur.Text == "")
            {
                ep.SetError(textboxedupur, "please enter  the education pursing");
                bstatus = false;
            }
            else
                ep.SetError(textboxedupur, "");
            textboxedupur.Focus();
            return bstatus;
        }

        // validating branch

          private void textboxbranch_Validating(object sender, CancelEventArgs e)
          {
              Validatebranch();
          }

        private bool Validatebranch()
          {
              bool bstatus = true;
              if (textboxbranch.Text == "")
              {
                  ep.SetError(textboxbranch, "please enter  the branch");
                 
                  bstatus = false;
              }
              else
                  ep.SetError(textboxbranch, "");
              textboxbranch.Focus();
              return bstatus;
          }
        // validating phone no

          private void textboxphoneno_Leave(object sender, EventArgs e)
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
                      textboxphoneno.Focus();
                      return;
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("" + ex);
              }
          }

          private void addToEnquiryList()
          {
              try
              {
                  con.Open();
                  string query = " SELECT distinct course_name from course";
                  MySqlCommand cmd = new MySqlCommand(query, con);
                  MySqlDataReader reader = cmd.ExecuteReader();
              
                  while(reader.Read())
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
       

        
        }
    }

