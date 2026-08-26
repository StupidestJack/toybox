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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            timelbl.Text = "系統時間：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void login_Click(object sender, EventArgs e)
        {
            using (var d = new Entity())
            {
                var user = d.Accounts.FirstOrDefault(x => x.Email == accTb.Text && x.Password == pwtb.Text);
                if (user == null)
                    stderr.Text = "帳號或密碼錯誤";
                else if (user.LockDateTime.HasValue && user.LockReason != "")
                    stderr.Text = "帳號已被鎖定且無法登入";
                else
                {
                    this.Hide();
                    if (new Chat { account = user }.ShowDialog() != DialogResult.OK){
                        this.Close();
                        return;
                    }
                    
                    this.Show();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = "系統時間：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
