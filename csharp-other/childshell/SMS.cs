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
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.ReadOnly = true;
            }
            else
            {
                textBox2.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("找不到 SIM 卡 / 數據機。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox2.Text = "";
        }
    }
}
