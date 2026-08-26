using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife.UC
{
    public partial class Admin_Word : UserControl
    {
        public Admin_Word()
        {
            InitializeComponent();
        }

        private void Admin_Word_Load(object sender, EventArgs e)
        {
            foreach (var s in Program.w)
            {
                var tp = new TabPage();
                tp.Controls.Add(new Admin_Word_Tab(s.Key) { Dock = DockStyle.Fill});
                tabControl1.TabPages.Add(tp);
            }
        }
    }
}
