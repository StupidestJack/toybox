using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YouAreAnIdiot
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>

        public static int formCount = 0;
        public static Rectangle bounds = Screen.PrimaryScreen.Bounds;
        public static bool close = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new looper());
        }
    }
}
