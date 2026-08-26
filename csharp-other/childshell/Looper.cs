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
    public partial class Looper : Form
    {
        public Looper()
        {
            //在非debug模式下隱藏視窗
            //這樣使用者就看不到這個form了
            if (Program.progress == "Release")
            {
                this.Opacity = 0;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            InitializeComponent();
        }

        private void Looper_Load(object sender, EventArgs e)
        {
            new Lock().Show();
            //接下來交給lock
        }
    }
}
