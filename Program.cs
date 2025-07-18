using System.Runtime.InteropServices;

namespace WindowAnimator
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AllocConsole();
            var app = new Home();
            app.Init();
        }
    }
}