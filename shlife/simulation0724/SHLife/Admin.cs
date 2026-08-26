using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void cs(Control c)
        {
            mp.Controls.Clear();
            mp.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cs(new UC.VSW());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs(new UC.CVR());
        }
    }
}
