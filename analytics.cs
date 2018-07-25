using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace analytics
{
    public partial class analytics : Form
    {
        public analytics()
        {
            InitializeComponent();
        }

        private void analytics_Load(object sender, EventArgs e)
        {
            analyticsChart.Series["COURSE"].Points.AddXY("C", 40);
            analyticsChart.Series["COURSE"].Points.AddXY("C++", 10);
            analyticsChart.Series["COURSE"].Points.AddXY("C#", 5);
            analyticsChart.Series["COURSE"].Points.AddXY("JAVA", 45);
            analyticsChart.Series["COURSE"].Points.AddXY("PYTHON", 20);

        }
    }
}
