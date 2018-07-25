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
    public partial class alumniCompany : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        int ID;
        string companyName;
        public alumniCompany(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void alumniCompany_Load(object sender, EventArgs e)
        {
            donotadd.Checked = true;
            InitilizeDb();
        }

         private void InitilizeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = " ";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            companyName = txtCompanyName.Text;
            addCompanyDetails(companyName);
            this.Close();
        }

        private void add_CheckedChanged(object sender, EventArgs e)
        {
            txtCompanyName.Enabled = true;
            txtCompanyName.Clear();
            txtCompanyName.Focus();

        }

        private void donotadd_CheckedChanged(object sender, EventArgs e)
        {
            txtCompanyName.Enabled = false;
            txtCompanyName.Text = "NOT SPECIFIED";
        }
        private void addCompanyDetails(string companyName)
        {
            string value = "YES";
            string query = "UPDATE student SET stud_alumni = '"+value+"' , alumni_comapnyname = '" + companyName + "' WHERE stud_id = " + ID + "";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alumni Updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }
    }
}
