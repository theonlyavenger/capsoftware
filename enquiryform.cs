using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dashboard
{
    public partial class enquiryform : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string password;
        public enquiryform()
        {
            InitializeComponent();
        }

      /*  private void resize()
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
        } */

        private void Form1_Load(object sender, EventArgs e)
        {
            // resize();
            server = "localhost";
            database = "computronics_admission_process";
            uid="root";
            password="";
            String constr="SERVER=" + server+";"+"DATABASE="+ database +";"+"UID="+uid+";"+"PASSWORD="+password+";";
            con = new MySqlConnection(constr);
        }

        private void lblsubmit_Click(object sender, EventArgs e)
        {
            
            string query = "insert into enquiry(enq_date,enq_name,enq_pno,enq_email,course_enquired,enq_educationpursuing,enq_branch,enq_college)values('" + dtpdate.Text + "','" + textboxname.Text + "'," + textboxphoneno.Text + ",'" + textboxemail.Text + "','" + textboxcourseenquired.Text + "','" + textboxcollege.Text + "','" + textboxedupur.Text + "','" + textboxbranch.Text + "')";

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enquiry Added!");
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