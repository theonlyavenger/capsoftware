namespace Dashboard
{
    partial class analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.headerpannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.centerpannel = new System.Windows.Forms.Panel();
            this.coursechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblbatchdetails = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Panel();
            this.headerpannel.SuspendLayout();
            this.centerpannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursechart)).BeginInit();
            this.header2.SuspendLayout();
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
            this.headerpannel.Size = new System.Drawing.Size(900, 58);
            this.headerpannel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUTRONICS - ANALYTICS";
            // 
            // centerpannel
            // 
            this.centerpannel.BackColor = System.Drawing.Color.White;
            this.centerpannel.Controls.Add(this.header2);
            this.centerpannel.Controls.Add(this.coursechart);
            this.centerpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerpannel.Location = new System.Drawing.Point(0, 58);
            this.centerpannel.Name = "centerpannel";
            this.centerpannel.Size = new System.Drawing.Size(900, 603);
            this.centerpannel.TabIndex = 4;
            // 
            // coursechart
            // 
            chartArea3.Name = "ChartArea1";
            this.coursechart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.coursechart.Legends.Add(legend3);
            this.coursechart.Location = new System.Drawing.Point(12, 45);
            this.coursechart.Name = "coursechart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "courses";
            this.coursechart.Series.Add(series3);
            this.coursechart.Size = new System.Drawing.Size(876, 300);
            this.coursechart.TabIndex = 0;
            this.coursechart.Text = "chart1";
            // 
            // lblbatchdetails
            // 
            this.lblbatchdetails.AutoSize = true;
            this.lblbatchdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbatchdetails.ForeColor = System.Drawing.Color.White;
            this.lblbatchdetails.Location = new System.Drawing.Point(12, 7);
            this.lblbatchdetails.Name = "lblbatchdetails";
            this.lblbatchdetails.Size = new System.Drawing.Size(163, 20);
            this.lblbatchdetails.TabIndex = 100;
            this.lblbatchdetails.Text = "Courses in demand";
            // 
            // header2
            // 
            this.header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.header2.Controls.Add(this.lblbatchdetails);
            this.header2.Location = new System.Drawing.Point(0, 0);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(900, 35);
            this.header2.TabIndex = 128;
            // 
            // analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 661);
            this.Controls.Add(this.centerpannel);
            this.Controls.Add(this.headerpannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "analytics";
            this.Load += new System.EventHandler(this.analytics_Load);
            this.headerpannel.ResumeLayout(false);
            this.headerpannel.PerformLayout();
            this.centerpannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursechart)).EndInit();
            this.header2.ResumeLayout(false);
            this.header2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerpannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel centerpannel;
        private System.Windows.Forms.DataVisualization.Charting.Chart coursechart;
        private System.Windows.Forms.Panel header2;
        private System.Windows.Forms.Label lblbatchdetails;
    }
}