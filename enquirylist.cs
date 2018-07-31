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
    public partial class enquirylist : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        public enquirylist()
        {
            InitializeComponent();

            //Select the entire row rather than selecting only the individual blocks
            enquiryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void enquirylist_Load(object sender, EventArgs e)
        {
            InitializeDb();
            DisplayData();
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
         public void DisplayData()
        {
            enquiryGridView.DataSource = null;
            enquiryGridView.Rows.Clear();
            enquiryGridView.Refresh();
            // Adding column with their properties
            enquiryGridView.ColumnCount = 9;
            
            enquiryGridView.Columns[0].HeaderText = "ID";
            enquiryGridView.Columns[0].Name = "id";
            enquiryGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            enquiryGridView.Columns[1].HeaderText = "DATE";
            enquiryGridView.Columns[1].Name = "date";
            enquiryGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            enquiryGridView.Columns[2].HeaderText = "NAME";
            enquiryGridView.Columns[2].Name = "name";
            enquiryGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            enquiryGridView.Columns[3].HeaderText = "PHONE (M)";
            enquiryGridView.Columns[3].Name = "phone";
            enquiryGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            enquiryGridView.Columns[4].HeaderText = "EMAIL";
            enquiryGridView.Columns[4].Name = "email";
            enquiryGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            enquiryGridView.Columns[5].HeaderText = "COURSE ENQUIRED";
            enquiryGridView.Columns[5].Name = "enquired";
            enquiryGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            enquiryGridView.Columns[6].HeaderText = "EDUCATION PERSUING";
            enquiryGridView.Columns[6].Name = "education";
            enquiryGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            enquiryGridView.Columns[7].HeaderText = "BRANCH";
            enquiryGridView.Columns[7].Name = "branch";
            enquiryGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            enquiryGridView.Columns[8].HeaderText = "COLLEGE";
            enquiryGridView.Columns[8].Name = "college";
            enquiryGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string query = "SELECT * from enquiry";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["enq_id"].ToString();
                    string date = reader["enq_date"].ToString();
                    string name = reader["enq_name"].ToString();
                    string phone = reader["enq_pno"].ToString();
                    string email = reader["enq_email"].ToString();
                    string course = reader["course_enquired"].ToString();
                    string education = reader["enq_educationpursuing"].ToString();
                    string branch = reader["enq_branch"].ToString();
                    string college = reader["enq_college"].ToString();
                   
                    enquiryGridView.Rows.Add(id, date, name, phone, email,course,education,branch,college);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

         private void newEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
         {
             enquiryform enquiry = new enquiryform();
             enquiry.Show();
         }

         private void backupToolStripMenuItem_Click(object sender, EventArgs e)
         {

         }

         private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
         {

         }
    }
}
