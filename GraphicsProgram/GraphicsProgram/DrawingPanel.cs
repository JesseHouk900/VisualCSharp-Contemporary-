/*  Jesse Houk      Program 7       Graphics        Dr. Stringfellow
 * 
 *  Purpose: Make a new class inheriting from Panel that has an overridden
 *      OnPaint method
 *      
 *  DUE: WED., Nov 14
 *  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsProgram
{
    public class DrawingPanel : Panel
    {
        // used to redraw the orange
        private int orangeX;
        private int orangeY;
        public bool OrangeCollide
        {
            get
            {
                // if the bottom of the orange hits the stick figures head...
                if (orangeY + 15 > ((7 / 11.0) * Size.Height) - 35 + 
                    (35 / 3.0) - 20)
                    return true;
                // else
                return false;
            }
        }
        // default constructor calls the base (Panel) constructor
        public DrawingPanel() : base()
        {
            // give dummy values to the oranges location
            orangeX = -1;
            orangeY = -1;
            // prevent some flickering from occuring when redrawing
            this.DoubleBuffered = true;
        }
        // The overridden OnPaint method draws onto the screen a picture
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // check if the animation should still be running
            if (PictureForm.Running)
            {
                DrawScene(g);
                UpdateOrangeLocation(g);
            }
            else
            {
                Blackout(g);
            }
        }

        public void DrawScene(Graphics g)
        {
            // declare a brush object to be passed through functions and used 
            // for coloing
            Brush brush = new SolidBrush(Color.Black);
            // draw text
            g.DrawString("Relax and stay a while", new
                System.Drawing.Font("Times New Roman", 32), brush, 50, 50);
            // get the waterfall x offset, that is, 1 / 2 of the waterfall width
            int waterfallXOffset = (int)(Size.Width * (1 / 5.0));
            // get the center of the waterfall x
            int waterfallXCenter = (int)(Size.Width * (1 / 2.0));
            int groundY = (int)((7 / 11.0) * Size.Height);
            // draw tree
            DrawTree(g, brush, waterfallXCenter + waterfallXOffset + 25,
                (int)(groundY * (1 / 17.0)), (int)(Size.Width * (23 / 24.0)),
                groundY, 13);
            // draw bridge
            DrawBridge(g, brush, waterfallXCenter, waterfallXOffset, groundY);
            // get a brush that is the color of the ground
            brush = new SolidBrush(Color.SaddleBrown);
            // Draw the ground
            g.FillRectangle(brush, Location.X, groundY, Size.Width,
                Size.Height - groundY);
            // get a brush that is the color of the waterfall stream
            brush = new HatchBrush(HatchStyle.Wave, Color.MintCream, Color.Aqua);
            // draw the waterfall
            g.FillRectangle(brush, waterfallXCenter - waterfallXOffset, groundY - 3,
                2 * waterfallXOffset, Size.Height + 3 - groundY);
            // make a pen for the stick figure
            Pen p = new Pen(Color.Black, 2);
            // draw person laying against tree
            DrawStickFigure(g, p, waterfallXCenter + waterfallXOffset + 65,
                groundY - 35, waterfallXCenter + waterfallXOffset + 65 + 85,
                groundY);


        }
        protected void DrawStickFigure(Graphics g, Pen p, int xOrig, int yOrig,
                                                          int xMax, int yMax)
        {
            // draw lower left leg segment (0, yMax - 10), (20, yMax - 20)
            g.DrawLine(p, xOrig, yMax - 10, xOrig + 20, yMax - 20);
            // draw lower right leg segment (3, yMax), (23, yMax - 10)
            g.DrawLine(p, xOrig + 3, yMax, xOrig + 23, yMax - 10);
            // draw upper left leg segment (20, yMax - 20), (40, yMax - 5)
            g.DrawLine(p, xOrig + 20, yMax - 20, xOrig + 40, yMax - 5);
            // draw upper right leg segment (23, yMax - 10), (40, yMax - 5)
            g.DrawLine(p, xOrig + 23, yMax - 10, xOrig + 40, yMax - 5);
            // draw torso segment (40, yMax - 5), (xMax - 20, yMax / 3.0)
            g.DrawLine(p, xOrig + 40, yMax - 5, xMax - 20, yOrig + 
                (int)((yMax - yOrig) / 3.0));
            // draw head circle ((xMax - 19, (yMax / 3.0) - 5), 20)
            g.DrawEllipse(p, xMax - 29, yOrig + (int)((yMax - yOrig) / 3.0) - 20,
                20, 20);
            // draw upper left arm segment (xMax - 20, yMax / 3.0), 
            //(xMax - 10, (yMax / 3.0) - 3)
            g.DrawLine(p, xMax - 20, yOrig + (int)((yMax - yOrig) / 3.0), 
                xMax - 6, yOrig + (int)((yMax - yOrig) / 3.0) + 2);
            // draw lower left arm segment (xMax - 10, (yMax / 3.0) - 3),
            // (xMax - 12, (yMax / 3.0) - 5)
            g.DrawLine(p, xMax - 6, yOrig + (int)((yMax - yOrig) / 3.0) + 2,
                xMax - 12, yOrig + (int)((yMax - yOrig) / 3.0) - 5);
        }
        // draw a tree on the explicitly stating the number of leaf bundles 
            //there will be growing out from the tree
        protected void DrawTree(Graphics g, Brush b, int xOrig, int yOrig, 
                                int xMax, int yMax, int numOutgrowths)
        {
            int smallR = 45, bigR = 75;
            // make a special brush for the tree trunk
            b = new HatchBrush(HatchStyle.Percent30, Color.Brown);
            // draw trunk
            g.FillRectangle(b, (int)((xOrig + xMax) / 2), yOrig + 
                ((yMax + yOrig) / 2), smallR, (yMax - yOrig) / 2);
            // make a normal brush for the tree hole
            b = new SolidBrush(Color.Black);
            // (optional) draw tree hole
            g.FillEllipse(b, (int)((xOrig + xMax) / 2) + 10, yOrig + 
                ((yMax + yOrig) / 2) + 50, smallR / 3, 3 * smallR / 5); 
            // make a brush for the leaves
            b = new HatchBrush(HatchStyle.Shingle, Color.Black, Color.SpringGreen);
            // draw leaf core
            g.FillEllipse(b, (int)((xOrig + xMax) / 2.0) - (int)((smallR + bigR) / 2),
                yOrig + (int)((yMax - yOrig) * 3 / 8.0) - (int)((smallR + bigR) / 2),
                2 * bigR, 2 * bigR);
            // for loop for the leaf outgrowths
            for (int i = 0, x, y; i < numOutgrowths; i++)
            {
                double t = i * 2.0 * Math.PI / (double)numOutgrowths;
                // calculate the x, y position of the new bundle of leaves using
                // law of sines. 
                x = (int)(bigR * Math.Cos(t));
                y = (int)(bigR * Math.Sin(t));
                // draw circle ((x, y), 35)
                g.FillEllipse(b, (int)((xOrig + xMax) / 2.0)
                    + x, yOrig + (int)((yMax - yOrig) * (3 / 8.0)) + y, smallR,
                    smallR);
            }
            // i forange has not had it's values set yet...
            if (orangeY == -1 && orangeX == -1)
            {
                // position the orange near the upper left corner of the trunk
                orangeX = ((xOrig + xMax) / 2) - 20;
                orangeY = yOrig + ((yMax + yOrig) / 2);
            }
        }

        // draw a bridge from 45 - the left side of the waterfall to 45 + the 
            //right side of the waterfall
        protected void DrawBridge(Graphics g, Brush b, int center,
                                  int halfWaterWidth, int bottom)
        {
            // get brush color
            b = new SolidBrush(Color.DarkRed);
            // draw left pillar
            g.FillRectangle(b, center - halfWaterWidth - 45, bottom - 125, 30,
                125);
            // draw right pillar
            g.FillRectangle(b, center + halfWaterWidth + 15, bottom - 125, 30,
                125);
            // draw bottom beam
            g.FillRectangle(b, center - halfWaterWidth - 15, bottom - 45,
                (2 * halfWaterWidth) + 30, 20);
            // draw top beam
            g.FillRectangle(b, center - halfWaterWidth - 15, bottom - 85, 
                (2 * halfWaterWidth) + 30, 20);
            // for loop to draw slits
            for (int i = 1; i <= 8; i++)
            {
                g.FillRectangle(b, i * (45) + center - halfWaterWidth, bottom - 65,
                    (2 * halfWaterWidth) / 32, 20);
            }
        }
        // onTick, update the orange location
        protected void UpdateOrangeLocation(Graphics g)
        {
            Brush b = new SolidBrush(Color.Orange);
            g.FillEllipse(b, orangeX, orangeY, 15, 15);
            orangeY += 3;
        }
        // draw method for when the person is hit on the head
        protected void Blackout(Graphics g)
        {
            // make a new brush to blackout the screen
            Brush b = new SolidBrush(Color.Black);
            // blackout tht screen
            g.FillRectangle(b, 0, 0, Size.Width, Size.Height);
            // change the color of the text to white
            b = new SolidBrush(Color.White);
            // draw a message
            g.DrawString("Ouch", new System.Drawing.Font("Times New Roman", 32),
                b, (Size.Width / 2) - 12, (Size.Height / 2) - 32);
        }
    }
}
