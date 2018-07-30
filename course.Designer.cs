namespace coursefi
{
    partial class course1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.textBoxcoursenm = new System.Windows.Forms.TextBox();
            this.textBoxcoursef = new System.Windows.Forms.TextBox();
            this.lblcoursenm = new System.Windows.Forms.Label();
            this.lblcoursefees = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.GroupBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcoursed = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.add.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(88, 208);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(520, 232);
            this.dgv.TabIndex = 1;
            // 
            // textBoxcoursenm
            // 
            this.textBoxcoursenm.Location = new System.Drawing.Point(136, 40);
            this.textBoxcoursenm.Name = "textBoxcoursenm";
            this.textBoxcoursenm.Size = new System.Drawing.Size(124, 20);
            this.textBoxcoursenm.TabIndex = 2;
            // 
            // textBoxcoursef
            // 
            this.textBoxcoursef.Location = new System.Drawing.Point(432, 40);
            this.textBoxcoursef.Name = "textBoxcoursef";
            this.textBoxcoursef.Size = new System.Drawing.Size(124, 20);
            this.textBoxcoursef.TabIndex = 3;
            // 
            // lblcoursenm
            // 
            this.lblcoursenm.AutoSize = true;
            this.lblcoursenm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursenm.Location = new System.Drawing.Point(8, 40);
            this.lblcoursenm.Name = "lblcoursenm";
            this.lblcoursenm.Size = new System.Drawing.Size(107, 20);
            this.lblcoursenm.TabIndex = 4;
            this.lblcoursenm.Text = "coursename";
            // 
            // lblcoursefees
            // 
            this.lblcoursefees.AutoSize = true;
            this.lblcoursefees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursefees.Location = new System.Drawing.Point(304, 40);
            this.lblcoursefees.Name = "lblcoursefees";
            this.lblcoursefees.Size = new System.Drawing.Size(103, 20);
            this.lblcoursefees.TabIndex = 5;
            this.lblcoursefees.Text = "course fees";
            // 
            // add
            // 
            this.add.Controls.Add(this.submit);
            this.add.Controls.Add(this.label1);
            this.add.Controls.Add(this.textBoxcoursed);
            this.add.Controls.Add(this.lblcoursefees);
            this.add.Controls.Add(this.textBoxcoursef);
            this.add.Controls.Add(this.lblcoursenm);
            this.add.Controls.Add(this.textBoxcoursenm);
            this.add.Location = new System.Drawing.Point(8, 40);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(880, 152);
            this.add.TabIndex = 6;
            this.add.TabStop = false;
            this.add.Text = "add";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(448, 96);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 40);
            this.submit.TabIndex = 8;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "course duration";
            // 
            // textBoxcoursed
            // 
            this.textBoxcoursed.Location = new System.Drawing.Point(736, 40);
            this.textBoxcoursed.Name = "textBoxcoursed";
            this.textBoxcoursed.Size = new System.Drawing.Size(124, 20);
            this.textBoxcoursed.TabIndex = 6;
            // 
            // course1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "course1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "course1";
            this.Load += new System.EventHandler(this.course1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBoxcoursenm;
        private System.Windows.Forms.TextBox textBoxcoursef;
        private System.Windows.Forms.Label lblcoursenm;
        private System.Windows.Forms.Label lblcoursefees;
        private System.Windows.Forms.GroupBox add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcoursed;
        private System.Windows.Forms.Button submit;
    }
}

