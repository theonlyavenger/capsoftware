namespace Dashboard
{
    partial class course
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.headerpannel = new System.Windows.Forms.Panel();
            this.centerpanel = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.GroupBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcoursed = new System.Windows.Forms.TextBox();
            this.lblcoursefees = new System.Windows.Forms.Label();
            this.textBoxcoursef = new System.Windows.Forms.TextBox();
            this.lblcoursenm = new System.Windows.Forms.Label();
            this.textBoxcoursenm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.headerpannel.SuspendLayout();
            this.centerpanel.SuspendLayout();
            this.add.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "COMPUTRONICS - ABOUT DEVELOPERS";
            // 
            // headerpannel
            // 
            this.headerpannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.headerpannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerpannel.Controls.Add(this.label2);
            this.headerpannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpannel.Location = new System.Drawing.Point(0, 0);
            this.headerpannel.Name = "headerpannel";
            this.headerpannel.Size = new System.Drawing.Size(900, 58);
            this.headerpannel.TabIndex = 9;
            // 
            // centerpanel
            // 
            this.centerpanel.Controls.Add(this.add);
            this.centerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.centerpanel.Location = new System.Drawing.Point(0, 58);
            this.centerpanel.Name = "centerpanel";
            this.centerpanel.Size = new System.Drawing.Size(900, 138);
            this.centerpanel.TabIndex = 10;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.Controls.Add(this.submit);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.textBoxcoursed);
            this.add.Controls.Add(this.lblcoursefees);
            this.add.Controls.Add(this.textBoxcoursef);
            this.add.Controls.Add(this.lblcoursenm);
            this.add.Controls.Add(this.textBoxcoursenm);
            this.add.Location = new System.Drawing.Point(10, 6);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(880, 129);
            this.add.TabIndex = 10;
            this.add.TabStop = false;
            this.add.Text = "ADD COURSE TO COURSE TABLE";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(363, 82);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(154, 34);
            this.submit.TabIndex = 8;
            this.submit.Text = "ADD";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duration :";
            // 
            // textBoxcoursed
            // 
            this.textBoxcoursed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxcoursed.Location = new System.Drawing.Point(709, 22);
            this.textBoxcoursed.Name = "textBoxcoursed";
            this.textBoxcoursed.Size = new System.Drawing.Size(163, 26);
            this.textBoxcoursed.TabIndex = 6;
            // 
            // lblcoursefees
            // 
            this.lblcoursefees.AutoSize = true;
            this.lblcoursefees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursefees.Location = new System.Drawing.Point(347, 25);
            this.lblcoursefees.Name = "lblcoursefees";
            this.lblcoursefees.Size = new System.Drawing.Size(59, 20);
            this.lblcoursefees.TabIndex = 5;
            this.lblcoursefees.Text = "Fees :";
            // 
            // textBoxcoursef
            // 
            this.textBoxcoursef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxcoursef.Location = new System.Drawing.Point(412, 22);
            this.textBoxcoursef.Name = "textBoxcoursef";
            this.textBoxcoursef.Size = new System.Drawing.Size(163, 26);
            this.textBoxcoursef.TabIndex = 3;
            // 
            // lblcoursenm
            // 
            this.lblcoursenm.AutoSize = true;
            this.lblcoursenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursenm.Location = new System.Drawing.Point(9, 25);
            this.lblcoursenm.Name = "lblcoursenm";
            this.lblcoursenm.Size = new System.Drawing.Size(127, 20);
            this.lblcoursenm.TabIndex = 4;
            this.lblcoursenm.Text = "Course Name :";
            // 
            // textBoxcoursenm
            // 
            this.textBoxcoursenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxcoursenm.Location = new System.Drawing.Point(139, 22);
            this.textBoxcoursenm.Name = "textBoxcoursenm";
            this.textBoxcoursenm.Size = new System.Drawing.Size(163, 26);
            this.textBoxcoursenm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 465);
            this.panel1.TabIndex = 11;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(900, 465);
            this.dgv.TabIndex = 10;
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.centerpanel);
            this.Controls.Add(this.headerpannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.course1_Load);
            this.headerpannel.ResumeLayout(false);
            this.headerpannel.PerformLayout();
            this.centerpanel.ResumeLayout(false);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel headerpannel;
        private System.Windows.Forms.Panel centerpanel;
        private System.Windows.Forms.GroupBox add;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcoursed;
        private System.Windows.Forms.Label lblcoursefees;
        private System.Windows.Forms.TextBox textBoxcoursef;
        private System.Windows.Forms.Label lblcoursenm;
        private System.Windows.Forms.TextBox textBoxcoursenm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
    }
}

