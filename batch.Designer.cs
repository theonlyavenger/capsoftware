namespace Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.headerpannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelresult = new System.Windows.Forms.Label();
            this.lblresultfound = new System.Windows.Forms.Label();
            this.lbdisplay = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addone = new System.Windows.Forms.Button();
            this.addall = new System.Windows.Forms.Button();
            this.clearselected = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
            this.tbbatchtiming = new System.Windows.Forms.TextBox();
            this.lblbatchtiming = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.cbbatchlist = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.clbdisplaylist = new System.Windows.Forms.CheckedListBox();
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
            this.viewBatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchlistbox = new System.Windows.Forms.ListBox();
            this.errorProviderBatchtiming = new System.Windows.Forms.ErrorProvider(this.components);
            this.addalldisabletimer = new System.Windows.Forms.Timer(this.components);
            this.headerpannel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBatchtiming)).BeginInit();
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
            this.panel1.Controls.Add(this.labelresult);
            this.panel1.Controls.Add(this.lblresultfound);
            this.panel1.Controls.Add(this.lbdisplay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addone);
            this.panel1.Controls.Add(this.addall);
            this.panel1.Controls.Add(this.clearselected);
            this.panel1.Controls.Add(this.clearall);
            this.panel1.Controls.Add(this.tbbatchtiming);
            this.panel1.Controls.Add(this.lblbatchtiming);
            this.panel1.Controls.Add(this.lblcourse);
            this.panel1.Controls.Add(this.cbbatchlist);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.clbdisplaylist);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.searchlistbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 613);
            this.panel1.TabIndex = 3;
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(159, 575);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(122, 20);
            this.labelresult.TabIndex = 143;
            this.labelresult.Text = "Result(s) found.";
            // 
            // lblresultfound
            // 
            this.lblresultfound.AutoSize = true;
            this.lblresultfound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultfound.Location = new System.Drawing.Point(136, 575);
            this.lblresultfound.Name = "lblresultfound";
            this.lblresultfound.Size = new System.Drawing.Size(50, 20);
            this.lblresultfound.TabIndex = 143;
            this.lblresultfound.Text = "NULL";
            // 
            // lbdisplay
            // 
            this.lbdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbdisplay.FormattingEnabled = true;
            this.lbdisplay.ItemHeight = 20;
            this.lbdisplay.Location = new System.Drawing.Point(533, 178);
            this.lbdisplay.Name = "lbdisplay";
            this.lbdisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbdisplay.Size = new System.Drawing.Size(333, 384);
            this.lbdisplay.TabIndex = 142;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(419, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 141;
            this.label6.Text = "DELETE ALL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(428, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 141;
            this.label4.Text = "ADD ALL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(400, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 141;
            this.label5.Text = "DELETE SELECTED\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(410, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "ADD SELECTED\r\n";
            // 
            // addone
            // 
            this.addone.BackColor = System.Drawing.Color.Transparent;
            this.addone.BackgroundImage = global::Dashboard.Properties.Resources.icons8_chevron_right_64;
            this.addone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addone.FlatAppearance.BorderSize = 0;
            this.addone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addone.Location = new System.Drawing.Point(417, 200);
            this.addone.Name = "addone";
            this.addone.Size = new System.Drawing.Size(75, 46);
            this.addone.TabIndex = 140;
            this.addone.UseVisualStyleBackColor = false;
            this.addone.Click += new System.EventHandler(this.addone_Click);
            // 
            // addall
            // 
            this.addall.BackColor = System.Drawing.Color.Transparent;
            this.addall.BackgroundImage = global::Dashboard.Properties.Resources.icons8_forward_64;
            this.addall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addall.FlatAppearance.BorderSize = 0;
            this.addall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addall.Location = new System.Drawing.Point(417, 291);
            this.addall.Name = "addall";
            this.addall.Size = new System.Drawing.Size(75, 46);
            this.addall.TabIndex = 140;
            this.addall.UseVisualStyleBackColor = false;
            this.addall.Click += new System.EventHandler(this.addall_Click);
            // 
            // clearselected
            // 
            this.clearselected.BackColor = System.Drawing.Color.Transparent;
            this.clearselected.BackgroundImage = global::Dashboard.Properties.Resources.icons8_cancel_64;
            this.clearselected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearselected.FlatAppearance.BorderSize = 0;
            this.clearselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearselected.Location = new System.Drawing.Point(417, 373);
            this.clearselected.Name = "clearselected";
            this.clearselected.Size = new System.Drawing.Size(75, 46);
            this.clearselected.TabIndex = 140;
            this.clearselected.UseVisualStyleBackColor = false;
            this.clearselected.Click += new System.EventHandler(this.clearselected_Click);
            // 
            // clearall
            // 
            this.clearall.BackColor = System.Drawing.Color.Transparent;
            this.clearall.BackgroundImage = global::Dashboard.Properties.Resources.icons8_delete_file_64;
            this.clearall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearall.FlatAppearance.BorderSize = 0;
            this.clearall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearall.Location = new System.Drawing.Point(417, 460);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(75, 46);
            this.clearall.TabIndex = 140;
            this.clearall.UseVisualStyleBackColor = false;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // tbbatchtiming
            // 
            this.tbbatchtiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbbatchtiming.Location = new System.Drawing.Point(641, 51);
            this.tbbatchtiming.Name = "tbbatchtiming";
            this.tbbatchtiming.Size = new System.Drawing.Size(208, 26);
            this.tbbatchtiming.TabIndex = 138;
            this.tbbatchtiming.Validating += new System.ComponentModel.CancelEventHandler(this.tbbatchtiming_Validating);
            // 
            // lblbatchtiming
            // 
            this.lblbatchtiming.AutoSize = true;
            this.lblbatchtiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatchtiming.Location = new System.Drawing.Point(512, 54);
            this.lblbatchtiming.Name = "lblbatchtiming";
            this.lblbatchtiming.Size = new System.Drawing.Size(123, 20);
            this.lblbatchtiming.TabIndex = 137;
            this.lblbatchtiming.Text = "Batch Timing :";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(57, 54);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(132, 20);
            this.lblcourse.TabIndex = 136;
            this.lblcourse.Text = "Select Course :";
            // 
            // cbbatchlist
            // 
            this.cbbatchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbatchlist.FormattingEnabled = true;
            this.cbbatchlist.Location = new System.Drawing.Point(195, 49);
            this.cbbatchlist.Name = "cbbatchlist";
            this.cbbatchlist.Size = new System.Drawing.Size(199, 28);
            this.cbbatchlist.TabIndex = 135;
            this.cbbatchlist.SelectedIndexChanged += new System.EventHandler(this.cbbatchlist_SelectedIndexChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(287, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 26);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSearch.Location = new System.Drawing.Point(51, 141);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(230, 26);
            this.tbSearch.TabIndex = 133;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // clbdisplaylist
            // 
            this.clbdisplaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clbdisplaylist.FormattingEnabled = true;
            this.clbdisplaylist.Location = new System.Drawing.Point(527, 180);
            this.clbdisplaylist.Name = "clbdisplaylist";
            this.clbdisplaylist.Size = new System.Drawing.Size(0, 4);
            this.clbdisplaylist.TabIndex = 128;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 97);
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
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "STUDENTS LIST";
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
            this.makeBatchToolStripMenuItem,
            this.viewBatchesToolStripMenuItem});
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
            this.makeBatchToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.makeBatchToolStripMenuItem.Text = "Allocate Batch";
            // 
            // b1ToolStripMenuItem
            // 
            this.b1ToolStripMenuItem.Name = "b1ToolStripMenuItem";
            this.b1ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.b1ToolStripMenuItem.Text = "B1";
            this.b1ToolStripMenuItem.Click += new System.EventHandler(this.b1ToolStripMenuItem_Click);
            // 
            // b2ToolStripMenuItem
            // 
            this.b2ToolStripMenuItem.Name = "b2ToolStripMenuItem";
            this.b2ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.b2ToolStripMenuItem.Text = "B2";
            this.b2ToolStripMenuItem.Click += new System.EventHandler(this.b2ToolStripMenuItem_Click);
            // 
            // b3ToolStripMenuItem
            // 
            this.b3ToolStripMenuItem.Name = "b3ToolStripMenuItem";
            this.b3ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.b3ToolStripMenuItem.Text = "B3";
            this.b3ToolStripMenuItem.Click += new System.EventHandler(this.b3ToolStripMenuItem_Click);
            // 
            // b4ToolStripMenuItem
            // 
            this.b4ToolStripMenuItem.Name = "b4ToolStripMenuItem";
            this.b4ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.b4ToolStripMenuItem.Text = "B4";
            this.b4ToolStripMenuItem.Click += new System.EventHandler(this.b4ToolStripMenuItem_Click);
            // 
            // b5ToolStripMenuItem
            // 
            this.b5ToolStripMenuItem.Name = "b5ToolStripMenuItem";
            this.b5ToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.b5ToolStripMenuItem.Text = "B5";
            this.b5ToolStripMenuItem.Click += new System.EventHandler(this.b5ToolStripMenuItem_Click);
            // 
            // viewBatchesToolStripMenuItem
            // 
            this.viewBatchesToolStripMenuItem.Name = "viewBatchesToolStripMenuItem";
            this.viewBatchesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewBatchesToolStripMenuItem.Text = "View Batches";
            this.viewBatchesToolStripMenuItem.Click += new System.EventHandler(this.viewBatchesToolStripMenuItem_Click);
            // 
            // searchlistbox
            // 
            this.searchlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchlistbox.FormattingEnabled = true;
            this.searchlistbox.ItemHeight = 20;
            this.searchlistbox.Location = new System.Drawing.Point(51, 178);
            this.searchlistbox.Name = "searchlistbox";
            this.searchlistbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.searchlistbox.Size = new System.Drawing.Size(333, 384);
            this.searchlistbox.TabIndex = 139;
            // 
            // errorProviderBatchtiming
            // 
            this.errorProviderBatchtiming.ContainerControl = this;
            // 
            // addalldisabletimer
            // 
            this.addalldisabletimer.Tick += new System.EventHandler(this.addalldisabletimer_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBatchtiming)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerpannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbdisplaylist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBatchesToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button addone;
        private System.Windows.Forms.Button addall;
        private System.Windows.Forms.Button clearselected;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.TextBox tbbatchtiming;
        private System.Windows.Forms.Label lblbatchtiming;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.ComboBox cbbatchlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox searchlistbox;
        private System.Windows.Forms.ListBox lbdisplay;
        private System.Windows.Forms.ErrorProvider errorProviderBatchtiming;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Label lblresultfound;
        private System.Windows.Forms.Timer addalldisabletimer;
    }
}

