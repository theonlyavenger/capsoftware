namespace enquiry
{
    partial class enquiry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.textboxcourseenquired = new System.Windows.Forms.ComboBox();
            this.computronics.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.lblenquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenquiry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblenquiry.Location = new System.Drawing.Point(8, 16);
            this.lblenquiry.Name = "lblenquiry";
            this.lblenquiry.Size = new System.Drawing.Size(247, 20);
            this.lblenquiry.TabIndex = 0;
            this.lblenquiry.Text = "COMPUTRONICS - ENQUIRY";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxcourseenquired);
            this.groupBox1.Controls.Add(this.dtpdate);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.textboxbranch);
            this.groupBox1.Controls.Add(this.textboxedupur);
            this.groupBox1.Controls.Add(this.textboxphoneno);
            this.groupBox1.Controls.Add(this.txtboxcollege);
            this.groupBox1.Controls.Add(this.textboxemail);
            this.groupBox1.Controls.Add(this.textboxname);
            this.groupBox1.Controls.Add(this.lblsubmit);
            this.groupBox1.Controls.Add(this.lblbranch);
            this.groupBox1.Controls.Add(this.lbleducationp);
            this.groupBox1.Controls.Add(this.textboxcollege);
            this.groupBox1.Controls.Add(this.lblcou);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblphno);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 700);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd-MM-yyyy";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(179, 124);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(104, 20);
            this.dtpdate.TabIndex = 54;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(43, 180);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 20);
            this.lblname.TabIndex = 53;
            this.lblname.Text = "Name";
            // 
            // textboxbranch
            // 
            this.textboxbranch.Location = new System.Drawing.Point(699, 348);
            this.textboxbranch.Name = "textboxbranch";
            this.textboxbranch.Size = new System.Drawing.Size(149, 20);
            this.textboxbranch.TabIndex = 52;
            this.textboxbranch.Validating += new System.ComponentModel.CancelEventHandler(this.textboxbranch_Validating);
            // 
            // textboxedupur
            // 
            this.textboxedupur.Location = new System.Drawing.Point(179, 348);
            this.textboxedupur.Name = "textboxedupur";
            this.textboxedupur.Size = new System.Drawing.Size(249, 20);
            this.textboxedupur.TabIndex = 51;
            this.textboxedupur.Validating += new System.ComponentModel.CancelEventHandler(this.textboxedupur_Validating);
            // 
            // textboxphoneno
            // 
            this.textboxphoneno.Location = new System.Drawing.Point(699, 180);
            this.textboxphoneno.Name = "textboxphoneno";
            this.textboxphoneno.Size = new System.Drawing.Size(154, 20);
            this.textboxphoneno.TabIndex = 49;
            this.textboxphoneno.Leave += new System.EventHandler(this.textboxphoneno_Leave);
            // 
            // txtboxcollege
            // 
            this.txtboxcollege.Location = new System.Drawing.Point(179, 292);
            this.txtboxcollege.Name = "txtboxcollege";
            this.txtboxcollege.Size = new System.Drawing.Size(672, 20);
            this.txtboxcollege.TabIndex = 48;
            this.txtboxcollege.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxcollege_Validating);
            // 
            // textboxemail
            // 
            this.textboxemail.Location = new System.Drawing.Point(178, 233);
            this.textboxemail.Name = "textboxemail";
            this.textboxemail.Size = new System.Drawing.Size(249, 20);
            this.textboxemail.TabIndex = 47;
            this.textboxemail.Leave += new System.EventHandler(this.textboxemail_Leave);
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(179, 180);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(249, 20);
            this.textboxname.TabIndex = 46;
            // 
            // lblsubmit
            // 
            this.lblsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.lblsubmit.FlatAppearance.BorderSize = 0;
            this.lblsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubmit.ForeColor = System.Drawing.Color.Black;
            this.lblsubmit.Location = new System.Drawing.Point(395, 436);
            this.lblsubmit.Name = "lblsubmit";
            this.lblsubmit.Size = new System.Drawing.Size(120, 36);
            this.lblsubmit.TabIndex = 45;
            this.lblsubmit.Text = "Submit";
            this.lblsubmit.UseVisualStyleBackColor = false;
            this.lblsubmit.Click += new System.EventHandler(this.lblsubmit_Click);
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbranch.Location = new System.Drawing.Point(531, 348);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(60, 20);
            this.lblbranch.TabIndex = 44;
            this.lblbranch.Text = "Branch";
            // 
            // lbleducationp
            // 
            this.lbleducationp.AutoSize = true;
            this.lbleducationp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleducationp.Location = new System.Drawing.Point(43, 348);
            this.lbleducationp.Name = "lbleducationp";
            this.lbleducationp.Size = new System.Drawing.Size(85, 40);
            this.lbleducationp.TabIndex = 43;
            this.lbleducationp.Text = "Education \r\nPursing";
            // 
            // textboxcollege
            // 
            this.textboxcollege.AutoSize = true;
            this.textboxcollege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxcollege.Location = new System.Drawing.Point(43, 292);
            this.textboxcollege.Name = "textboxcollege";
            this.textboxcollege.Size = new System.Drawing.Size(62, 20);
            this.textboxcollege.TabIndex = 42;
            this.textboxcollege.Text = "College";
            // 
            // lblcou
            // 
            this.lblcou.AutoSize = true;
            this.lblcou.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcou.Location = new System.Drawing.Point(531, 228);
            this.lblcou.Name = "lblcou";
            this.lblcou.Size = new System.Drawing.Size(73, 40);
            this.lblcou.TabIndex = 41;
            this.lblcou.Text = "Course\r\nEnquired";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(43, 233);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 40;
            this.lblemail.Text = "Email";
            // 
            // lblphno
            // 
            this.lblphno.AutoSize = true;
            this.lblphno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphno.Location = new System.Drawing.Point(531, 180);
            this.lblphno.Name = "lblphno";
            this.lblphno.Size = new System.Drawing.Size(79, 20);
            this.lblphno.TabIndex = 39;
            this.lblphno.Text = "Phone No";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(43, 124);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(44, 20);
            this.lbldate.TabIndex = 38;
            this.lbldate.Text = "Date";
            // 
            // textboxcourseenquired
            // 
            this.textboxcourseenquired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textboxcourseenquired.FormattingEnabled = true;
            this.textboxcourseenquired.Location = new System.Drawing.Point(704, 232);
            this.textboxcourseenquired.Name = "textboxcourseenquired";
            this.textboxcourseenquired.Size = new System.Drawing.Size(152, 21);
            this.textboxcourseenquired.TabIndex = 55;
            
            // 
            // enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.computronics);
            this.Controls.Add(this.NAME);
            this.Name = "enquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.computronics.ResumeLayout(false);
            this.computronics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Panel computronics;
        private System.Windows.Forms.Label lblenquiry;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox textboxcourseenquired;
    }
}

