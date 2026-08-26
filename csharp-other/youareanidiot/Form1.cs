using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YouAreAnIdiot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(random.Next(Program.bounds.Width-286), random.Next(Program.bounds.Height-215));
        }
        int speedX = 5;
        int speedY = 5;
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            Program.formCount++;
            this.Text = "Form" + Program.formCount.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.Location.X);
            int y = Convert.ToInt32(this.Location.Y);
            if (x < -1) speedX *= -1;
            if (x > Program.bounds.Width - 286) speedX *= -1;
            if (y < -1) speedY *= -1;
            if (y > Program.bounds.Height - 215) speedY *= -1;
            this.Location = new Point(x+speedX, y + speedY);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Program.close)
            {
                for (int i = 0; i < 4; i++)
                {
                    new Form1().Show();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                Program.close = true;
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
