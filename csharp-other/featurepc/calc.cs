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
    public partial class calc : UserControl
    {
        public calc()
        {
            InitializeComponent();
        }

        private void a(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Text == "=")
            {
                try
                {
                    textBox1.Text = new DataTable().Compute(textBox1.Text, null).ToString();
                }
                catch
                {
                    textBox1.Text = "Error";
                }
            }
            else if (s.Text == "C")
            {
                textBox1.Clear();
            }
            else
            {
                textBox1.Text += s.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new apps());
        }
    }
}
