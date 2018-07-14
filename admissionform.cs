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

    public partial class admissionform : Form
    {
        //declarations
        private MySqlConnection con;
        string server;
        string database;
        string uid;
        string password;
        string radioGender;
        string query;
        string radioReferences;
        string name;
        MySqlCommand cmd;
        byte[] imagebt;
        byte[] idproofbt;


        public admissionform()
        {
            InitializeComponent();

        }

        private void resize()
        {
           int x, y, a, b;
           y = this.Size.Height;
           x = this.Size.Width;
        
            a = panel2.Size.Height;
            b = panel2.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            panel2.Left = halfx;
            panel2.Top = halfy;
        }

        private void RandomNumberGenerator()
        {
            Random r = new Random();

            lblFormNo.Text = Convert.ToString(r.Next(10000));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            resize();
            MaximizeBox = false;

            RandomNumberGenerator();

            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            password = "";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            con = new MySqlConnection(constr);

            
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            radioGender = rbMale.Text;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioGender = rbFemale.Text;
        }

        private void rbAdvertisement_CheckedChanged(object sender, EventArgs e)
        {
            radioReferences = rbAdvertisement.Text;
        }

        private void rbFriends_CheckedChanged(object sender, EventArgs e)
        {
            radioReferences = rbFriends.Text;
        }

        private void rbNewspaper_CheckedChanged(object sender, EventArgs e)
        {
            radioReferences = rbNewspaper.Text;
        }

        private void rbOthers_CheckedChanged(object sender, EventArgs e)
        {
            radioReferences = tbOthers.Text;
        }

        private void insertImage()
        {
            imagebt = null;
            FileStream fstream = new FileStream(this.label10.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);
             
        }

        private void insertIdProof()
        {
            idproofbt = null;
            FileStream fstream2 = new FileStream(this.label25.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(fstream2);
            idproofbt = br2.ReadBytes((int)fstream2.Length);
        }

        private void btnSubmitform_Click(object sender, EventArgs e)
        {

            name = tbFname.Text + " " + tbLname.Text;
            try
            {

                query = "insert into student(stud_photo,stud_name,stud_address,stud_pno,stud_cell,stud_email,stud_gender,stud_dob,stud_age,stud_educationpersuing,stud_branch,stud_college,stud_courseSelected,stud_courseFee,stud_details_of_work,stud_reference,stud_doj,stud_place,stud_idproof) values(@IMG,'" + name + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + tbCell.Text + "','" + tbEmail.Text + "','" + radioGender + "','" + dtpDOB.Text + "','" + tbAge.Text + "','" + tbEducationpersuing.Text + "','" + tbBranch.Text + "','" + tbCollege.Text + "','" + cbCourseSelected.Text + "','" + tbCoursefee.Text + "','" + tbDetailsOfWork.Text + "','" + radioReferences + "','" + dtpDoj.Text + "','" + tbPlace.Text + "',@IMG2)";
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@IMG2", idproofbt));
                cmd.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Data Added.. you will now be redirected to the payment screen...");
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
    
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc1 = dlg.FileName.ToString();
                label10.Text = picLoc1;
                pictureBox1.ImageLocation = picLoc1;
                insertImage();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc2 = dlg.FileName.ToString();
                label25.Text = picLoc2;
                insertIdProof();
                
            }
        }    
       
    }
}