using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CookieUI
{
    public class Desktop : Form
    {
        public Desktop()
        {
            this.Size = Program.ScreenSize;
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.DarkBlue;
            this.Activated += (s, e) => SendToBack();
            this.FormClosing += (s, e) =>
            {
                // 以後會改成關機選項，現在先暫時這樣
                e.Cancel = true;
            };
        }
    }
    public class StartMenu : Form
    {
        public StartMenu()
        {
            this.Size = new Size(200, 400);
            this.Location = new Point(0, Program.ScreenSize.Height - this.Height - 40);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.Deactivate += async (s, e) =>
            {
                await Task.Delay(100); // 以防再按一次Start時導致關閉，反正幾乎看不出來awa
                this.Hide();
            };

            var user = new Panel
            {
                Size = new Size(this.Width, 40),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(50, 50, 50)
            };
            var userPicPb = new PictureBox
            {
                BackgroundImage = Properties.Resources.Cat,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(30, 30),
                Location = new Point(5, 5)
            };
            var userNameLbl = new Label
            {
                Text = "User",
                ForeColor = Color.White,
                Location = new Point(40, 10),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
            };
            userPicPb.Click += UserAreaClick;
            userNameLbl.Click += UserAreaClick;
            user.Click += UserAreaClick;

            user.Controls.Add(userPicPb);
            user.Controls.Add(userNameLbl);
            this.Controls.Add(user);

            for (var i = 0; i < Program.Apps.Count; i++)
            {
                var app = Program.Apps[i];
                var appPanel = new Panel
                {
                    Size = new Size(this.Width, 20),
                    Location = new Point(0, 20 * (i + 2)),
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                var appIconPb = new PictureBox
                {
                    BackgroundImage = app.Icon,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Size = new Size(20, 20),
                    Location = new Point(5, 0)
                };
                var appNameLbl = new Label
                {
                    Text = app.Name,
                    ForeColor = Color.White,
                    Location = new Point(30, 0),
                    Font = new Font("Microsoft JhengHei UI", 10, FontStyle.Regular),
                };

                appPanel.Click += (s, e) =>
                {
                    var instance = app.Create();
                    Program.Sessions.Add(instance);
                    instance.Show();
                    this.Hide();
                };
                appNameLbl.Click += (s, e) =>
                {
                    var instance = app.Create();
                    Program.Sessions.Add(instance);
                    instance.Show();
                    this.Hide();
                };
                appIconPb.Click += (s, e) =>
                {
                    var instance = app.Create();
                    Program.Sessions.Add(instance);
                    instance.Show();
                    this.Hide();
                };

                this.Controls.Add(appPanel);
                appPanel.Controls.Add(appNameLbl);
                appPanel.Controls.Add(appIconPb);
            }
        }
        // wpeutil shutdown在PE裡是安全的關機方式
        // 但在正常系統裡會導致exception，所以就放在try裡面，萬一失敗了就直接結束程序
        Dictionary<string, Func<Task>> userMenuAction = new Dictionary<string, Func<Task>> {
            {"關機", async () => { try { Process.Start("wpeutil", "shutdown");} catch {Environment.Exit(0);}}},
            {"重啟", async () => { try { Process.Start("wpeutil", "reboot");} catch {Environment.Exit(0);}}},
        };
        private void UserAreaClick(object sender, EventArgs e)
        {
            var menu = new ContextMenuStrip
            {
                BackColor = Color.FromArgb(45, 45, 45),
                ForeColor = Color.White,
                ShowImageMargin = false
            };
            foreach (var action in userMenuAction)
            {
                menu.Items.Add(new ToolStripMenuItem(action.Key, null, (s, e) => action.Value()));
            }
            menu.Show(this, new Point(0, 40));
        }
    }
    public class Taskbar : Form
    {
        StartMenu menu = new StartMenu();
        public FlowLayoutPanel AppButtonsPanel;
        public Taskbar()
        {
            // 已放棄AppBar API，之後用私有唄awa
            this.Size = new Size(Program.ScreenSize.Width, 40);
            this.Location = new Point(0, Program.ScreenSize.Height - 40);
            this.BackColor = Color.FromArgb(45, 45, 45);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.White;
            this.FormClosing += (s, e) =>
            {
                // 以後會改成關機選項，現在先暫時這樣
                e.Cancel = true;
            };

            AppButtonsPanel = new FlowLayoutPanel
            {
                Location = new Point(45, 0), // 避開左邊的開始按鈕
                Size = new Size(this.Width - 130, 40), // 留空間給右邊的時鐘
                BackColor = Color.Transparent,
                FlowDirection = FlowDirection.LeftToRight, // 由左往右排
                WrapContents = false, // 不要自動換行
                AutoScroll = false    // 如果按鈕太多可以改成 true 變成可滾動
            };
            this.Controls.Add(AppButtonsPanel);

            // 開始按鈕
            var startBtn = new PictureBox
            {
                BackgroundImage = Properties.Resources.Cookie,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.FromArgb(70, 70, 70),
                Location = new Point(0, 0),
                Size = new Size(40, 40),
                Anchor = AnchorStyles.Left | AnchorStyles.Top,
            };
            startBtn.MouseDown += (s, e) =>
            {
                if (menu.Visible)
                    menu.Hide();
                else
                    menu.Show();
            };
            this.Controls.Add(startBtn);

            // 時鐘
            var clockLbl = new Label
            {
                Text = "00:00",
                Location = new Point(this.Width - 80, 5),
                Size = new Size(70, 30),
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };
            this.Controls.Add(clockLbl);
            var loop = new System.Windows.Forms.Timer { Interval = 100 };
            loop.Tick += (s, e) =>
            {
                clockLbl.Text = DateTime.Now.ToString("HH:mm");
                foreach (var session in Program.Sessions)
                {
                    if (session.AppName != session.titleLbl.Text)
                        session.titleLbl.Text = session.AppName;
                    if (session.AppIcon != session.iconPb.BackgroundImage)
                        session.iconPb.BackgroundImage = session.AppIcon;
                    if (session.AppIcon != session.tbarBtn.BackgroundImage)
                        session.tbarBtn.BackgroundImage = session.AppIcon;
                }
            };
            loop.Start();

            new Desktop().Show();
        }
    }
}
