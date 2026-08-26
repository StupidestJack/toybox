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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\calcu.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("res\\paint.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dialer().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SMS().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Browser().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Settings().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Entertainment().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Notepad().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Lock().Show();
        }
    }
}
