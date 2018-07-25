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

namespace computeronics_admission_process
{

    public partial class admissionForm : Form
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
        string radioReferences;
        string name;
        MySqlCommand cmd;
        byte[] imagebt;
        byte[] idproofbt;


        public admissionForm()
        {
            InitializeComponent();

        }

        //function to initialize database
        private void InitializeDb()
        {
            server = "localhost";
            database = "c#project";
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
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tbFname.Focus();
            tbAge.ReadOnly = true;
            resize();
            MaximizeBox = false;

            InitializeDb();
            formNumber();

            cbCourseSelected.SelectedIndex = 0;
         
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
        }

        //function called when submit button is clicked
        private void btnSubmitform_Click(object sender, EventArgs e)
        {

            name = tbLname.Text + " " + tbFname.Text;
            try
            {
                query = "insert into student(stud_photo,stud_name,stud_address,stud_pno,stud_cell,stud_email,stud_gender,stud_dob,stud_age,stud_educationpersuing,stud_branch,stud_college,stud_courseSelected,stud_courseFee,stud_details_of_work,stud_reference,stud_doj,stud_place,stud_idproof) values(@IMG,'" + name + "','" + tbAddress.Text + "','" + tbPhone.Text + "','" + tbCell.Text + "','" + tbEmail.Text + "','" + radioGender + "','" + dtpDOB.Text + "','" + tbAge.Text + "','" + tbEducationpersuing.Text + "','" + tbBranch.Text + "','" + tbCollege.Text + "','" + cbCourseSelected.Text + "','" + tbCoursefee.Text + "','" + tbDetailsOfWork.Text + "','" + radioReferences + "','" + dtpDoj.Text + "','" + tbPlace.Text + "',@IMG2)";
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@IMG2", idproofbt));
                cmd.Parameters.Add(new MySqlParameter("@IMG", imagebt));
                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
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
                pictureBox1.ImageLocation = picLoc1;
                insertImage();
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
            }
        }


        //validating name
        private void tbFname_Validating(object sender, CancelEventArgs e)
        {
            ValidateFName();
        }
        private bool ValidateFName()
        {
            bool bStatus = true;
            if (tbLname.Text == "")
            {
                ep.SetError(tbLname, "Please enter your Name");
                tbLname.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }

        //validate last name
        private void tbLname_Validating(object sender, CancelEventArgs e)
        {
            ValidateLName();
        }

        private bool ValidateLName()
        {
            bool bStatus = true;
            if (tbFname.Text == "")
            {
                ep.SetError(tbFname, "Please enter your Name");
                tbFname.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }

        //validating address
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateAddress();
        }

        private bool ValidateAddress()
        {
            bool bStatus = true;
            if (tbAddress.Text == "")
            {
                ep.SetError(tbAddress, "Please enter your Name");
                tbAddress.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
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
                MessageBox.Show("" + ex);
            }
        }

        //validate phone
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
                MessageBox.Show("" + ex);
            }
        }

        //validate education persuing
        private void tbEducationpersuing_Validating(object sender, CancelEventArgs e)
        {
            ValidateEducationPersuing();
        }
        private bool ValidateEducationPersuing()
        {
            bool bStatus = true;
            if (tbEducationpersuing.Text == "")
            {
                ep.SetError(tbEducationpersuing, "Please enter Education Persuing");
                tbEducationpersuing.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }
      

        //validate branch
        private void tbBranch_Validating(object sender, CancelEventArgs e)
        {
            ValidateBranch();
        }
        private bool ValidateBranch()
        {
            bool bStatus = true;
            if (tbBranch.Text == "")
            {
                ep.SetError(tbBranch, "Please enter branch");
                tbBranch.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }

        //validate college
        private void tbCollege_Validating(object sender, CancelEventArgs e)
        {
            ValidateCollege();
        }
        private bool ValidateCollege()
        {
            bool bStatus = true;
            if (tbCollege.Text == "")
            {
                ep.SetError(tbCollege, "Please enter your college");
                tbCollege.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }

        //validate place
        private void tbPlace_Validating(object sender, CancelEventArgs e)
        {
            ValidatePlace();
        }
        private bool ValidatePlace()
        {
            bool bStatus = true;
            if (tbPlace.Text == "")
            {
                ep.SetError(tbPlace, "Please enter your place");
                tbPlace.Focus();
                bStatus = false;
            }
            else
                ep.Clear();
            return bStatus;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Today.Year - dtpDOB.Value.Year; // CurrentYear - BirthDate

            tbAge.Text = Age.ToString();
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
        
        
    }
}
