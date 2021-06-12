using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LAB5
{
    class Rhomb : Figure
    {
        private double horDiag { get; set; }

        private double vertDiag { get; set; }

        public Rhomb() { }
        public Rhomb(int x, int y, double horDiagLen, double vertDiagLen)
        {
            this.x = x;
            this.y = y;
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }

        public override void DrawBlack(PictureBox p)
        {
            Pen c = Pens.Green;

            using (var g = Graphics.FromImage(p.Image))
            {

                Rectangle r = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(45, new PointF(r.Left + (r.Width / 2),
                        r.Top + (r.Height / 2)));

                    g.Transform = m;
                    g.DrawRectangle(c, r);

                }
            }
        }
        public override void HideDrawingBackGround(PictureBox p)
        {
            Pen c = Pens.White;

            using (var g = Graphics.FromImage(p.Image))
            {

                Rectangle r = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
                using (Matrix m = new Matrix())
                {
                    m.RotateAt(45, new PointF(r.Left + (r.Width / 2),
                        r.Top + (r.Height / 2)));

                    g.Transform = m;
                    g.DrawRectangle(c, r);

                }
            }
        }
    }
}
