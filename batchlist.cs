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
    public partial class batchlist : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        public batchlist()
        {
            InitializeComponent();
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

        private void fillCombobox()
        {
            string query = "SELECT DISTINCT stud_course from batch";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbCourse.Items.Add(reader["stud_course"].ToString());
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

        private void fillCombobox2()
        {
            string query = "SELECT DISTINCT batch_no from batch";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBatch.Items.Add(reader["batch_no"].ToString());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fetchComboboxValues();
        }

        private void fetchComboboxValues()
        {
            string course = cmbCourse.Text;
            string batch = cmbBatch.Text;

            generateDgv(course, batch);
        }


        private void generateDgv(string course, string batch)
        {
            dataTable.Rows.Clear();
            dataTable.Refresh();
            // Adding column with their properties
            dataTable.ColumnCount = 2;
            dataTable.RowTemplate.Height = 20;

            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "sno";

            dataTable.Columns[1].HeaderText = "STUDENT NAME";
            dataTable.Columns[1].Name = "sname";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string query = "SELECT * from batch where stud_course = '"+ course +"' and batch_no = '"+batch+"'";

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //string id = reader["batch_id"].ToString();
                    //string batchno = reader["batch_no"].ToString();
                    string studentid = reader["stud_id"].ToString();
                    string studentname = reader["stud_name"].ToString();
                    //string studentcourse = reader["stud_course"].ToString();
                    //string batchtiming = reader["batch_timing"].ToString();
                    dataTable.Rows.Add(studentid, studentname);
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

        private void batchlist_Load(object sender, EventArgs e)
        {
            InitializeDb();
            fillCombobox();
            fillCombobox2();
            cmbCourse.SelectedIndex = 0;
            cmbBatch.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBatch.Enabled = true;
        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
        }
    }
}
