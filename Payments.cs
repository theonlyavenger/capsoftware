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
    public partial class Payments : Form
    {

        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlDataAdapter dataAdapter;
        string radioPaymentMode;
        string server;
        string database;
        string uid;
        string pwd;
        string query;
        int ID;

        public Payments(int id)
        {
            InitializeComponent();
            ID = id;
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

        
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            radioPaymentMode = rbCash.Text;
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            radioPaymentMode = rbCheque.Text;
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

        private void paymentsForm_Load(object sender, EventArgs e)
        {
            tbAmountPaid.Enabled = true;
            btnSubmit.Enabled = true;
            InitializeDb();
            try
            {
                con.Open();
                query = "select stud_id, stud_photo, stud_name, stud_cell, stud_courseSelected, stud_courseFee from student where stud_id = (select max(stud_id) from student)";
                cmd = new MySqlCommand(query, con);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblStudId.Text = reader["stud_id"].ToString();
                    byte[] img = (byte[])(reader["stud_photo"]);
                    if (img == null)
                    {
                        pbPhoto.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbPhoto.Image = Image.FromStream(ms);
                    }
                    lblStudName.Text = reader["stud_name"].ToString();
                    lblStudPh.Text = reader["stud_cell"].ToString();
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
            try
            {
                con.Open();
                query = "insert into payment(payment_mode, stud_id, stud_name, payment_amount, payment_status, payment_remaining_amount) values ('"+radioPaymentMode +"','"+ lblStudId.Text +"','"+lblStudName.Text+"','"+tbAmountPaid.Text+"','"+lblPaymentStatus.Text+"','"+lblRemainingAmount.Text+"')";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Added!");
                this.Close();
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

        private void tbAmountPaid_TextChanged(object sender, EventArgs e)
        {
            var courseFee = 0;
            var amountPaid = 0;
            var remainingAmount = 0;
            try
            {
                courseFee = Convert.ToInt32(lblCoursefee.Text);
                amountPaid = Convert.ToInt32(tbAmountPaid.Text);

                remainingAmount = courseFee - amountPaid;

                if (courseFee < amountPaid)
                {
                    lblPaymentStatus.Text = "Amount exceeding courseFee";
                    lblRemainingAmount.Text = null;
                    btnSubmit.Enabled = false;

                }
                else if (remainingAmount != 0)
                {
                    lblRemainingAmount.Text = remainingAmount.ToString();
                    lblPaymentStatus.Text = "Pending";
                    btnSubmit.Enabled = true;
                    
                 }
                else
                {
                    lblRemainingAmount.Text = remainingAmount.ToString();
                    lblPaymentStatus.Text = "Paid";
                    btnSubmit.Enabled = true;
                }
            }
            catch (Exception)
            {
                
                
            }
            
        }
    }
}