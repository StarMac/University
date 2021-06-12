using System.Drawing;
using System.Windows.Forms;

namespace LAB5
{
    class Square : Figure
    {
        private double side { get; set; }
        public Square() { }
        public Square(int x, int y, double side)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox p)
        {
            Pen c = Pens.Red;

            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(c, x, y, (int)side, (int)side);
            }

        }
        public override void HideDrawingBackGround(PictureBox p)
        {
            Pen c = Pens.White;

            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(c, x, y, (int)side, (int)side);
            }

        }
    }
}
