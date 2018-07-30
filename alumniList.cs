using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Dashboard
{
    public partial class alumnilist : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        DataTable dt;
        public alumnilist()
        {
            InitializeComponent();

            //Select the entire row rather than selecting only the individual blocks
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void studentlist_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dataTable.DataSource = null;
            InitilizeDb();
            DisplayData();
        }

        public void DisplayData()
        {
            // Adding column with their properties
            dataTable.ColumnCount = 4;
            
            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "id";
            dataTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[1].HeaderText = "NAME";
            dataTable.Columns[1].Name = "name";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataTable.Columns[2].HeaderText = "PHONE (M)";
            dataTable.Columns[2].Name = "phone";
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataTable.Columns[3].HeaderText = "COMPANY";
            dataTable.Columns[3].Name = "course";
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "PHOTO";
            img.Name = "photo";
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch; 
            dataTable.Columns.Add(img);

            string query = "SELECT stud_photo,stud_id,stud_name,stud_cell,stud_alumni,alumni_comapnyname from student";
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["stud_alumni"].ToString() == "YES")
                    {
                        string id = reader["stud_id"].ToString();
                        string name = reader["stud_name"].ToString();
                        string cell = reader["stud_cell"].ToString();
                        string company = reader["alumni_comapnyname"].ToString();
                        byte[] imagedb = (byte[])(reader["stud_photo"]);
                        if (imagedb == null)
                        {
                            img.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(imagedb);
                            img.Image = Image.FromStream(ms);
                        }
                        
                        dataTable.Rows.Add(id, name, cell, company, img.Image);
                    }
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

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select the id column from the row and store it in id variable
            try
            {
                int id = Convert.ToInt32(dataTable.SelectedRows[0].Cells["id"].Value.ToString());
                string type = "alumni";
                Studentinfo info = new Studentinfo(id, type);
                info.Show();
            }
            catch (Exception)
            {
                
            }
            
        }     
    }
}
