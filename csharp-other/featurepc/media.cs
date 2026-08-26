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
    public partial class media : UserControl
    {
        public media()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Program.sb.ChgScr(new main());
        }
    }
}
