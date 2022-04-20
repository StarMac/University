using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2ComputerGraphics
{
    public partial class Form1 : Form
    {
        Brush brush;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void MyAlgorithm()
        {
            brush = Brushes.Red;

            var g = Graphics.FromImage(pictureBox1.Image);

            var R = Convert.ToDouble(textBox_Radius.Text);
            var X = Convert.ToInt32(textBox_X.Text) * 2;
            var Y = Convert.ToInt32(textBox_Y.Text);

            for (int i = 0; i < 360; i++)
            {
                var x = X + Math.Round(R * Math.Sin(i * Math.PI / 180));
                var y = Y - Math.Round(R * Math.Cos(i * Math.PI / 180));
                g.FillRectangle(brush, (int)x, (int)y, 1, 1);
            }
            pictureBox1.Refresh();
        }

        private void BresenhemAlgorithm()
        {
            brush = Brushes.Blue;

            var g = Graphics.FromImage(pictureBox1.Image);

            var R = Convert.ToDouble(textBox_Radius.Text);
            var X = Convert.ToInt32(textBox_X.Text);
            var Y = Convert.ToInt32(textBox_Y.Text);

            int x = 0, y = (int)R, gap, delta = (int)(2 - 2 * R);

            while (y >= 0)
            {
                g.FillRectangle(brush, (X + x), (Y + y), 1, 1);
                g.FillRectangle(brush, (X + x), (Y - y), 1, 1);
                g.FillRectangle(brush, (X - x), (Y - y), 1, 1);
                g.FillRectangle(brush, (X - x), (Y + y), 1, 1);

                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
            pictureBox1.Refresh();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var stopwatchMyAlgorithm = new Stopwatch();
            var stopwatchBresenhemAlgorithm = new Stopwatch();

            try
            {
                stopwatchMyAlgorithm.Start();
                MyAlgorithm();
                stopwatchMyAlgorithm.Stop();

                stopwatchBresenhemAlgorithm.Start();
                BresenhemAlgorithm();
                stopwatchBresenhemAlgorithm.Stop();
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

                textBox_X.Text = null;
                textBox_Y.Text = null;
                textBox_Radius.Text = null;
                textBox_Bresenhem.Text = null;
                textBox_My.Text = null;
            }

            textBox_Bresenhem.Text = stopwatchBresenhemAlgorithm.ElapsedMilliseconds.ToString();
            textBox_My.Text = stopwatchMyAlgorithm.ElapsedMilliseconds.ToString();
        }

        private void textBox_Radius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}