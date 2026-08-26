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
    public partial class Admin_Word_Tab : UserControl
    {
        public Admin_Word_Tab(string s)
        {
            InitializeComponent();
            this.s = s;
        }
        string s;
        private void Admin_Word_Tab_Load(object sender, EventArgs e)
        {
            resultb.Text = "";
            foreach (var a in Program.w[s]) { 
                if (a.Contains(searcht.Text))
                    resultb.Text += a + "\r\n";
            }
        }
    }
}
