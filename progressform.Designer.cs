namespace progressform2
{
    partial class progressform
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
            this.label1 = new System.Windows.Forms.Label();
            this.headerpannel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerpanel = new System.Windows.Forms.Panel();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.headerpannel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.centerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUTRONICS-PROGRESS DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.headerpannel.Paint += new System.Windows.Forms.PaintEventHandler(this.headerpannel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.centerpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 613);
            this.panel1.TabIndex = 3;
            // 
            // centerpanel
            // 
            this.centerpanel.Controls.Add(this.dataTable);
            this.centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpanel.Location = new System.Drawing.Point(0, 0);
            this.centerpanel.Name = "centerpanel";
            this.centerpanel.Size = new System.Drawing.Size(910, 613);
            this.centerpanel.TabIndex = 2;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(0, 0);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(910, 613);
            this.dataTable.TabIndex = 0;
            // 
            // progressform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 671);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerpannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "progressform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.progressform2_Load);
            this.headerpannel.ResumeLayout(false);
            this.headerpannel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.centerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel headerpannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel centerpanel;
        private System.Windows.Forms.DataGridView dataTable;

        // private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}

