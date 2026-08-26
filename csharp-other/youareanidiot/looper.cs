using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace YouAreAnIdiot
{
    public partial class looper : Form
    {
        public looper()
        {
            InitializeComponent();
        }

        private void looper_Load(object sender, EventArgs e)
        {
            MessageBox.Show("注意：此軟體需在任一視窗中按下E鍵方可退出。","You Are An Idiot重製版",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            new Form1().Show();
            string temp = Path.Combine(Path.GetTempPath(), "You Are An Idiot配樂.mp3");
            File.WriteAllBytes(temp, Properties.Resources.sound);
            System.Diagnostics.Process.Start(temp);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
