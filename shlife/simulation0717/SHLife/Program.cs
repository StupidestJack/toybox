using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife
{
    internal static class Program
    {
        public static MainForm M;
        public static Account A;
        public static Dictionary<string, string[]> w = new Dictionary<string, string[]> {
            {"广告", Properties.Resources.广告.Split('\n') },
            {"政治类", Properties.Resources.政治类.Split('\n') },
            {"涉枪涉爆", Properties.Resources.涉枪涉爆.Split('\n') },
            {"网址", Properties.Resources.网址.Split('\n') },
            {"色情类", Properties.Resources.色情类.Split('\n') }
        };

        /// <summary>
        /// I don't care anything, it works on my device.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            M = new MainForm();
            new AdminForm().Show();
            Application.Run(M);
        }
    }
}
