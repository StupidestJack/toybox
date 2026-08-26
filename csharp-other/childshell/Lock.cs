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
    public partial class Lock : Form
    {
        public Lock()
        {
            InitializeComponent();
        }
        int tick = 0;
        bool closeFlag = false;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value >= 90)
            {
                closeFlag = true;
                new MainMenu().Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH : mm : ss");
            tick++;
            tick %= 7;
            switch (tick)
            {
                case 1:
                    滑.ForeColor = Color.LightBlue;
                    break;
                case 2:
                    滑.ForeColor = Color.White;
                    動.ForeColor = Color.LightBlue;
                    break;
                case 3:
                    動.ForeColor = Color.White;
                    來.ForeColor = Color.LightBlue;
                    break;
                case 4:
                    來.ForeColor = Color.White;
                    解.ForeColor = Color.LightBlue;
                    break;
                case 5:
                    解.ForeColor = Color.White;
                    鎖.ForeColor = Color.LightBlue;
                    break;
                default:
                    鎖.ForeColor = Color.White;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Lock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeFlag) e.Cancel = true;
        }
    }
}
