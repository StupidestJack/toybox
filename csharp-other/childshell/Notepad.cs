using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChildShell
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note1.txt", richTextBox1.Text);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note2.txt", richTextBox1.Text);
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note3.txt", richTextBox1.Text);
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note4.txt", richTextBox1.Text);
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note5.txt", richTextBox1.Text);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText("res\\note\\note0.txt");
            richTextBox2.Text = File.ReadAllText("res\\note\\note1.txt");
            richTextBox3.Text = File.ReadAllText("res\\note\\note2.txt");
            richTextBox4.Text = File.ReadAllText("res\\note\\note3.txt");
            richTextBox5.Text = File.ReadAllText("res\\note\\note4.txt");
            richTextBox6.Text = File.ReadAllText("res\\note\\note5.txt");
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            File.WriteAllText("res\\note\\note0.txt", richTextBox1.Text);
        }
    }
}
