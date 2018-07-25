using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Dashboard
{
    public partial class exportExcel : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        string formname;
        string date;
        public exportExcel()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("dd-MM-yyyy");
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataTable.RowCount - 1; i++)
            {
                for (j = 0; j <= dataTable.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataTable[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs(""+formname+"- "+date, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created in Documents");
        }
        private void admissionTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formname = "Admission";
            btnExport.Visible = true;
            dataTable.Rows.Clear();
            dataTable.Refresh();
            // Adding column with their properties
            dataTable.ColumnCount = 5;
            dataTable.RowTemplate.Height = 120;

            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "id";

            dataTable.Columns[1].HeaderText = "NAME";
            dataTable.Columns[1].Name = "name";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[2].HeaderText = "PHONE (R)";
            dataTable.Columns[2].Name = "phone";
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[3].HeaderText = "COURSE REGISTERED";
            dataTable.Columns[3].Name = "course";
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[4].HeaderText = "DATE OF JOINING";
            dataTable.Columns[4].Name = "doj";
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            /* dataTable.Columns[5].HeaderText = "PAYMENT STATUS";
             dataTable.Columns[5].Name = "payment";
             dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; */

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "PHOTO";
            img.Name = "photo";
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataTable.Columns.Add(img);

            string query = "SELECT stud_id,stud_name,stud_cell,stud_courseSelected,stud_doj,stud_alumni from student";
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["stud_alumni"].ToString() != "YES")
                    {
                        string id = reader["stud_id"].ToString();
                        string name = reader["stud_name"].ToString();
                        string cell = reader["stud_cell"].ToString();
                        string course = reader["stud_courseSelected"].ToString();
                        string doj = reader["stud_doj"].ToString();
                        Image image = Image.FromFile(@"C:\Users\manoj\Downloads\manoj.jpg");
                        dataTable.Rows.Add(id, name, cell, course, doj, image);
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

        private void enquiryTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formname = "Enquiry";
            btnExport.Visible = true;
            dataTable.ColumnCount = 0;
            dataTable.Rows.Clear();
            dataTable.Refresh();
            // Adding column with their properties
            dataTable.ColumnCount = 9;
            dataTable.RowTemplate.Height = 20;

            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "id";
            dataTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[1].HeaderText = "DATE";
            dataTable.Columns[1].Name = "date";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[2].HeaderText = "NAME";
            dataTable.Columns[2].Name = "name";
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[3].HeaderText = "PHONE (M)";
            dataTable.Columns[3].Name = "phone";
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[4].HeaderText = "EMAIL";
            dataTable.Columns[4].Name = "email";
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[5].HeaderText = "COURSE ENQUIRED";
            dataTable.Columns[5].Name = "enquired";
            dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[6].HeaderText = "EDUCATION PERSUING";
            dataTable.Columns[6].Name = "education";
            dataTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[7].HeaderText = "BRANCH";
            dataTable.Columns[7].Name = "branch";
            dataTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[8].HeaderText = "COLLEGE";
            dataTable.Columns[8].Name = "college";
            dataTable.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

                    dataTable.Rows.Add(id, date, name, phone, email, course, education, branch, college);
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

        private void paymentsTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formname = "Payments";
        }

        private void alumniTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formname = "Alumni";
            btnExport.Visible = true;
            dataTable.Rows.Clear();
            dataTable.Refresh();
            // Adding column with their properties
            dataTable.ColumnCount = 5;
            dataTable.RowTemplate.Height = 120;

            dataTable.Columns[0].HeaderText = "ID";
            dataTable.Columns[0].Name = "id";

            dataTable.Columns[1].HeaderText = "NAME";
            dataTable.Columns[1].Name = "name";
            dataTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[2].HeaderText = "PHONE (R)";
            dataTable.Columns[2].Name = "phone";
            dataTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[3].HeaderText = "COURSE REGISTERED";
            dataTable.Columns[3].Name = "course";
            dataTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataTable.Columns[4].HeaderText = "DATE OF JOINING";
            dataTable.Columns[4].Name = "doj";
            dataTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            /* dataTable.Columns[5].HeaderText = "PAYMENT STATUS";
             dataTable.Columns[5].Name = "payment";
             dataTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; */

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.HeaderText = "PHOTO";
            img.Name = "photo";
            img.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataTable.Columns.Add(img);

            string query = "SELECT stud_id,stud_name,stud_cell,stud_courseSelected,stud_doj,stud_alumni from student";
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
                        string course = reader["stud_courseSelected"].ToString();
                        string doj = reader["stud_doj"].ToString();
                        Image image = Image.FromFile(@"C:\Users\manoj\Downloads\manoj.jpg");
                        dataTable.Rows.Add(id, name, cell, course, doj, image);
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

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void exportExcel_Load(object sender, EventArgs e)
        {
            InitializeDb();
            btnExport.Visible = false;
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
    }

}
