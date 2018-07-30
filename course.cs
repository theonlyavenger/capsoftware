using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coursefi
{
    public partial class course1 : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string password;
        DataTable dt;
        public course1()
        {
            InitializeComponent();
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
            dgv.Visible = false;
            add.Visible = false;
            

            InitializeDb();

        }

       
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv.Visible = true;
            dt = new DataTable();
            dgv.DataSource = dt;
            dt.Columns.Add("id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Fees");
            dt.Columns.Add("Duration");
            con.Open();
            String query = "select * from course";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dt.Rows.Add(reader["course_id"].ToString(), reader["course_name"].ToString(), reader["course_fees"].ToString(), reader["course_duration"].ToString());
            }
            con.Close();

        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
    //    private void addToolStripMenuItem_Click(object sender, EventArgs e)
       // {
           // add.Visible = true;
           // dgv.Visible = false;

       // }

        private void submit_Click(object sender, EventArgs e)
        {

            string query = "insert into course(course_name,course_fees,course_duration)values('" + textBoxcoursenm.Text + "','" + textBoxcoursef.Text + "' ,'" + textBoxcoursed.Text + "')";
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add.Visible = true;
            dgv.Visible = false;

        }

        
        }


    }
