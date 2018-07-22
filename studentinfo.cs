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
    public partial class Studentinfo : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        int ID;
        public Studentinfo(int id)
        {
            InitializeComponent();
            ID = id;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            InitilizeDb();
            FetchDetails(ID);
        }
        private void FetchDetails(int Key)
        {
            string query = "SELECT * from student WHERE stud_id = " + Key + " ";
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblId.Text = reader["stud_id"].ToString();
                    lblName.Text = reader["stud_name"].ToString();
                    lblPhone.Text = reader["stud_pno"].ToString();
                    lblCell.Text = reader["stud_cell"].ToString();
                    lblAddress.Text = reader["stud_address"].ToString();
                    lblEmail.Text = reader["stud_email"].ToString();
                    lblDoj.Text = reader["stud_doj"].ToString();
                    lblCourseRegistered.Text = reader["stud_courseSelected"].ToString();
                    lblCourseFees.Text = reader["stud_courseFee"].ToString();
                    //lblPaymentStatus.Text = reader["start"].ToString();
                    lblEduPersuing.Text = reader["stud_educationpersuing"].ToString();
                    lblCollege.Text = reader["stud_college"].ToString();
                    lblBranch.Text = reader["stud_branch"].ToString();
                    lblWork.Text = reader["stud_details_of_work"].ToString();
                    lblAge.Text = reader["stud_age"].ToString();
                    lblDob.Text = reader["stud_dob"].ToString();
                    lblReference.Text = reader["stud_reference"].ToString();
                    lblPlace.Text = reader["stud_place"].ToString();
                    lblSign.Text = reader["stud_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
      
    }
}
