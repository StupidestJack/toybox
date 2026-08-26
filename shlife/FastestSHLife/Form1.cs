using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastestSHLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var d = new a())
            {
                var a = d.Account.First(x => x.Email == textBox1.Text && x.Password  == textBox2.Text);
                if (a == null) return;
                else
                {
                    Program.a = a;
                    this.Hide();
                    new Form2().ShowDialog();
                    this.Show();
                }
            }
        }
    }
}
