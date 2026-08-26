using System.Runtime.CompilerServices;

namespace CookieUI
{
    internal static class Program
    {
        public static Size ScreenSize = Screen.PrimaryScreen?.Bounds.Size ?? new Size(800, 600);
        public static readonly Point Point00 = new Point(0, 0);
        public static List<BaseApp> Sessions = new List<BaseApp>();
        public static Taskbar Taskbar;
        public static List<(string Name, Image Icon, Func<BaseApp> Create)>
            Apps = new List<(string Name, Image Icon, Func<BaseApp> Create)> {
                ("測試應用程式", Properties.Resources.Default, () => new ExampleApp()),
                ("記事本", Properties.Resources.Write, () => new Notepad()),
                ("檔案總管", Properties.Resources.FileMgr, () => new FileManager()),
            };
        public static Font DefaultFont = new Font("Microsoft JhengHei UI", 9);
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists("Documents")) Directory.CreateDirectory("Documents");

            Taskbar = new Taskbar();
            Application.Run(Taskbar);
        }
    }
    internal static class ColorManager
    {

    }
}