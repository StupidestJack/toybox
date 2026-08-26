using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildShell
{
    public partial class Dialer : Form
    {
        public Dialer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("找不到 SIM 卡 / 數據機。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Dialer_Load(object sender, EventArgs e)
        {

        }
    }
}
