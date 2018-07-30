using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Dashboard
{
    public partial class loginform : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        public loginform()
        {
            InitializeComponent();
            InitilizeDb();
        }
        Thread th;

        private void resize()
        {
            int x, y, a, b;
            y = this.Size.Height;
            x = this.Size.Width;

            a = grpboxlogin.Size.Height;
            b = grpboxlogin.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            grpboxlogin.Left = halfx;
            grpboxlogin.Top = halfy;
        }

        private void login_pg_Load(object sender, EventArgs e)
        {
            CheckSession();
            resize();
            this.MaximizeBox = false;

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
            Application.Run(new dashboard());
        }

        private void CheckSession()
        {
            string sessionCheck = "SELECT login_session from login";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sessionCheck, con);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int sessionbit = Convert.ToInt32(reader["login_session"]);
                    if (sessionbit == 1)
                    {
                        this.Close();
                        th = new Thread(opendashboard);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = tbusername.Text;
            password = tbpassword.Text;

            con.Open();
            string query = "SELECT * from login  WHERE username = '" + username + "' and password = '" + password + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    con.Close();
                    int session = 1;
                    string sessionQuery = "UPDATE login set login_session=" + session + " WHERE username= '" + username + "'";
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
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
            con.Close();
        }

        }

    }

