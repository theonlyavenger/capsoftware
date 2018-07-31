namespace Dashboard
{
    partial class enquiryform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NAME = new System.Windows.Forms.Label();
            this.computronics = new System.Windows.Forms.Panel();
            this.lblenquiry = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxcourseenquired = new System.Windows.Forms.ComboBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lblname = new System.Windows.Forms.Label();
            this.textboxbranch = new System.Windows.Forms.TextBox();
            this.textboxedupur = new System.Windows.Forms.TextBox();
            this.textboxphoneno = new System.Windows.Forms.TextBox();
            this.txtboxcollege = new System.Windows.Forms.TextBox();
            this.textboxemail = new System.Windows.Forms.TextBox();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.lblsubmit = new System.Windows.Forms.Button();
            this.lblbranch = new System.Windows.Forms.Label();
            this.lbleducationp = new System.Windows.Forms.Label();
            this.textboxcollege = new System.Windows.Forms.Label();
            this.lblcou = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphno = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Panel();
            this.lblbatchdetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.computronics.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(58, 117);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(0, 20);
            this.NAME.TabIndex = 2;
            // 
            // computronics
            // 
            this.computronics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.computronics.Controls.Add(this.lblenquiry);
            this.computronics.Dock = System.Windows.Forms.DockStyle.Top;
            this.computronics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(0)))));
            this.computronics.Location = new System.Drawing.Point(0, 0);
            this.computronics.Name = "computronics";
            this.computronics.Size = new System.Drawing.Size(900, 58);
            this.computronics.TabIndex = 18;
            // 
            // lblenquiry
            // 
            this.lblenquiry.AutoSize = true;
            this.lblenquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenquiry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblenquiry.Location = new System.Drawing.Point(8, 16);
            this.lblenquiry.Name = "lblenquiry";
            this.lblenquiry.Size = new System.Drawing.Size(284, 24);
            this.lblenquiry.TabIndex = 0;
            this.lblenquiry.Text = "COMPUTRONICS - ENQUIRY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.header2);
            this.panel1.Controls.Add(this.textboxcourseenquired);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.textboxbranch);
            this.panel1.Controls.Add(this.textboxedupur);
            this.panel1.Controls.Add(this.textboxphoneno);
            this.panel1.Controls.Add(this.txtboxcollege);
            this.panel1.Controls.Add(this.textboxemail);
            this.panel1.Controls.Add(this.textboxname);
            this.panel1.Controls.Add(this.lblsubmit);
            this.panel1.Controls.Add(this.lblbranch);
            this.panel1.Controls.Add(this.lbleducationp);
            this.panel1.Controls.Add(this.textboxcollege);
            this.panel1.Controls.Add(this.lblcou);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblphno);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 603);
            this.panel1.TabIndex = 19;
            // 
            // textboxcourseenquired
            // 
            this.textboxcourseenquired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textboxcourseenquired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxcourseenquired.FormattingEnabled = true;
            this.textboxcourseenquired.Location = new System.Drawing.Point(587, 126);
            this.textboxcourseenquired.Name = "textboxcourseenquired";
            this.textboxcourseenquired.Size = new System.Drawing.Size(249, 28);
            this.textboxcourseenquired.TabIndex = 75;
            this.textboxcourseenquired.SelectedIndexChanged += new System.EventHandler(this.textboxcourseenquired_SelectedIndexChanged);
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd/MM/yyyy";
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(585, 315);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(251, 26);
            this.dtpdate.TabIndex = 71;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(44, 64);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 20);
            this.lblname.TabIndex = 70;
            this.lblname.Text = "Name :";
            // 
            // textboxbranch
            // 
            this.textboxbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxbranch.Location = new System.Drawing.Point(129, 318);
            this.textboxbranch.Name = "textboxbranch";
            this.textboxbranch.Size = new System.Drawing.Size(249, 26);
            this.textboxbranch.TabIndex = 78;
            // 
            // textboxedupur
            // 
            this.textboxedupur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxedupur.Location = new System.Drawing.Point(587, 250);
            this.textboxedupur.Name = "textboxedupur";
            this.textboxedupur.Size = new System.Drawing.Size(249, 26);
            this.textboxedupur.TabIndex = 77;
            // 
            // textboxphoneno
            // 
            this.textboxphoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxphoneno.Location = new System.Drawing.Point(587, 61);
            this.textboxphoneno.Name = "textboxphoneno";
            this.textboxphoneno.Size = new System.Drawing.Size(249, 26);
            this.textboxphoneno.TabIndex = 73;
            this.textboxphoneno.Leave += new System.EventHandler(this.textboxphoneno_Leave_1);
            // 
            // txtboxcollege
            // 
            this.txtboxcollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxcollege.Location = new System.Drawing.Point(129, 253);
            this.txtboxcollege.Name = "txtboxcollege";
            this.txtboxcollege.Size = new System.Drawing.Size(249, 26);
            this.txtboxcollege.TabIndex = 76;
            // 
            // textboxemail
            // 
            this.textboxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxemail.Location = new System.Drawing.Point(115, 126);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(249, 26);
            this.textboxemail.TabIndex = 74;
            this.textboxemail.Leave += new System.EventHandler(this.textboxemail_Leave_1);
            // 
            // textboxname
            // 
            this.textboxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxname.Location = new System.Drawing.Point(115, 61);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(249, 26);
            this.textboxname.TabIndex = 72;
            // 
            // lblsubmit
            // 
            this.lblsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.lblsubmit.FlatAppearance.BorderSize = 0;
            this.lblsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubmit.ForeColor = System.Drawing.Color.Black;
            this.lblsubmit.Location = new System.Drawing.Point(390, 512);
            this.lblsubmit.Name = "lblsubmit";
            this.lblsubmit.Size = new System.Drawing.Size(120, 36);
            this.lblsubmit.TabIndex = 63;
            this.lblsubmit.Text = "Submit";
            this.lblsubmit.UseVisualStyleBackColor = false;
            this.lblsubmit.Click += new System.EventHandler(this.lblsubmit_Click_1);
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.Location = new System.Drawing.Point(44, 321);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(76, 20);
            this.lblbranch.TabIndex = 62;
            this.lblbranch.Text = "Branch :";
            // 
            // lbleducationp
            // 
            this.lbleducationp.AutoSize = true;
            this.lbleducationp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleducationp.Location = new System.Drawing.Point(484, 236);
            this.lbleducationp.Name = "lbleducationp";
            this.lbleducationp.Size = new System.Drawing.Size(95, 40);
            this.lbleducationp.TabIndex = 61;
            this.lbleducationp.Text = "Education \r\nPursing :";
            // 
            // textboxcollege
            // 
            this.textboxcollege.AutoSize = true;
            this.textboxcollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxcollege.Location = new System.Drawing.Point(44, 256);
            this.textboxcollege.Name = "textboxcollege";
            this.textboxcollege.Size = new System.Drawing.Size(79, 20);
            this.textboxcollege.TabIndex = 60;
            this.textboxcollege.Text = "College :";
            // 
            // lblcou
            // 
            this.lblcou.AutoSize = true;
            this.lblcou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcou.Location = new System.Drawing.Point(484, 112);
            this.lblcou.Name = "lblcou";
            this.lblcou.Size = new System.Drawing.Size(91, 40);
            this.lblcou.TabIndex = 59;
            this.lblcou.Text = "Course\r\nEnquired :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(45, 126);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(63, 20);
            this.lblemail.TabIndex = 58;
            this.lblemail.Text = "Email :";
            // 
            // lblphno
            // 
            this.lblphno.AutoSize = true;
            this.lblphno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphno.Location = new System.Drawing.Point(484, 64);
            this.lblphno.Name = "lblphno";
            this.lblphno.Size = new System.Drawing.Size(97, 20);
            this.lblphno.TabIndex = 57;
            this.lblphno.Text = "Phone No :";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(484, 321);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(58, 20);
            this.lbldate.TabIndex = 56;
            this.lbldate.Text = "Date :";
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.header2.Controls.Add(this.lblbatchdetails);
            this.header2.Location = new System.Drawing.Point(0, 0);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(900, 35);
            this.header2.TabIndex = 129;
            // 
            // lblbatchdetails
            // 
            this.lblbatchdetails.AutoSize = true;
            this.lblbatchdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatchdetails.ForeColor = System.Drawing.Color.White;
            this.lblbatchdetails.Location = new System.Drawing.Point(12, 7);
            this.lblbatchdetails.Name = "lblbatchdetails";
            this.lblbatchdetails.Size = new System.Drawing.Size(140, 20);
            this.lblbatchdetails.TabIndex = 100;
            this.lblbatchdetails.Text = "Personal Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 35);
            this.panel2.TabIndex = 129;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Educational Details";
            // 
            // enquiryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.computronics);
            this.Controls.Add(this.NAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "enquiryform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.computronics.ResumeLayout(false);
            this.computronics.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header2.ResumeLayout(false);
            this.header2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Panel computronics;
        private System.Windows.Forms.Label lblenquiry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox textboxcourseenquired;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textboxbranch;
        private System.Windows.Forms.TextBox textboxedupur;
        private System.Windows.Forms.TextBox textboxphoneno;
        private System.Windows.Forms.TextBox txtboxcollege;
        private System.Windows.Forms.TextBox textboxemail;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Button lblsubmit;
        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lbleducationp;
        private System.Windows.Forms.Label textboxcollege;
        private System.Windows.Forms.Label lblcou;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphno;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Panel header2;
        private System.Windows.Forms.Label lblbatchdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

