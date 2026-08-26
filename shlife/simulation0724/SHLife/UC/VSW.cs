using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SHLife.UC
{
    public partial class VSW : UserControl
    {
        public VSW()
        {
            InitializeComponent();
        }
        string[][] libs =
        {
            Properties.Resources.广告.Split('\n'),
            Properties.Resources.网址.Split('\n'),
            Properties.Resources.色情类.Split('\n'),
            Properties.Resources.政治类.Split('\n'),
            Properties.Resources.涉枪涉爆.Split('\n'),
        };
        string[] words;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VSW_Load(object sender, EventArgs e)
        {
            words = libs[0];
            textBox2.Text = "";
            foreach (string word in words)
            {
                textBox2.Text += word + "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (string word in words)
            {
                if (word.Contains(textBox1.Text))
                    textBox2.Text += word + "\r\n";
            }
        }

        private async void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            words = libs[e.TabPageIndex];
            textBox2.Text = "";
            int c = 0;
            foreach (string word in words)
            {
                //Console.WriteLine(c++.ToString());
                textBox2.Text += word;
                textBox2.Text += (word.EndsWith("\r") ? "\n" : "\r\n") ;
                //await Task.Delay(1);
            }
        }
    }
}
