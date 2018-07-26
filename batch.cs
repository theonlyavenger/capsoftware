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
    public partial class batch : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
      
        public batch()
        {
            InitializeComponent();
        }

        private void batch_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            
            
            InitializeDb();
            displayCourse();
            try
            {
                cbbatchlist.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
          
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
        private void displayData()
        {
            try
            {
                con.Open();
              //  string selected = this.cbbatchlist.GetItemText(this.cbbatchlist.SelectedItem);
               // MessageBox.Show(selected);
      
                string query = "SELECT stud_id,stud_name FROM student where stud_courseSelected='"+cbbatchlist.Text +"'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    clbdisplaylist.Items.Add( reader["stud_id"].ToString()+" "+reader["stud_name"].ToString());//fetching & adding id & name to checkedlistbox
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


        private void displayCourse()
        {
            try
            {
                con.Open();
                string query = "SELECT distinct course_name FROM course ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cbbatchlist.Items.Add(reader["course_name"].ToString());//fetching & adding id & name to checkedlistbox
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

        private void makeBatch(string batchname)
        {
           
            try
            {
              con.Open();
               foreach (string item in clbdisplaylist.CheckedItems)//for each checked item in the listbox
            {
                string id = item.Trim(new Char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 
               'r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V',
               'W','X','Y','Z',' '});

                string name = item.Trim(new Char[] {'0','1','2','3','4','5','6','7','8','9','0'});
                    //inserting values into batch table
                string query = "insert into batch (batch_no,stud_id,stud_name,stud_course,batch_timing)values('" + batchname + "'," + id + ",'" +name+ "','" + cbbatchlist.Text + "','" + tbbatchtiming + "')";
                   MySqlCommand cmd = new MySqlCommand(query, con);
                   cmd.ExecuteNonQuery();
                   MessageBox.Show("ADDED!");
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
    

        private void btnshow_Click(object sender, EventArgs e)
        {
           // makeBatch();
        }

        private void cbbatchlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            clbdisplaylist.Items.Clear();
            displayData();
          
        }

        private void b1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBatch(b1ToolStripMenuItem.Text);
        }

        private void viewBatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            batchlist batchlist = new batchlist();
            batchlist.Show();
        }

        private void b2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBatch(b2ToolStripMenuItem.Text);
        }

        private void b3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBatch(b3ToolStripMenuItem.Text);
        }

        private void b4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBatch(b4ToolStripMenuItem.Text);
        }

        private void b5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeBatch(b5ToolStripMenuItem.Text);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string query = "SELECT stud_id, stud_name from student where stud_courseSelected='" + cbbatchlist.Text + "' and stud_name like '"+tbSearch.Text+"%'";
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clbdisplaylist.Items.Add(reader["stud_id"].ToString() + " " + reader["stud_name"].ToString());
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

       
    }
}
