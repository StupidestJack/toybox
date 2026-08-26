using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 以後所有通用內容的基底都放這
// 然後用抽象類別來實作

namespace CookieUI
{
    // 讓每個App都繼承這個BaseApp，裡面有一些通用的UI元素和功能
    // 這樣以後要改一些通用的UI元素或功能的話就只要改這裡就好，不用每個App都改一次
    // 這樣也可以確保每個App的UI風格和操作邏輯都一致，讓整個系統看起來更統一
    // 比如說每個App都有一個標題列，裡面有App的名稱和圖示，還有一個關閉按鈕，這些都可以在BaseApp裡面實作好，
    // 然後每個App繼承BaseApp就自動有了這些功能，不用每個App都寫一次

    // 淦我真的覺得IntelliCode有讀心術
    public abstract class BaseApp : Form
    {
        public string AppName { get; set; }
        public Bitmap AppIcon { get; set; }
        public Size DefaultSize { get; set; } = new Size(400, 300);
        public Point DefaultLocation { get; set; }
        public Panel titleBar { get; set; }
        public Panel mainPanel { get; set; }
        public WinStatus Status { get; set; } = WinStatus.Normal;
        public Label titleLbl { get; set; }
        public PictureBox iconPb { get; set; }
        public Button tbarBtn { get; set; }


        public abstract Tuple<string, Bitmap> DefaultInfo { get; }

        private bool isResizing = false;
        private const int GripSize = 10; // 偵測縮放的邊緣寬度
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        // 0 ~ 8分別為: 
        // 無、左上、上、右上、右、右下、下、左下、左
        private int resizeDirection = 0; 
        private Cursor[] resizeCursors = new Cursor[] {
            Cursors.Arrow, // 無
            Cursors.SizeNWSE, // 左上
            Cursors.SizeNS, // 上
            Cursors.SizeNESW, // 右上
            Cursors.SizeWE, // 右
            Cursors.SizeNWSE, // 右下
            Cursors.SizeNS, // 下
            Cursors.SizeNESW, // 左下
            Cursors.SizeWE // 左
        };
        protected void Initialize()
        {
            this.Size = DefaultSize;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = Program.DefaultFont;
            this.Padding = new Padding(5, 35, 5, 5);
            this.BackColor = Color.FromArgb(70, 70, 70);

            AppName = DefaultInfo.Item1;
            AppIcon = DefaultInfo.Item2;

            tbarBtn = new Button
            {
                BackgroundImage = (Image)AppIcon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(40, 40),
                Margin = new Padding(2, 0, 2, 0),
                FlatStyle = FlatStyle.Flat,
            };
            // 其實這樣會導致史山代碼，因為最小化邏輯重複
            // 但我懶得管了，就這樣吧
            tbarBtn.Click += (s, e) => {
                if (Status == WinStatus.Minimized || Status == WinStatus.MinimizedWhenMaximized)
                {
                    this.Show();
                    if (Status == WinStatus.Minimized) Status = WinStatus.Normal;
                    else if (Status == WinStatus.MinimizedWhenMaximized) Status = WinStatus.Maximized;
                }
                else if (!this.Focused) this.Focus();
                else
                {
                    if (Status == WinStatus.Normal)
                    {
                        Status = WinStatus.Minimized;
                        this.Hide();
                    }
                    else if (Status == WinStatus.Maximized)
                    {
                        Status = WinStatus.MinimizedWhenMaximized;
                        this.Hide();
                    }
                }
            };

            // 不用計算間距了真是太棒了
            // 這讓我想起了Python Tkinter的那個side
            // 我以前寫ShellyOS (也是WinPE桌面) 的時候就是用的side
            Program.Taskbar.AppButtonsPanel.Controls.Add(tbarBtn);

            titleBar = new Panel
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                Size = new Size(this.Width - 10, 30),
                Location = new Point(5, 5),
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White,
            };
            
            titleLbl = new Label
            {
                Text = AppName,
                Location = new Point(30, 5),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
            };
            iconPb = new PictureBox
            {
                BackgroundImage = AppIcon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(20, 20),
                Location = new Point(5, 5)
            };

            // 好了這個先不用了，除非等下又炸
            // iconPb.DoubleClick += (s, e) => this.Close(); 

            var closeBtn = new Button
            {
                Text = "×",
                Location = new Point(titleBar.Width - 45, 0),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
            };
            var maxBtn = new Button
            {
                Text = "□",
                Location = new Point(titleBar.Width - 75, 0),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
            };
            var minBtn = new Button
            {
                Text = "–",
                Location = new Point(titleBar.Width - 105, 0),
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
            };

            closeBtn.Click += (s, e) => this.Close();
            maxBtn.Click += (s, e) =>
            {
                if (Status == WinStatus.Maximized)
                {
                    this.Size = DefaultSize;
                    this.Location = DefaultLocation;
                    Status = WinStatus.Normal;
                    maxBtn.Text = "□";
                }
                else
                {
                    Status = WinStatus.Maximized;
                    // 以後應該會做更改大小，但是不知道啥時候，以後再說吧awa
                    DefaultSize = this.Size;
                    DefaultLocation = this.Location;
                    this.Size = new Size(Program.ScreenSize.Width, Program.ScreenSize.Height - 40);
                    this.Location = Program.Point00;
                    maxBtn.Text = "❐";
                }
            };
            // 等等去實作工作列按鈕
            minBtn.Click += (s, e) => {
                if (Status == WinStatus.Normal) {
                    Status = WinStatus.Minimized;
                    this.Hide(); 
                }
                else if (Status == WinStatus.Maximized) {
                    Status = WinStatus.MinimizedWhenMaximized;
                    this.Hide();
                }
            };

            titleBar.Controls.Add(minBtn);
            titleBar.Controls.Add(maxBtn);
            titleBar.Controls.Add(closeBtn);

            titleBar.Controls.Add(titleLbl);
            titleBar.Controls.Add(iconPb);

            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, titleBar.Height),
                Size = new Size(this.Width, this.Height - titleBar.Height),
                BackColor = Color.FromArgb(240, 240, 240)
            };
            this.Controls.Add(titleBar);
            this.Controls.Add(mainPanel); 

            titleBar.MouseDown += StartMove;
            titleBar.MouseUp += StopMove;
            titleBar.MouseMove += Moving;

            titleLbl.MouseDown += StartMove;
            titleLbl.MouseUp += StopMove;
            titleLbl.MouseMove += Moving;

            iconPb.MouseDown += StartMove;
            iconPb.MouseUp += StopMove;
            iconPb.MouseMove += Moving;

            this.Deactivate += (s, e) => {
                titleBar.BackColor = Color.FromArgb(80, 80, 80);
                tbarBtn.BackColor = Color.FromArgb(80, 80, 80);
            };

            this.Activated += (s, e) => {
                titleBar.BackColor = Color.FromArgb(50, 50, 50);
                tbarBtn.BackColor = Color.FromArgb(50, 50, 50);
            };
            this.FormClosing += (s, e) => {
                Program.Taskbar.AppButtonsPanel.Controls.Remove(tbarBtn);
                Program.Sessions.Remove(this);
            };

            // 在 Base.cs 的 Initialize() 裡面加入
            this.MouseDown += StartResize;
            this.MouseUp += (s, e) => isResizing = false;
            this.MouseMove += CheckResize;
            this.MouseMove += Resizing;
        }
        protected void Resizing(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                var ob = this.Bounds;
                switch (resizeDirection)
                {
                    case 1: // 左上
                        this.Bounds = new Rectangle(
                            Cursor.Position.X, 
                            Cursor.Position.Y, 
                            ob.Right - Cursor.Position.X, 
                            ob.Bottom - Cursor.Position.Y
                            ); 
                        break;
                    case 2: 
                        this.Bounds = new Rectangle(
                            this.Left,
                            Cursor.Position.Y,
                            ob.Right - this.Left,
                            ob.Bottom - Cursor.Position.Y
                            ); 
                        break;
                    case 3:
                        this.Bounds = new Rectangle(
                            this.Left,
                            Cursor.Position.Y,
                            Cursor.Position.X - ob.Left, 
                            ob.Bottom - Cursor.Position.Y
                            );
                        break;
                    case 4:
                        this.Bounds = new Rectangle(
                            this.Left,
                            this.Top,
                            Cursor.Position.X - ob.Left,
                            this.Size.Height
                            );
                        break;
                    case 5:
                        this.Bounds = new Rectangle(
                            this.Left,
                            this.Top,
                            Cursor.Position.X - ob.Left,
                            Cursor.Position.Y - ob.Top
                            );
                        break;
                    case 6:
                        this.Bounds = new Rectangle(
                            this.Left,
                            this.Top,
                            this.Size.Width,
                            Cursor.Position.Y - ob.Top
                            );
                        break;
                    case 7:
                        this.Bounds = new Rectangle(
                            Cursor.Position.X,
                            this.Top,
                            ob.Right - Cursor.Position.X,
                            Cursor.Position.Y - ob.Top
                            );
                        break;
                    case 8:
                        this.Bounds = new Rectangle(
                            Cursor.Position.X,
                            this.Top,
                            ob.Right - Cursor.Position.X,
                            this.Size.Height
                            );
                        break;
                }

                // 記得同步更新你代碼中的 DefaultSize，不然按下最大化還原後會跑掉
                this.DefaultLocation = this.Location;
                this.DefaultSize = this.Size;
            }
        }
        protected void StartResize (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && resizeDirection != 0)
            {
                isResizing = true;
            }
        }
        protected void CheckResize (object sender, MouseEventArgs e)
        {
            // 0 ~ 8分別為: 
            // 無、左上、上、右上、右、右下、下、左下、左
            if (e.X <= GripSize && e.Y <= GripSize)
                resizeDirection = 1; // 左上  
            else if (e.X > GripSize && e.X < this.Width - GripSize && e.Y <= GripSize)
                resizeDirection = 2; // 上
            else if (e.X >= this.Width - GripSize && e.Y <= GripSize)
                resizeDirection = 3; // 右上
            else if (e.X >= this.Width - GripSize && e.Y > GripSize && e.Y < this.Height - GripSize)
                resizeDirection = 4; // 右
            else if (e.X >= this.Width - GripSize && e.Y >= this.Height - GripSize)
                resizeDirection = 5; // 右下
            else if (e.X > GripSize && e.X < this.Width - GripSize && e.Y >= this.Height - GripSize)
                resizeDirection = 6; // 下
            else if (e.X <= GripSize && e.Y >= this.Height - GripSize)
                resizeDirection = 7; // 左下
            else if (e.X <= GripSize && e.Y > GripSize && e.Y < this.Height - GripSize)
                resizeDirection = 8; // 左
            else
                resizeDirection = 0; // 無
            Cursor = resizeCursors[resizeDirection];
        }   

        protected void StartMove (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }
        protected void StopMove (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        protected void Moving (object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }


        abstract public void LoadContent();
    }
    public enum WinStatus
    {
        Normal,
        Minimized,
        Maximized,
        MinimizedWhenMaximized,
    }


    public class ExampleApp : BaseApp
    {
        public override Tuple<string, Bitmap> DefaultInfo => new Tuple<string, Bitmap>("Example App", Properties.Resources.Default);
        public ExampleApp()
        {
            Initialize();
            LoadContent();
        }
        public override void LoadContent()
        {
            var contentLbl = new Label
            {
                Text = "This is an example app.",
                ForeColor = Color.Black,
                Location = new Point(40, 40),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                AutoSize = true
            };
            mainPanel.Controls.Add(contentLbl);
        }
    }
}
