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
    public partial class paymentlist : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;

        public paymentlist()
        {
            InitializeComponent();
            //Select the entire row rather than selecting only the individual blocks
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void paymentlist_Load(object sender, EventArgs e)
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
            // Adding column with their properties
            dataTable.ColumnCount = 7;

            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "id";
            dataTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[1].HeaderText = "DATE";
            dataTable.Columns[1].Name = "date";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[2].HeaderText = "NAME";
            dataTable.Columns[2].Name = "name";
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[3].HeaderText = "PAYMENT MODE";
            dataTable.Columns[3].Name = "mode";
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[4].HeaderText = "PAYMENT AMOUNT";
            dataTable.Columns[4].Name = "amount";
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[5].HeaderText = "PAYMENT STATUS";
            dataTable.Columns[5].Name = "status";
            dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[6].HeaderText = "PAYMENT REMAINING";
            dataTable.Columns[6].Name = "remaining";
            dataTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string query = "SELECT * from payment";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["payment_id"].ToString();
                    string date = reader["date"].ToString();
                    string name = reader["stud_name"].ToString();
                    string paymentmode = reader["payment_mode"].ToString();
                    string paymentamount = reader["payment_amount"].ToString();
                    string paymentstatus = reader["payment_status"].ToString();
                    string paymentremaining = reader["payment_remaining_amount"].ToString();

                    dataTable.Rows.Add(id, date, name, paymentmode, paymentamount, paymentstatus, paymentremaining);
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

        private void viewPreviousDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(18);
            payments.Show();
        }
    }
}
