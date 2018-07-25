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

namespace Payments
{
    public partial class lblCourseSelected : Form
    {

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlDataAdapter dataAdapter;
        string server;
        string database;
        string uid;
        string pwd;
        string query;


        public lblCourseSelected()
        {
            InitializeComponent();
        }

        //resizing form 
        private void resize()
        {
            int x, y, a, b;
            y = this.Size.Height;
            x = this.Size.Width;

            a = formPanel.Size.Height;
            b = formPanel.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            formPanel.Left = halfx;
            formPanel.Top = halfy;
        }

        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = "";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paymentsForm_Load(object sender, EventArgs e)
        {
            tbAmountPaid.Enabled = true;
            btnSubmit.Enabled = true;
            InitializeDb();
            try
            {
                con.Open();
                query = "select stud_id, stud_name, stud_pno, stud_courseSelected, stud_courseFee from student where stud_id = (select max(stud_id) from student)";
                cmd = new MySqlCommand(query, con);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStudId.Text = reader["stud_id"].ToString();
                    lblStudName.Text = reader["stud_name"].ToString();
                    lblStudPh.Text = reader["stud_pno"].ToString();
                    lblStudCourseSelected.Text = reader["stud_courseSelected"].ToString();
                    lblCoursefee.Text = reader["stud_courseFee"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is the exception which has occured" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //tbAmountPaid.Enabled = false;
            var courseFee = 0;
            var amountPaid = 0;
            var remainingAmount = 0;
            courseFee = Convert.ToInt32(lblCoursefee.Text);
            amountPaid = Convert.ToInt32(tbAmountPaid.Text);

            remainingAmount = courseFee - amountPaid;

            

            if (courseFee < amountPaid)
            {
                MessageBox.Show("amount paid must be less or equal to than course fee");
                tbAmountPaid.Focus();
            }
            else if(remainingAmount != 0)
            {                
                lblPaymentStatus.Text = "Pending";
                btnSubmit.Enabled = false;
                lblRemainingAmount.Text = remainingAmount.ToString();
            }
            else
            {
                lblPaymentStatus.Text = "Paid";
                btnSubmit.Enabled = false;
                lblRemainingAmount.Text = remainingAmount.ToString();
            }
        }
    }
}
