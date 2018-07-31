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
    public partial class course : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string password;
       
        public course()
        {
            InitializeComponent();

            //Select the entire row rather than selecting only the individual blocks
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void InitializeDb()
        {
            
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            password = "";
            String constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(constr);



        }

        private void course1_Load(object sender, EventArgs e)
        {
            InitializeDb();
            loadData();
        }

        private void loadData()
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Refresh();
            // Adding column with their properties
            dgv.ColumnCount = 4;

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[0].Name = "id";

            dgv.Columns[1].HeaderText = "COURSE NAME";
            dgv.Columns[1].Name = "name";
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns[2].HeaderText = "FEES";
            dgv.Columns[2].Name = "fees";
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns[3].HeaderText = "DURATION in Months";
            dgv.Columns[3].Name = "duration";
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            try
            {
                con.Open();
                String query = "select * from course";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgv.Rows.Add(reader["course_id"].ToString(), reader["course_name"].ToString(), reader["course_fees"].ToString(), reader["course_duration"].ToString());
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

        private void submit_Click_1(object sender, EventArgs e)
        {
            string query = "insert into course(course_name,course_fees,course_duration) values('" + textBoxcoursenm.Text + "','" + textBoxcoursef.Text + "' ,'" + textBoxcoursed.Text + "')";
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
                loadData();
            }
        }
        }


    }
