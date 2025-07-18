using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;
// using System.Windows.Forms;
// using System.Drawing;

namespace WindowAnimator
{
    // read that when using partial you should always keep the same access modifier throughout
    public partial class Home : Form
    {
        // tells compiler that this variable is nullable
        public IContainer? components = null;

        // readonly acts as a constant
        // static keyword lets us referentiate fields
        // without creating an instance
        public static readonly int width = 720;
        public static readonly int height = 720;


        // creating dict that will have future user options.
        // for now, let it only have key "fontSize" and value "12"
        public Dictionary<string, string> options =
            new Dictionary<string, string>();

        // set dummy size for later adjustment depending on the context
        public static Font font = new Font("Segoe UI", 0.40f);
        public void InitializeComponent()
        {
            // from object components we get a bunch of properties to read and write to
            components = new Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(width, height);
            Text = "Window Animator - Home";
            StartPosition = FormStartPosition.CenterScreen;

            /* responsive design should come later */
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        public static void SetBaseFont(float size, string style = "")
        {
            string lowerCaseStyleFlag = style.ToLower();
            switch (lowerCaseStyleFlag)
            {
                case "bold":
                    font = new Font("Segoe UI", size, FontStyle.Bold);
                    break;
                case "italic":
                    font = new Font("Segoe UI", size, FontStyle.Italic);
                    break;
                case "regular":
                    font = new Font("Segoe UI", size, FontStyle.Regular);
                    break;
                default:
                    font = new Font("Segoe UI", size);
                    break;
            }
        }

        public void SetDefaultsOptions() {
            options.Add("fontSize", "3");

            // reminder to add more defaults such as 
            // "animation on closure" and its value
            // "animation on open" and its value
        }

        public void DrawRoundedBorder(Panel p, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath
        } 

        public void RenderTitleLabel()
        {
            float bigSize = 20.0f;

            try
            {
                SetBaseFont(int.Parse(options["fontSize"]));
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{options["fontSize"]}");
            }

            SetBaseFont(bigSize, "bold");

            // debug line
            if (font.Bold)
            {
                Console.WriteLine("The font is bold. Everything is okay.");
            }
            else
            {
                Console.WriteLine("The font is not bold. Something went wrong.");
            }

            var titleLayout = new
            {
                titlePanel = new Panel(),
                panelMargin = 20,

                titleLabel = new Label(),
                labelHeight = 50,
                labelText = "Welcome to Window Animator",
                textColor = Color.Black,

                backgroundColor = Color.White,
            };

            Panel titlePnl = titleLayout.titlePanel;

            titlePnl.BorderStyle = BorderStyle.FixedSingle;
            titlePnl.AutoSize = false;
            titlePnl.BackColor = Color.White;
            titlePnl.Width = width - 2 * titleLayout.panelMargin;
            titlePnl.Location = new Point(titleLayout.panelMargin, titleLayout.panelMargin);

            Label titleLbl = titleLayout.titleLabel;

            titleLbl.Text = titleLayout.labelText;
            titleLbl.ForeColor = titleLayout.textColor;
            titleLbl.Font = font;
            titleLbl.AutoSize = false;
            titleLbl.Width = titlePnl.Width;
            titleLbl.Height = titlePnl.Height;
            titleLbl.Location = new Point(0, 0);
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;

            // int horizontalCenter = width / 2;
            // titleLabel.Location = new Point(horizontalCenter, (height * 0) + 30);

            int diff = 0;
            // while (titleLabel. >= horizontalCenter)
            // {
            //     Console.WriteLine($"offset's value is now {offset}");
            //     titleLabel.Location.Offset(offset, 0);
            // }

            Controls.Add(titlePnl);
            titlePnl.Controls.Add(titleLbl);
        }

        public void Init()
        {
            InitializeComponent();
            SetDefaultsOptions();
            RenderTitleLabel();   
            Application.Run(this);
        }
    }
}
