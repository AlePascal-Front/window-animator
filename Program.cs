namespace WindowAnimator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var App = new MainWindow();
            App.Init();
        }
    }
}