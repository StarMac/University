using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LabProject
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen pn;
        Pen pn1;

        int x0;
        int x1;
        int speed0;
        int speed1;

        int y0;
        int y1;
        int y2;
        int y3;
        int count;
        bool flag = true;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(picture.Width, picture.Height);


            g = Graphics.FromImage(bmp);
            pn = new Pen(Color.Black, 5);
            pn1 = new Pen(Color.Black, 5);
            pn1.DashStyle = DashStyle.Dash;
            picture.Image = bmp;


        }


        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Static Pictures (Button)
        {
            timer1.Enabled = false;
            timer2.Enabled = false; 
            g.Clear(Color.White);
            //Parallelepiped
            Point p0 = new Point(20, 90);
            Point p1 = new Point(100, 10);
            Point p2 = new Point(320, 10);
            Point p3 = new Point(240, 90);

            Point p4 = new Point(20, 200);
            Point p5 = new Point(240, 200);
            Point p6 = new Point(320, 120);

            Point p7 = new Point(100, 120);

            g.DrawLine(pn1, p7, p4);
            g.DrawLine(pn1, p7, p6);
            g.DrawLine(pn1, p7, p1);

            g.DrawLine(pn, p0, p1);
            g.DrawLine(pn, p1, p2);
            g.DrawLine(pn, p2, p3);
            g.DrawLine(pn, p0, p3);

            g.DrawLine(pn, p0, p4);
            g.DrawLine(pn, p3, p5);
            g.DrawLine(pn, p2, p6);
            g.DrawLine(pn, p4, p5);
            g.DrawLine(pn, p5, p6);

            //Circle
            g.FillEllipse(Brushes.Blue, 400, 10, 100, 100);
            //Ellipse
            g.DrawEllipse(pn, 400, 140, 200, 100);
            //Triangle
            Point pp0 = new Point(600, 10);
            Point pp1 = new Point(600, 110);
            Point pp2 = new Point(700, 110);
            g.DrawLine(pn, pp0, pp1);
            g.DrawLine(pn, pp1, pp2);
            g.DrawLine(pn, pp0, pp2);
            //StickManTorso
            Point StickManTorso0 = new Point(135, 290);
            Point StickManTorso1 = new Point(135, 390);
            //StickManLegs
            Point StickManLeg0 = new Point(110, 470);
            Point StickManLeg1 = new Point(160, 470);
            //StickManLeftHand
            Point StickManLeftHand0 = new Point(135, 300);
            Point StickManLeftHand1 = new Point(110, 390);
            //StickManRightHand
            Point StickManRightHand0 = new Point(135, 300);
            Point StickManRightHand1 = new Point(160, 390);

            g.DrawEllipse(pn, 100, 220, 70, 70);
            g.DrawLine(pn, StickManTorso0, StickManTorso1);
            g.DrawLine(pn, StickManTorso1, StickManLeg0);
            g.DrawLine(pn, StickManTorso1, StickManLeg1);
            g.DrawLine(pn, StickManLeftHand0, StickManLeftHand1);
            g.DrawLine(pn, StickManRightHand0, StickManRightHand1);
            picture.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e) //Circels animation Button
        {
            x0 = 100;
            x1 = 200;
            speed0 = 10;
            speed1 = 10;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e) //Rocket animation Button
        {
             y0 = 250;
             y1 = 205;
             y2 = 480;
             y3 = 440;
             count = 0;
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) //Rocket animation
        {
            g.Clear(Color.White);
            //Rocket
            Point p0 = new Point(290, y0); //y0
            Point p1 = new Point(350, y0); //y0
            Point p2 = new Point(320, y1); //y1

            Point p3 = new Point(290, y2); //y2
            Point p4 = new Point(350, y2); //y2
            Point p5 = new Point(320, y3); //y3
            g.DrawLine(pn, p0, p2);
            g.DrawLine(pn, p1, p2);
            g.DrawLine(pn, p3, p5);
            g.DrawLine(pn, p4, p5);
            g.DrawLine(pn, p3, p4);
            g.DrawRectangle(pn, 290, y0, 60, 190); //y0
            //Changing fire color of rocket
            if (count % 3 == 0)
            {
                flag = !flag;
            }
            if (flag)
            {
                g.FillEllipse(Brushes.Orange, 270, y2, 100, 200); //y2
            }
            else
            {
                g.FillEllipse(Brushes.Red, 270, y2, 100, 200); //y2
            }
            picture.Image = bmp;
            //Rocket Animation
            if (count > 15)
         
                {
                y0 -= 6;
                y1 -= 6;
                y2 -= 6;
                y3 -= 6;
                }
            count++;
            if (y2 + 210 <= 0) 
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //Circels animation
        {
            g.Clear(Color.White);
            g.DrawEllipse(pn, x0, 100, 100, 100);
            g.DrawEllipse(pn, x1, 300, 100, 100);
            picture.Image = bmp;
            x0+= speed0;
            x1+= speed1;
            if (x0 < 100 || x0 + 100 > 600) 
            {
                speed0 = -speed0;
            }
            if (x1 < 200 || x1 + 100 > 400)
            {
                speed1 = -speed1;
            }
        }
    }
}
