using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3ComputerGraphics
{
    public partial class Form1 : Form
    {
        public PointF a = new PointF();
        public PointF b = new PointF();
        public PointF c = new PointF();
        public PointF d = new PointF();

        public Form1()
        {
            InitializeComponent();
        }

        public void DrawTriangle()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            var stopwatch = new Stopwatch();

            float x1, x2;

            stopwatch.Start();

            for (float sy = a.Y; sy < c.Y; ++sy)
            {
                x1 = a.X + (sy - a.Y) * (c.X - a.X) / (c.Y - a.Y);

                if (sy < b.Y)
                {
                    x2 = a.X + (sy - a.Y) * (b.X - a.X) / (b.Y - a.Y);
                }
                else
                {
                    if (c.Y == b.Y)
                    {
                        x2 = b.X;
                    }
                    else
                    {
                        x2 = b.X + (sy - b.Y) * (c.X - b.X) / (c.Y - b.Y);
                    }

                }

                if (x1 > x2)
                {
                    float tmp = x1;
                    x1 = x2; x2 = tmp;
                }

                g.DrawLine(new Pen(Color.Red), x1, sy, x2, sy);
            }

            stopwatch.Stop();
            label16.Text = $"{stopwatch.Elapsed.TotalMilliseconds} seconds";

        }
        public void PointSearch()
        {
            d.X = Convert.ToInt64(textBox7.Text);
            d.Y = Convert.ToInt64(textBox8.Text);

            bool res = false;

            float a = (this.a.X - d.X) * (this.b.Y - this.a.Y) - (this.b.X - this.a.X) * (this.a.Y - d.Y);
            float b = (this.b.X - d.X) * (this.c.Y - this.b.Y) - (this.c.X - this.b.X) * (this.b.Y - d.Y);
            float c = (this.c.X - d.X) * (this.a.Y - this.c.Y) - (this.a.X - this.c.X) * (this.c.Y - d.Y);

            if ((a <= 0 && b <= 0 && c <= 0) || (a >= 0 && b >= 0 && c >= 0)) { res = true; }

            if (res == true) { MessageBox.Show("The point lies in the triangle"); }
            else { MessageBox.Show("The point does not lie in the triangle"); }
        }
        public void ReDrawTriangle(Color color)
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            float x1, x2;
            Pen pen = new Pen(color);

            for (float sy = a.Y; sy < c.Y; ++sy)
            {
                x1 = a.X + (sy - a.Y) * (c.X - a.X) / (c.Y - a.Y);

                if (sy < b.Y)
                {
                    x2 = a.X + (sy - a.Y) * (b.X - a.X) / (b.Y - a.Y);
                }
                else
                {
                    if (c.Y == b.Y)
                    {
                        x2 = b.X;
                    }
                    else
                    {
                        x2 = b.X + (sy - b.Y) * (c.X - b.X) / (c.Y - b.Y);
                    }

                }

                if (x1 > x2)
                {
                    float tmp = x1;
                    x1 = x2; x2 = tmp;
                }

                g.DrawLine(pen, x1, sy, x2, sy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a.X = Convert.ToInt64(textBox1.Text);
                a.Y = Convert.ToInt64(textBox2.Text);

                b.X = Convert.ToInt64(textBox3.Text);
                b.Y = Convert.ToInt64(textBox4.Text);

                c.X = Convert.ToInt64(textBox5.Text);
                c.Y = Convert.ToInt64(textBox6.Text);

                DrawTriangle();
            }
            catch
            {
                MessageBox.Show("Fill in all fields");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PointSearch();
            }
            catch
            {
                MessageBox.Show("Fill in all fields");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                a.X = Convert.ToInt64(textBox1.Text);
                a.Y = Convert.ToInt64(textBox2.Text);

                b.X = Convert.ToInt64(textBox3.Text);
                b.Y = Convert.ToInt64(textBox4.Text);

                c.X = Convert.ToInt64(textBox5.Text);
                c.Y = Convert.ToInt64(textBox6.Text);

                colorDialog1.ShowDialog();

                ReDrawTriangle(colorDialog1.Color);
            }
            catch
            {
                MessageBox.Show("Fill in all fields");
            }
        }
    }
}