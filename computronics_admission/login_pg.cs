using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace computronics_admission
{
    public partial class login_pg : Form
    {
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string pwd;
        public login_pg()
        {
            InitializeComponent();
        }
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
            server = "localhost";
            database = "computronics_admission";
            uid = "root";
            pwd = " ";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);

            resize();
            this.MaximizeBox = false;

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
                    MessageBox.Show("Logged In!");
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

