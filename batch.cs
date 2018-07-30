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
            labelresult.Visible = false;
            lblresultfound.Visible = false;
            addalldisabletimer.Enabled = true;
            addalldisabletimer.Interval = 1;
            addalldisabletimer.Start();
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
        //displaying name and id from student table to searchlistbox
        private void displayData()
        {
            try
            {
                con.Open();
                //  string selected = this.cbbatchlist.GetItemText(this.cbbatchlist.SelectedItem);
                // MessageBox.Show(selected);

                string query = "SELECT stud_id,stud_name FROM student where stud_courseSelected='" + cbbatchlist.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    searchlistbox.Items.Add(reader["stud_id"].ToString() + " " + reader["stud_name"].ToString()); //fetching & adding id & name to checkedlistbox
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

        //displaying course_name from course table to combobox
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
                    cbbatchlist.Items.Add(reader["course_name"].ToString()); //fetching & adding id & name to listbox
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

        //making of batch by storing the batches into batch table
        private void makeBatch(string batchname)
        {
            Boolean flag = false;
            try
            {
                con.Open();
                foreach (string item in lbdisplay.Items) //for each checked item in the listbox
                {
                    string id = item.Trim(new Char[] {
      'a',
      'b',
      'c',
      'd',
      'e',
      'f',
      'g',
      'h',
      'i',
      'j',
      'k',
      'l',
      'm',
      'n',
      'o',
      'p',
      'q',
      'r',
      's',
      't',
      'u',
      'v',
      'w',
      'x',
      'y',
      'z',
      'A',
      'B',
      'C',
      'D',
      'E',
      'F',
      'G',
      'H',
      'I',
      'J',
      'K',
      'L',
      'M',
      'N',
      'O',
      'P',
      'Q',
      'R',
      'S',
      'T',
      'U',
      'V',
      'W',
      'X',
      'Y',
      'Z',
      ' '
     });

                    string name = item.Trim(new Char[] {
      '0',
      '1',
      '2',
      '3',
      '4',
      '5',
      '6',
      '7',
      '8',
      '9',
      '0'
     });
                    //inserting values into batch table
                    string query = "insert into batch (batch_no,stud_id,stud_name,stud_course,batch_timing)values('" + batchname + "'," + id + ",'" + name + "','" + cbbatchlist.Text + "','" + tbbatchtiming.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    flag = true;
                }
                if (flag)
                {
                    MessageBox.Show("ADDED!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selected Students have already been alloted.. try again\nException :" + ex.Message);
            }
            finally
            {
                con.Close();
                resetForm();
            }
        }
        //validation for display listbox and batchtiming textbox

        private void validateBeforeBatchMaking(string batchname)
        {
            if (String.IsNullOrEmpty(lbdisplay.Text))
            {
                if (ValidateBatchTiming())
                {
                    makeBatch(batchname);
                }
                else
                {
                    tbbatchtiming.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Add Students before creating batch");
            }

        }
        //refreshing the form once batch is alloted
        private void resetForm()
        {
            tbbatchtiming.Clear();
            tbSearch.Clear();
            lbdisplay.Items.Clear();
            searchlistbox.Items.Clear();
            displayData();
        }


        private void b1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validateBeforeBatchMaking(b1ToolStripMenuItem.Text);
        }

        private void b2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validateBeforeBatchMaking(b2ToolStripMenuItem.Text);
        }

        private void b3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validateBeforeBatchMaking(b3ToolStripMenuItem.Text);
        }

        private void b4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validateBeforeBatchMaking(b4ToolStripMenuItem.Text);
        }

        private void b5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validateBeforeBatchMaking(b5ToolStripMenuItem.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (String.IsNullOrEmpty(tbSearch.Text) || //checking for empty field for the search textbox
             tbSearch.Text.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter the name to search");
                tbSearch.Focus();
            }
            else
            {
                searchlistbox.SelectedItems.Clear();
                for (int i = searchlistbox.Items.Count - 1; i >= 0; i--)
                {
                    if (searchlistbox.Items[i].ToString().ToLower().Contains(tbSearch.Text)) //checking for the duplicates in the two listboxes
                    {
                        searchlistbox.SetSelected(i, true);
                        count++;
                    }
                }

            }
            labelresult.Visible = true;
            lblresultfound.Visible = true;

            lblresultfound.Text = count.ToString();
        }

        private void cbbatchlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            searchlistbox.Items.Clear();
            displayData();
            lbdisplay.Items.Clear();
        }

        private void addone_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbdisplay.Items.Contains(searchlistbox.Text)) //checking  whether the searchbox text is present in the listbox or not
                {
                    MessageBox.Show("This name already exists!");
                }
                else
                {
                    foreach (string obj in searchlistbox.SelectedItems)

                        lbdisplay.Items.Add(obj);
                    for (int i = searchlistbox.Items.Count - 1; i >= 0; i--) //shows that text is present in the listbox
                    {
                        searchlistbox.SetSelected(i, false);
                    }
                    /*if (String.IsNullOrEmpty(lbdisplay.Text))
                    {
                        lbdisplay.SelectedIndex = -1;
                    }
                    else
                    {
                        lbdisplay.SelectedIndex = 0;
                    }*/
                    lbdisplay.SelectedIndex = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select an item to add");
            }

           
        }

        //adding all items to listbox
        private void addall_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbdisplay.Items.Contains(searchlistbox.Text))
                {
                    MessageBox.Show("This name already exists!");
                }
                else
                {
                    lbdisplay.Items.AddRange(searchlistbox.Items);
                }
                lbdisplay.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }

           
        }

        //deleting the selected item

        private void clearselected_Click(object sender, EventArgs e)
        {
            try
            {
                lbdisplay.Items.RemoveAt(lbdisplay.SelectedIndex);
                lbdisplay.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("please select an item to remove / listbox empty");
            }
        }

        //deleting all the items
        private void clearall_Click(object sender, EventArgs e)
        {
            lbdisplay.Items.Clear();
        }

        private void tbbatchtiming_Validating(object sender, CancelEventArgs e)
        {
            ValidateBatchTiming();
        }

        private bool ValidateBatchTiming()
        {
            bool bStatus = true;
            if (tbbatchtiming.Text == "")
            {
                errorProviderBatchtiming.SetError(tbbatchtiming, "Please Enter the Batch timing");
                bStatus = false;
            }
            else
                errorProviderBatchtiming.SetError(tbbatchtiming, "");
            return bStatus;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchlistbox.SelectedIndex = -1;
        }

        private void viewBatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            batchlist batch = new batchlist();
            batch.Show();
        }

        private void addalldisabletimer_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbdisplay.Text))
            {
                addall.Visible = true;
            }
            else
            {
                addall.Visible = false;
            }
        }
    }
}