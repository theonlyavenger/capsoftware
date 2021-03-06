﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Dashboard
{
    public partial class dashboard : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        public dashboard()
        {
            InitializeComponent();
            InitializeDb();
        }
        Thread th;
        private void btnlogout_Click(object sender, EventArgs e)
        {
            int session = 0;
            string sessionQuery = "UPDATE login set login_session=" + session + "";
            try
            {
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(sessionQuery, con);
                cmd2.ExecuteNonQuery();
                this.Close();
                th = new Thread(opendashboard);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
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

        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = " ";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);
        }

        private void opendashboard()
        {
            Application.Run(new loginform());
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            admissionform admission = new admissionform();
            admission.Show();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            enquirylist enquiry = new enquirylist();
            enquiry.Show();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            studentlist studentlist = new studentlist();
            studentlist.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void notify_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            notification notify = new notification();
            notify.Show();
        }

        private void aboutdevelopers_Click(object sender, EventArgs e)
        {
            aboutdevelopers about = new aboutdevelopers();
            about.Show();
        }

        private void btnalumni_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            alumnilist alumni = new alumnilist();
            alumni.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            paymentlist payment = new paymentlist();
            payment.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            exportExcel excel = new exportExcel();
            excel.Show();
        }

        private void btnbatches_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            batch batch = new batch();
            batch.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            analytics analytics = new analytics();
            analytics.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            course course = new course();
            course.Show();
        }   
       

        /*private void resize()
        {
            
            int x, y, a, b;
            y = centerpanel.Size.Height;
            x = centerpanel.Size.Width;

            a = groupBox1.Size.Height;
            b = groupBox1.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            groupBox1.Left = halfx;
            groupBox1.Top = halfy;
        }*/
       
    }
}
