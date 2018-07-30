using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace progressform2
{
    public partial class progressform : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        DataTable dt;
        public progressform()
        {
            InitializeComponent();
        }

        private void progressform2_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            dataTable.DataSource = null;
            InitilizeDb();
            DisplayData();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayData()
        {
            // Adding column with their properties
            dataTable.ColumnCount = 2;

            dataTable.Columns[0].HeaderText = "BATCH";
            dataTable.Columns[0].Name = "batch";

            dataTable.Columns[1].HeaderText = "NAME";
            dataTable.Columns[1].Name = "name";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewCheckBoxColumn chkexam = new DataGridViewCheckBoxColumn();
            dataTable.Columns.Add(chkexam);
            chkexam.HeaderText = "EXAM";
            chkexam.Name = "chkexam";
            chkexam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewCheckBoxColumn chkcertificate = new DataGridViewCheckBoxColumn();
            dataTable.Columns.Add(chkcertificate);
            chkcertificate.HeaderText = "CERTIFICATE";
            chkcertificate.Name = "chkcertificate";
            chkcertificate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


           /* dataTable.Columns[4].HeaderText = "DATE OF JOINING";
            dataTable.Columns[4].Name = "doj";
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[5].HeaderText = "PAYMENT STATUS";
             dataTable.Columns[5].Name = "payment";
             dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; */

          
          

            string query = "SELECT batch_no,stud_name  from batch";
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                  
                  
                        string batch = reader["batch_no"].ToString();
                        string name = reader["stud_name"].ToString();

                        dataTable.Rows.Add(batch, name);
                    
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void headerpannel_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                   }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
