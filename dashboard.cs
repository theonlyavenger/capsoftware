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
            InitilizeDb();
        }
        Thread th;
        private void btnlogout_Click(object sender, EventArgs e)
        {
            int session = 0;
            string sessionQuery = "UPDATE login set login_session=" + session + "";
            con.Open();
            try
            {
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

        private void InitilizeDb()
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
