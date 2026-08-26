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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label9.Text = "兒童機系統 ver." + Program.shellversion + "." + Program.shellbuild.ToString() + " (" + Program.progress + ")";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winver.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] versioninfos = new string[] {
                "兒童機系統 ChildShell",
                "(C) 2025 JackUwU, Protected by GPLv3.\r\nPowered by C#, .NET Framwork and WinForms",
                "本專案「兒童機系統」創意來自 JackUwU (薛豆子UwU) ，\r\n任何人可以針對此系統進行二次創作，\r\n但請勿在未經授權形況下，以更新兒童機系統之名義發布二次創作。",
                "此專案僅供娛樂，日常使用建議不要使用此軟體。",
                "版本 " + Program.shellversion + "." + Program.shellbuild.ToString() + " (" + Program.progress + ")",
            };
            MessageBox.Show(string.Join("\r\n", versioninfos), "關於 兒童機系統", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
