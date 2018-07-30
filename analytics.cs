using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
namespace Dashboard
{
    public partial class analytics : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        public analytics()
        {
            InitializeComponent();
            InitializeDb();
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

        private void analytics_Load(object sender, EventArgs e)
        {
            ArrayList coursesavailable = new ArrayList();
            string coursequery = "SELECT DISTINCT course_name from course";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(coursequery, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coursesavailable.Add(reader["course_name"].ToString());
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

            foreach (string courseselected in coursesavailable)
            {
                string query = "SELECT count(*) as count, stud_courseSelected from student where stud_courseSelected ='"+courseselected+"'";
                try
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int count = Convert.ToInt32(reader["count"].ToString());
                        string course = reader["stud_courseSelected"].ToString();
                        coursechart.Series["courses"].Points.AddXY(course, count);
                        coursechart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                        coursechart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
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
        }
    }
}
