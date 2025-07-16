using System.ComponentModel;
// using System.Windows.Forms;
// using System.Drawing;

namespace WindowAnimator
{
    // read that when using partial you should always keep the same access modifier throughout
    public partial class MainWindow : Form
    {
        // tells compiler that this variable is nullable
        public IContainer? components = null;

        public void InitializeComponent()
        {
            int width = 800, height = 450;

            // from object components we get a bunch of properties to read and write to
            components = new Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(width, height);
            Text = "WindowAnimator - Main Window";
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Init()
        {
            // Sets up styles
            InitializeComponent();

            // This line initializes canvas
            Application.Run(this);
        }
    }
}
