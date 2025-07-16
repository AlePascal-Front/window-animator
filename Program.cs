namespace WindowAnimator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var app = new MainWindow();
            app.Init();
        }
    }
}