using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace ChildShell
{
    public partial class Browser : Form
    {
        public WebView2 webView;

        public Browser(string _url = "https://www.bing.com")
        {
            InitializeComponent();
            url = _url;
        }
        string url = "";
        private async void Browser_Load(object sender, EventArgs e)
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            groupBox1.Controls.Add(webView);

            // 開始初始化
            await webView.EnsureCoreWebView2Async(null);

            webView.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
            webView.CoreWebView2.Navigate(url);
        }

        // 初始化完成後要執行的事件
        private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                textBox1.Text = webView.Source.ToString();
            }         
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();
            string[] blocked_url = new string[]{
                "pornhub.com",
                "onlyfans.com",
                "tiktok.com",
                "threads.com"
            };
            foreach (string url in blocked_url)
            {
                if (input.Contains(url))
                {
                    MessageBox.Show("此網站已被封鎖。", "封鎖網站", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    return;
                    //差點把textBox1.Text = webView.Source.ToString();塞在return下面
                }
            }

            if (Uri.TryCreate(input, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                webView.CoreWebView2.Navigate(input);
            }
            else
            {
                webView.CoreWebView2.Navigate("https://www.bing.com/search?q=" + Uri.EscapeDataString(input));
            }
        }
    }
}
