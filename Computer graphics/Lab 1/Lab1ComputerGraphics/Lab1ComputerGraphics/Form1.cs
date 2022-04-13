using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1ComputerGraphics
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap pixelbmp, bmp;
        delegate void PixelFun(int x, int y, Color c);

        public int x1, x2, y1, y2;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pixelbmp = new Bitmap(1, 1);
            pictureBox1.Image = bmp;
            g = pictureBox1.CreateGraphics();
        }

        public void DefaultMethod()
        {
            x1 = int.Parse(first_x.Text); y1 = int.Parse(first_y.Text); x2 = int.Parse(second_x.Text); y2 = int.Parse(second_y.Text);

            Pen p = new Pen(Color.Black);
            g.DrawLine(p, new Point(x1, y1), new Point(x2, y2));
        }

        private void CDAMethod()
        {
            x1 = int.Parse(first_x.Text) + 50; y1 = int.Parse(first_y.Text) + 50; x2 = int.Parse(second_x.Text) + 50; y2 = int.Parse(second_y.Text) + 50;

            int dx = x2 - x1, dy = y2 - y1, steps, k, xf, yf;

            float xIncrement, yIncrement, x = x1, y = y1;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }

            else
            {
                steps = Math.Abs(dy);
            }

            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;
            PixelFun func = new PixelFun(SetPixel);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                xf = (int)x;
                y += yIncrement;
                yf = (int)y;
                try
                {
                    pictureBox1?.Invoke(func, xf, yf, Color.Blue);
                }
                catch (InvalidOperationException) { return; }
            }
        }

        public void BresenhemMethod()
        {
            x1 = int.Parse(first_x.Text) + 100; y1 = int.Parse(first_y.Text) + 100; x2 = int.Parse(second_x.Text) + 100; y2 = int.Parse(second_y.Text) + 100;

            int widht = x2 - x1, hight = y2 - y1;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (widht < 0)
            {
                dx1 = -1;
                dx2 = -1;
            }
            else if (widht > 0)
            {
                dx1 = 1;
                dx2 = 1;
            }

            if (hight < 0)
            {
                dy1 = -1;
            }
            else if (hight > 0)
            {
                dy1 = 1;
            }

            int longest = Math.Abs(widht);
            int shortest = Math.Abs(hight);

            if (!(longest > shortest))
            {
                longest = Math.Abs(hight);
                shortest = Math.Abs(widht);
                if (hight < 0)
                {
                    dy2 = -1;
                }
                else if (hight > 0)
                {
                    dy2 = 1;

                }
                dx2 = 0;
            }

            int numerator = longest >> 1;

            for (int i = 0; i <= longest; i++)
            {
                SetPixel(x1, y1, Color.Red);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x1 += dx1;
                    y1 += dy1;
                }
                else
                {
                    x1 += dx2;
                    y1 += dy2;
                }
            }
        }



        private void SetPixel(int x, int y, Color c)
        {
            pixelbmp.SetPixel(0, 0, c);
            g.DrawImageUnscaled(pixelbmp, x, y);

            try
            {
                bmp.SetPixel(x, y, c);
            }
            catch (ArgumentOutOfRangeException) { return; }
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(first_x.Text) == true || string.IsNullOrEmpty(first_y.Text) || string.IsNullOrEmpty(second_x.Text) || string.IsNullOrEmpty(second_y.Text))
            {
                MessageBox.Show("You did not enter the coordinates!");
            }

            else
            {
                var stopwatchTimer1 = new Stopwatch();
                stopwatchTimer1.Start();
                DefaultMethod();
                stopwatchTimer1.Stop();
                default_algorithm.Text = stopwatchTimer1.ElapsedMilliseconds.ToString();

                var stopwatchTimer2 = new Stopwatch();
                stopwatchTimer2.Start();
                BresenhemMethod();
                stopwatchTimer2.Stop();
                Bresenhems.Text = stopwatchTimer2.ElapsedMilliseconds.ToString();

                var stopwatchTimer3 = new Stopwatch();
                stopwatchTimer3.Start();
                CDAMethod();
                stopwatchTimer3.Stop();
                CDAs.Text = stopwatchTimer3.ElapsedMilliseconds.ToString();


            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            first_x.Text = null;
            first_y.Text = null;
            second_x.Text = null;
            second_y.Text = null;
            default_algorithm.Text = null;
            Bresenhems.Text = null;
            CDAs.Text = null;
        }
    }
}
