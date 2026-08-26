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
    public partial class Entertainment : Form
    {
        public Entertainment()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("res\\Shin.mp4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\LocalForecast.mp3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\FluffingADuck.mp3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\winmine.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\ntpad.exe", "res\\sfs.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\ntpad.exe","res\\twt.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //https://music.youtube.com/watch?v=Y1VKKboWu-8
            new Browser("https://music.youtube.com/watch?v=Y1VKKboWu-8").Show();
        }
    }
}
