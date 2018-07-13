namespace Dashboard
{
    partial class loginform
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
            this.panellogin = new System.Windows.Forms.Panel();
            this.lblcomputronics = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.grpboxlogin = new System.Windows.Forms.GroupBox();
            this.panellogin.SuspendLayout();
            this.grpboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panellogin.Controls.Add(this.lblcomputronics);
            this.panellogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panellogin.Location = new System.Drawing.Point(0, 0);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(904, 58);
            this.panellogin.TabIndex = 4;
            // 
            // lblcomputronics
            // 
            this.lblcomputronics.AutoSize = true;
            this.lblcomputronics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomputronics.ForeColor = System.Drawing.Color.White;
            this.lblcomputronics.Location = new System.Drawing.Point(8, 16);
            this.lblcomputronics.Name = "lblcomputronics";
            this.lblcomputronics.Size = new System.Drawing.Size(255, 24);
            this.lblcomputronics.TabIndex = 0;
            this.lblcomputronics.Text = "COMPUTRONICS - LOGIN\r\n";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(103, 151);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 0;
            this.lblpassword.Text = "Password\r\n";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(103, 111);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(83, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(200, 144);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(172, 26);
            this.tbpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(200, 200);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(92, 33);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(200, 104);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(172, 26);
            this.tbusername.TabIndex = 1;
            // 
            // grpboxlogin
            // 
            this.grpboxlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpboxlogin.Controls.Add(this.tbusername);
            this.grpboxlogin.Controls.Add(this.btnlogin);
            this.grpboxlogin.Controls.Add(this.tbpassword);
            this.grpboxlogin.Controls.Add(this.lblusername);
            this.grpboxlogin.Controls.Add(this.lblpassword);
            this.grpboxlogin.Location = new System.Drawing.Point(224, 208);
            this.grpboxlogin.Name = "grpboxlogin";
            this.grpboxlogin.Size = new System.Drawing.Size(472, 320);
            this.grpboxlogin.TabIndex = 3;
            this.grpboxlogin.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.grpboxlogin);
            this.Controls.Add(this.panellogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_pg_Load);
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.grpboxlogin.ResumeLayout(false);
            this.grpboxlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label lblcomputronics;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.GroupBox grpboxlogin;
    }
}

