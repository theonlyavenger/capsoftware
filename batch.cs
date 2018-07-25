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

namespace batches
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
            cbbatchlist.SelectedIndex = 0;
          
        }
        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission";
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

                    clbdisplaylist.Items.Add(reader["stud_id"].ToString() + "   " + reader["stud_name"].ToString());//fetching & adding id & name to checkedlistbox
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

      /*  private void makeBatch()
        {
            ArrayList batch = new ArrayList();              
                con.Open();
                string query = "SELECT distinct course_name FROM course";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    batch.Add(reader["course_name"].ToString());
                    //todo cmb box
                }

           // cmb chageevent 

            foreach(string name in batch)
            {
                string q = "SELECT stud_id,stud_name,stud_courseSelected, FROM student where stud_courseSelected='"+name+"' ";
                MySqlCommand comm = new MySqlCommand(q, con);
                MySqlDataReader read = cmd.ExecuteReader();



                try
                {
                   
                    while (read.Read())
                    {
                       // cbbatchlist.items.Add(read["course_name"].ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message not emailed: " + ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    read.Close();
                }
            }
        }*/
    

        private void btnshow_Click(object sender, EventArgs e)
        {
           // makeBatch();
        }

        private void cbbatchlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            clbdisplaylist.Items.Clear();
            displayData();
          
        }
       
    }
}
