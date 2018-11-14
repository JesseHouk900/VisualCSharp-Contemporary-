/*  Jesse Houk      Program 7       Graphics        Dr. Stringfellow
 * 
 *  Purpose: Draw a scene using graphics of at least 640x480 drawing at least
 *      one ellipse, one rectangle, and a string. OnPaint should also be
 *      overridden.
 *      
 *  Extra Credit: Flash, animate, start and stop animation button.
 *  
 *  DUE: WED., Nov 14
 *  
 */ 
using System.Windows.Forms;

namespace GraphicsProgram
{
    public partial class PictureForm : Form
    {
        public DrawingPanel drawing_panel;
        static public bool Running;
        public PictureForm()
        {
            InitializeComponent();
            // initialize the drawing panel
            MakeDrawingPanel();
            // force OnPaint to be called
            drawing_panel.Invalidate();
            // start the animation
            Running = true;
        }

        public void MakeDrawingPanel()
        {
            drawing_panel = new DrawingPanel();
            // make the drawing panel take up the whole form
            drawing_panel.Dock = DockStyle.Fill;
            

            this.Controls.Add(drawing_panel);
        }

        private void Game_Timer_Tick(object sender, System.EventArgs e)
        {
            // if running...
            if (Running)
            {
                // check the oranges previous location. if it is colliding with 
                    // the stick persons head...
                if (drawing_panel.OrangeCollide)
                {
                    // turn off the animation
                    Running = false;
                }
                // redraw
                drawing_panel.Invalidate();

            }
            else
            {

            }
        }
    }
}