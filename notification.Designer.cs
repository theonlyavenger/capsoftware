namespace notification
{
    partial class notification
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
            this.panelnotification = new System.Windows.Forms.Panel();
            this.lblnotification = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpboxmessage = new System.Windows.Forms.GroupBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnsms = new System.Windows.Forms.Button();
            this.clbstudlist = new System.Windows.Forms.CheckedListBox();
            this.tbmessage = new System.Windows.Forms.TextBox();
            this.listBoxdisplay = new System.Windows.Forms.ListBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.rbtype = new System.Windows.Forms.RadioButton();
            this.cbmessage = new System.Windows.Forms.ComboBox();
            this.rbselect = new System.Windows.Forms.RadioButton();
            this.lblto = new System.Windows.Forms.Label();
            this.panelnotification.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpboxmessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelnotification
            // 
            this.panelnotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelnotification.Controls.Add(this.lblnotification);
            this.panelnotification.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelnotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelnotification.Location = new System.Drawing.Point(0, 0);
            this.panelnotification.Name = "panelnotification";
            this.panelnotification.Size = new System.Drawing.Size(894, 58);
            this.panelnotification.TabIndex = 5;
            // 
            // lblnotification
            // 
            this.lblnotification.AutoSize = true;
            this.lblnotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotification.ForeColor = System.Drawing.Color.White;
            this.lblnotification.Location = new System.Drawing.Point(8, 16);
            this.lblnotification.Name = "lblnotification";
            this.lblnotification.Size = new System.Drawing.Size(337, 48);
            this.lblnotification.TabIndex = 0;
            this.lblnotification.Text = "COMPUTRONICS - NOTIFICATION\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpboxmessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 593);
            this.panel1.TabIndex = 6;
            // 
            // grpboxmessage
            // 
            this.grpboxmessage.AutoSize = true;
            this.grpboxmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grpboxmessage.Controls.Add(this.btnselect);
            this.grpboxmessage.Controls.Add(this.btnsms);
            this.grpboxmessage.Controls.Add(this.clbstudlist);
            this.grpboxmessage.Controls.Add(this.tbmessage);
            this.grpboxmessage.Controls.Add(this.listBoxdisplay);
            this.grpboxmessage.Controls.Add(this.btnsend);
            this.grpboxmessage.Controls.Add(this.rbtype);
            this.grpboxmessage.Controls.Add(this.cbmessage);
            this.grpboxmessage.Controls.Add(this.rbselect);
            this.grpboxmessage.Controls.Add(this.lblto);
            this.grpboxmessage.Location = new System.Drawing.Point(12, 9);
            this.grpboxmessage.Name = "grpboxmessage";
            this.grpboxmessage.Size = new System.Drawing.Size(870, 576);
            this.grpboxmessage.TabIndex = 1;
            this.grpboxmessage.TabStop = false;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnselect.FlatAppearance.BorderSize = 0;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.Location = new System.Drawing.Point(684, 534);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(104, 23);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click_1);
            // 
            // btnsms
            // 
            this.btnsms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnsms.FlatAppearance.BorderSize = 0;
            this.btnsms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsms.Location = new System.Drawing.Point(340, 478);
            this.btnsms.Name = "btnsms";
            this.btnsms.Size = new System.Drawing.Size(129, 40);
            this.btnsms.TabIndex = 7;
            this.btnsms.Text = "Send sms";
            this.btnsms.UseVisualStyleBackColor = false;
            this.btnsms.Click += new System.EventHandler(this.btnsms_Click);
            // 
            // clbstudlist
            // 
            this.clbstudlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbstudlist.FormattingEnabled = true;
            this.clbstudlist.HorizontalScrollbar = true;
            this.clbstudlist.Location = new System.Drawing.Point(616, 19);
            this.clbstudlist.MaximumSize = new System.Drawing.Size(500, 500);
            this.clbstudlist.Name = "clbstudlist";
            this.clbstudlist.ScrollAlwaysVisible = true;
            this.clbstudlist.Size = new System.Drawing.Size(236, 499);
            this.clbstudlist.TabIndex = 2;
            // 
            // tbmessage
            // 
            this.tbmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmessage.Location = new System.Drawing.Point(219, 143);
            this.tbmessage.Multiline = true;
            this.tbmessage.Name = "tbmessage";
            this.tbmessage.Size = new System.Drawing.Size(391, 251);
            this.tbmessage.TabIndex = 5;
            // 
            // listBoxdisplay
            // 
            this.listBoxdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxdisplay.FormattingEnabled = true;
            this.listBoxdisplay.HorizontalScrollbar = true;
            this.listBoxdisplay.ItemHeight = 20;
            this.listBoxdisplay.Location = new System.Drawing.Point(10, 39);
            this.listBoxdisplay.Name = "listBoxdisplay";
            this.listBoxdisplay.Size = new System.Drawing.Size(203, 484);
            this.listBoxdisplay.TabIndex = 4;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(195)))));
            this.btnsend.FlatAppearance.BorderSize = 0;
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.Location = new System.Drawing.Point(340, 415);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(129, 40);
            this.btnsend.TabIndex = 6;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click_1);
            // 
            // rbtype
            // 
            this.rbtype.AutoSize = true;
            this.rbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtype.Location = new System.Drawing.Point(219, 113);
            this.rbtype.Name = "rbtype";
            this.rbtype.Size = new System.Drawing.Size(143, 24);
            this.rbtype.TabIndex = 4;
            this.rbtype.TabStop = true;
            this.rbtype.Text = "Type a message";
            this.rbtype.UseVisualStyleBackColor = true;
            this.rbtype.CheckedChanged += new System.EventHandler(this.rbtype_CheckedChanged_1);
            // 
            // cbmessage
            // 
            this.cbmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmessage.FormattingEnabled = true;
            this.cbmessage.Items.AddRange(new object[] {
            "fees pending",
            "exam pending"});
            this.cbmessage.Location = new System.Drawing.Point(219, 69);
            this.cbmessage.Name = "cbmessage";
            this.cbmessage.Size = new System.Drawing.Size(391, 28);
            this.cbmessage.TabIndex = 3;
            // 
            // rbselect
            // 
            this.rbselect.AutoSize = true;
            this.rbselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbselect.Location = new System.Drawing.Point(219, 39);
            this.rbselect.Name = "rbselect";
            this.rbselect.Size = new System.Drawing.Size(154, 24);
            this.rbselect.TabIndex = 2;
            this.rbselect.TabStop = true;
            this.rbselect.Text = "Select a message";
            this.rbselect.UseVisualStyleBackColor = true;
            this.rbselect.CheckedChanged += new System.EventHandler(this.rbselect_CheckedChanged_1);
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(6, 16);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(27, 20);
            this.lblto.TabIndex = 0;
            this.lblto.Text = "To";
            // 
            // notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelnotification);
            this.Name = "notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notification";
            this.Load += new System.EventHandler(this.notification_Load);
            this.panelnotification.ResumeLayout(false);
            this.panelnotification.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpboxmessage.ResumeLayout(false);
            this.grpboxmessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelnotification;
        private System.Windows.Forms.Label lblnotification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpboxmessage;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnsms;
        private System.Windows.Forms.CheckedListBox clbstudlist;
        private System.Windows.Forms.TextBox tbmessage;
        private System.Windows.Forms.ListBox listBoxdisplay;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.RadioButton rbtype;
        private System.Windows.Forms.ComboBox cbmessage;
        private System.Windows.Forms.RadioButton rbselect;
        private System.Windows.Forms.Label lblto;

    }
}