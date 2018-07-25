namespace Dashboard
{
    partial class alumniCompany
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
            this.donotadd = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donotadd
            // 
            this.donotadd.AutoSize = true;
            this.donotadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.donotadd.Location = new System.Drawing.Point(12, 12);
            this.donotadd.Name = "donotadd";
            this.donotadd.Size = new System.Drawing.Size(234, 24);
            this.donotadd.TabIndex = 0;
            this.donotadd.TabStop = true;
            this.donotadd.Text = "Do Not Add Company Details";
            this.donotadd.UseVisualStyleBackColor = true;
            this.donotadd.CheckedChanged += new System.EventHandler(this.donotadd_CheckedChanged);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add.Location = new System.Drawing.Point(12, 46);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 24);
            this.add.TabIndex = 0;
            this.add.TabStop = true;
            this.add.Text = "Add Company Details";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCompanyName.Location = new System.Drawing.Point(12, 82);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(418, 26);
            this.txtCompanyName.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.Location = new System.Drawing.Point(178, 118);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(86, 30);
            this.submit.TabIndex = 2;
            this.submit.Text = "OK";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // alumniCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 164);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.donotadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "alumniCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Name";
            this.Load += new System.EventHandler(this.alumniCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton donotadd;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button submit;
    }
}