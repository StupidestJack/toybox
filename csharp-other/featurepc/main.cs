using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeaturePC
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new apps());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new browser());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new media());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new @lock());
        }
    }
}
