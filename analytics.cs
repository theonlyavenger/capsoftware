using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class analytics : Form
    {
        public analytics()
        {
            InitializeComponent();
        }

        private void analytics_Load(object sender, EventArgs e)
        {
            coursechart.Series["courses"].Points.AddXY("Course name", 10);
            coursechart.Series["courses"].Points.AddXY("Course name", 20);
            coursechart.Series["courses"].Points.AddXY("Course name", 30);
            coursechart.Series["courses"].Points.AddXY("Course name", 20);
            coursechart.Series["courses"].Points.AddXY("Course name", 10);
        }
    }
}
