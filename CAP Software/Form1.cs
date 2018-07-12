using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAP_Software
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void home_Load(object sender, EventArgs e)
        {
            //resize();
        }       
        /*private void resize()
        {
            
            int x, y, a, b;
            y = centerpanel.Size.Height;
            x = centerpanel.Size.Width;

            a = groupBox1.Size.Height;
            b = groupBox1.Size.Width;


            int halfx, halfy;

            halfx = (x / 2) - (b / 2);
            halfy = (y / 2) - (a / 2);


            groupBox1.Left = halfx;
            groupBox1.Top = halfy;
        }*/
       
    }
}
