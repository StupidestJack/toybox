using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife
{
    public partial class MainForm : Form
    {
        Point originMouseLocation;
        bool isMoving = false;
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        public void ChgScr(Control c, string t)
        {
            titleLbl.Text = "滬享生活-" + t;
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = 
                this.WindowState == FormWindowState.Maximized ?
                FormWindowState.Normal : FormWindowState.Maximized;
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void topPbl_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            originMouseLocation = e.Location;
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void topPbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving) {
                this.Location = new Point(
                    this.Location.X + (e.Location.X - originMouseLocation.X),
                    this.Location.Y + (e.Location.Y - originMouseLocation.Y));
            }
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void topPbl_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = "系統時間:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ChgScr(new UC.Main_Login(), "登入");
        }
    }
}
