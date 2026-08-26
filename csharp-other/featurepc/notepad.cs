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
    public partial class notepad : UserControl
    {
        public notepad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new apps());
        }
    }
}
