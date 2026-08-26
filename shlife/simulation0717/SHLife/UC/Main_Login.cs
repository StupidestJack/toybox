using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife.UC
{
    public partial class Main_Login : UserControl
    {
        public Main_Login()
        {
            InitializeComponent();
        }

        private void exitbtm_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            using (var db = new Entity())
            {
                var a = db.Accounts.FirstOrDefault(x => x.Email == accTb.Text && x.Password == passTb.Text);
                if (a == null)
                    stderr.Text = "帳號或密碼錯誤";
                else if (a.LockDateTime.HasValue)
                    stderr.Text = "帳號已被鎖定且無法登入";
                else
                {
                    Program.A = a;
                    Program.M.ChgScr(new Main_Chat(), "聊天室");
                }
            }
        }
    }
}
