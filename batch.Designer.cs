namespace batches
{
    partial class batch
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
            this.headerpannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clbdisplaylist = new System.Windows.Forms.CheckedListBox();
            this.cbbatchlist = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblbatchtiming = new System.Windows.Forms.Label();
            this.tbbatchtiming = new System.Windows.Forms.TextBox();
            this.headerpannel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpannel
            // 
            this.headerpannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.headerpannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerpannel.Controls.Add(this.label1);
            this.headerpannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpannel.Location = new System.Drawing.Point(0, 0);
            this.headerpannel.Name = "headerpannel";
            this.headerpannel.Size = new System.Drawing.Size(910, 58);
            this.headerpannel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUTRONICS - BATCH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbbatchtiming);
            this.panel1.Controls.Add(this.lblbatchtiming);
            this.panel1.Controls.Add(this.lblcourse);
            this.panel1.Controls.Add(this.clbdisplaylist);
            this.panel1.Controls.Add(this.cbbatchlist);
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 613);
            this.panel1.TabIndex = 3;
            // 
            // clbdisplaylist
            // 
            this.clbdisplaylist.FormattingEnabled = true;
            this.clbdisplaylist.Location = new System.Drawing.Point(66, 291);
            this.clbdisplaylist.Name = "clbdisplaylist";
            this.clbdisplaylist.Size = new System.Drawing.Size(299, 364);
            this.clbdisplaylist.TabIndex = 128;
            // 
            // cbbatchlist
            // 
            this.cbbatchlist.FormattingEnabled = true;
            this.cbbatchlist.Location = new System.Drawing.Point(526, 285);
            this.cbbatchlist.Name = "cbbatchlist";
            this.cbbatchlist.Size = new System.Drawing.Size(151, 21);
            this.cbbatchlist.TabIndex = 127;
            this.cbbatchlist.SelectedIndexChanged += new System.EventHandler(this.cbbatchlist_SelectedIndexChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(495, 556);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 126;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 35);
            this.panel2.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "HEADER IF REQUIRED";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 129;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBatchToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeBatchToolStripMenuItem
            // 
            this.makeBatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b1ToolStripMenuItem,
            this.b2ToolStripMenuItem,
            this.b3ToolStripMenuItem,
            this.b4ToolStripMenuItem,
            this.b5ToolStripMenuItem});
            this.makeBatchToolStripMenuItem.Name = "makeBatchToolStripMenuItem";
            this.makeBatchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makeBatchToolStripMenuItem.Text = "Make Batch";
            // 
            // b1ToolStripMenuItem
            // 
            this.b1ToolStripMenuItem.Name = "b1ToolStripMenuItem";
            this.b1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.b1ToolStripMenuItem.Text = "B1";
            this.b1ToolStripMenuItem.Click += new System.EventHandler(this.b1ToolStripMenuItem_Click);
            // 
            // b2ToolStripMenuItem
            // 
            this.b2ToolStripMenuItem.Name = "b2ToolStripMenuItem";
            this.b2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.b2ToolStripMenuItem.Text = "B2";
            // 
            // b3ToolStripMenuItem
            // 
            this.b3ToolStripMenuItem.Name = "b3ToolStripMenuItem";
            this.b3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.b3ToolStripMenuItem.Text = "B3";
            // 
            // b4ToolStripMenuItem
            // 
            this.b4ToolStripMenuItem.Name = "b4ToolStripMenuItem";
            this.b4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.b4ToolStripMenuItem.Text = "B4";
            // 
            // b5ToolStripMenuItem
            // 
            this.b5ToolStripMenuItem.Name = "b5ToolStripMenuItem";
            this.b5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.b5ToolStripMenuItem.Text = "B5";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(414, 293);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(73, 13);
            this.lblcourse.TabIndex = 130;
            this.lblcourse.Text = "Select Course";
            // 
            // lblbatchtiming
            // 
            this.lblbatchtiming.AutoSize = true;
            this.lblbatchtiming.Location = new System.Drawing.Point(418, 387);
            this.lblbatchtiming.Name = "lblbatchtiming";
            this.lblbatchtiming.Size = new System.Drawing.Size(69, 13);
            this.lblbatchtiming.TabIndex = 131;
            this.lblbatchtiming.Text = "Batch Timing";
            // 
            // tbbatchtiming
            // 
            this.tbbatchtiming.Location = new System.Drawing.Point(526, 380);
            this.tbbatchtiming.Name = "tbbatchtiming";
            this.tbbatchtiming.Size = new System.Drawing.Size(151, 20);
            this.tbbatchtiming.TabIndex = 132;
            // 
            // batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerpannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.batch_Load);
            this.headerpannel.ResumeLayout(false);
            this.headerpannel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerpannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ComboBox cbbatchlist;
        private System.Windows.Forms.CheckedListBox clbdisplaylist;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b5ToolStripMenuItem;
        private System.Windows.Forms.TextBox tbbatchtiming;
        private System.Windows.Forms.Label lblbatchtiming;
    }
}

