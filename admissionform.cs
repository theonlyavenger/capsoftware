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
using System.Text.RegularExpressions;

namespace Dashboard
{

    public partial class admissionform : Form
    {
        //declarations
        private MySqlConnection con;
        private MySqlDataReader reader;
        private ErrorProvider ep = new ErrorProvider();
        string server;
        string database;
        string uid;
        string pwd;
        string radioGender;
        string query;
        string name;
        MySqlCommand cmd;
        long lengthImage;
        long lengthIdProof;
        byte[] imagebt;
        byte[] idproofbt;


        public admissionform()
        {
            InitializeComponent();
        }

        //function to initialize database
        private void InitializeDb()
        {
            server = "localhost";
            database = "computronics_admission_process";
            uid = "root";
            pwd = "";

            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";
            con = new MySqlConnection(constr);
        }

        //function to resize window size
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

        //function to assign form number
        private void formNumber()
        {
            var formNum=0;
            try
            {
                query = "select stud_id from student where stud_id = (select max(stud_id) from student)";
                con.Open();
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    formNum = Convert.ToInt32(reader["stud_id"]);
                    lblFormNo.Text = (formNum+1).ToString();
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

        //function to store data into combo box
        private void comboBoxData()
        {
            try
            {
                string Sql = "select course_name from course group by course_name";
                con.Open();
                cmd = new MySqlCommand(Sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbCourseSelected.Items.Add(reader[0]);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " +ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //function to store data in course_fees
        private void cbCourseSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string course = cbCourseSelected.Text;
                string Sql = "select course_fees from course where course_name = '"+course+"'";
                con.Open();
                cmd = new MySqlCommand(Sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbCoursefee.Text = reader["course_fees"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tbOthers.Enabled = false;
            tbAge.Enabled = false;
            tbCoursefee.Enabled = false;
            resize();
            MaximizeBox = false;

            dtpDOB.MaxDate = DateTime.Now;
            dtpDoj.MaxDate = DateTime.Now;

            InitializeDb();
            formNumber();
            comboBoxData();

            //cbCourseSelected.SelectedIndex = 0;        
        }


        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            radioGender = rbMale.Text;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            radioGender = rbFemale.Text;
        }

        //function to insert image in database
        private void insertImage()
        {
            imagebt = null;
            FileStream fstream = new FileStream(this.lblLocPhoto.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);
         }

        //function to insert idproof image in database
        private void insertIdProof()
        {
            idproofbt = null;
            FileStream fstream2 = new FileStream(this.lblLocIdProof.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(fstream2);
            idproofbt = br2.ReadBytes((int)fstream2.Length);



           /* Bitmap bitmp = new Bitmap(btnIdProof.PostedFile.InputStream);  
                            if (bitmp.Width > 100 | bitmp.Height > 1000)
                            {  
                                    MessageBox.Show("Image is not in proper dimension");  
                                    //Label1.ForeColor = System.Drawing.Color.Red;                                   
                            }     */                       
        }

        private bool validation()
        {
            if (tbFname.Text == "")
            {
                MessageBox.Show("Please enter first name");
                tbFname.Focus();
                return false;
            }
            else if (tbLname.Text == "")
            {
                MessageBox.Show( "please enter last name");
                tbLname.Focus();
                return false;
            }
            else if (tbAddress.Text == "")
            {
                MessageBox.Show("please enter address");
                tbAddress.Focus();
                return false;
            }
            else if (tbPhone.Text == "")
            {
                MessageBox.Show("please enter phone number");
                tbPhone.Focus();
                return false;
            }
            else if (tbCell.Text == "")
            {
                MessageBox.Show("please enter cell number");
                tbCell.Focus();
                return false;
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("please enter email");
                tbEmail.Focus();
                return false;
            }
            else if (dtpDOB.Text == "")
            {
                MessageBox.Show("please enter date of birth");
                dtpDOB.Focus();
                return false;
            }
            else if (tbEducationpersuing.Text == "")
            {
                MessageBox.Show("please enter education persuing");
                tbEducationpersuing.Focus();
                return false;

            }
            else if (tbBranch.Text == "")
            {
                MessageBox.Show("please enter branch");
                tbBranch.Focus();
                return false;
            }
            else if (tbCollege.Text == "")
            {
                MessageBox.Show("please enter college");
                tbCollege.Focus();
                return false;
            }
            else if (cbCourseSelected.Text == "")
            {
                MessageBox.Show("please select a course");
                cbCourseSelected.Focus();
                return false;
            }
            else if (cbReferences.Text == "")
            {
                MessageBox.Show("please select references");
                cbReferences.Focus();
                return false;
            }
            else if (tbPlace.Text == "")
            {
                MessageBox.Show("please enter place");
                tbPlace.Focus();
                return false;
            }
            else if(!(rbMale.Checked || rbFemale.Checked))
            {
                MessageBox.Show("Select an option for gender");
                return false;
            }  
            else if (lengthImage > 10000000)
            {
                MessageBox.Show("The Id proof size must be less than 10MB");
                return false;
            }
            else if (lengthIdProof > 10000000)
            {
                MessageBox.Show("The Id proof size must be less than 10MB");
                return false;
            }
            else
            {
                return true;
            }
        }



        //function called when submit button is clicked
        private void btnSubmitform_Click(object sender, EventArgs e)
        {
            bool result;
            name = tbFname.Text + " " + tbLname.Text;
            result = validation();
            if (result == true)
            {
                try
                {
                    if (cbReferences.Text == "Others")
                    {
                        query = "insert into student(stud_photo,stud_name,stud_address,stud_pno,stud_cell,stud_email,stud_gender,stud_dob,stud_age,stud_educationpersuing,stud_branch,stud_college,stud_courseSelected,stud_courseFee,stud_details_of_work,stud_reference,stud_doj,stud_place,stud_idproof) values(@IMG,'" + name + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + tbCell.Text + "','" + tbEmail.Text + "','" + radioGender + "','" + dtpDOB.Text + "','" + tbAge.Text + "','" + tbEducationpersuing.Text + "','" + tbBranch.Text + "','" + tbCollege.Text + "','" + cbCourseSelected.Text + "','" + tbCoursefee.Text + "','" + tbDetailsOfWork.Text + "','" + tbOthers.Text + "','" + dtpDoj.Text + "','" + tbPlace.Text + "',@IMG2)";
                    }
                    else
                    {
                        query = "insert into student(stud_photo,stud_name,stud_address,stud_pno,stud_cell,stud_email,stud_gender,stud_dob,stud_age,stud_educationpersuing,stud_branch,stud_college,stud_courseSelected,stud_courseFee,stud_details_of_work,stud_reference,stud_doj,stud_place,stud_idproof) values(@IMG,'" + name + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + tbCell.Text + "','" + tbEmail.Text + "','" + radioGender + "','" + dtpDOB.Text + "','" + tbAge.Text + "','" + tbEducationpersuing.Text + "','" + tbBranch.Text + "','" + tbCollege.Text + "','" + cbCourseSelected.Text + "','" + tbCoursefee.Text + "','" + tbDetailsOfWork.Text + "','" + cbReferences.Text + "','" + dtpDoj.Text + "','" + tbPlace.Text + "',@IMG2)";
                    }
                    con.Open();
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@IMG2", idproofbt));
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                    cmd.ExecuteNonQuery();
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
    
        //upload button click function
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc1 = dlg.FileName.ToString();
                lblLocPhoto.Text = picLoc1;
                pbImage.ImageLocation = picLoc1;
                insertImage();

                lengthImage = new System.IO.FileInfo(picLoc1).Length;

                if(lengthImage > 90000  )
                {
                    MessageBox.Show("The image size must be less than 90kb");
                    btnUploadPhoto.Focus();
                }
                
            }
        }

        //idproof upload button click function
        private void btnIdProof_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc2 = dlg.FileName.ToString();
                lblLocIdProof.Text = picLoc2;
                insertIdProof();

                 lengthIdProof = new System.IO.FileInfo(picLoc2).Length;

                 if (lengthIdProof > 90000)
                 {
                     MessageBox.Show("The image size must be less than 90kb");
                     btnIdProof.Focus();
                 }
            }
        }


       
        private void dtpDOB_ValueChanged_1(object sender, EventArgs e)
        {
            int ageYears = (DateTime.Today.Year - dtpDOB.Value.Year);// CurrentYear - BirthDate
            int ageMonths = DateTime.Today.Month - dtpDOB.Value.Month;
            int ageDays = DateTime.Today.Day - dtpDOB.Value.Day;
            int age = 0;
            if (ageMonths < 0)
            {
                age = ageYears - 1;
                tbAge.Text = age.ToString();
            }
            else if (ageMonths == 0)
            {
                if (ageDays < 0)
                {
                    age = ageYears - 1;
                    tbAge.Text = age.ToString();
                }
            }
            else
            {
                age = ageYears;
                tbAge.Text = age.ToString();
            }      
           
        }



       

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            int validAge = Convert.ToInt32(tbAge.Text);
            if (validAge < 6)
            {
                MessageBox.Show("Invalid age");
                dtpDOB.Focus();
            }
        }

        //validating email
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                if (Regex.IsMatch(tbEmail.Text, pattern))
                {
                    ep.Clear();
                }
                else
                {
                    ep.SetError(this.tbEmail, "Please provide valid email address");
                    tbEmail.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }


            //validate phone

        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"(?<!\d)\d{10}(?!\d)";
                if (Regex.IsMatch(tbPhone.Text, pattern))
                {
                    ep.Clear();

                }
                else
                {
                    ep.SetError(this.tbPhone, "Phone Number must of be 10 digits");
                    tbPhone.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void cbReferences_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reference = cbReferences.Text;
            if (reference == "Others")
            {
                tbOthers.Enabled = true;
            }
            else
            {
                tbOthers.Enabled = false;
            }
        }

       /* private void admissionForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyCode == 
        }*/
    }
}
