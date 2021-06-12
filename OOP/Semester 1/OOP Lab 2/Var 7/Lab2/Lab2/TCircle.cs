using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class TCircle
    {
        static Random rnd = new Random();
        protected double r;

        public TCircle()
        {
            r = rnd.Next(1, 10);
        }
        public TCircle(double r)
        {
            this.r = r;
        }
        public TCircle(TCircle circle)
        {
            this.r = circle.r;
        }

        public override string ToString() 
        {
            return Convert.ToString(r);
    }
        public double R
        {
            get { return r; }
            set { if (value > 0) r = value; }
        }
        public void GetPerimeter()
        {
            double perimeter = Math.PI * r * 2;
            Console.WriteLine($"Perimeter: {perimeter}");
        }
        public void GetSquare()
        {
            double square;
            square = Math.PI * r * r;
            Console.WriteLine($"Square: {square}");
        }
        public void GetSectorSquare(double n)
        {
            double sectorSquare;
            sectorSquare = Math.PI * (r * r) * n / 360;
            Console.WriteLine($"Sector_S: {sectorSquare}");
        }

        public static void  Compare(TCircle a, TCircle b)
        {
            if (a.r > b.r) { Console.WriteLine(a.r + " > " + b.r + " on " + (a.r - b.r));}
            else if (a.r < b.r) { Console.WriteLine(a.r + " < " + b.r + " on " + (b.r - a.r)); }
            else if (a.r == b.r) { Console.WriteLine(a.r + " = " + b.r);}

        }
        public static TCircle operator +(TCircle a, TCircle b)
        {
            TCircle c = new TCircle();
            c.r = a.r + b.r;
            return c;
        }
          public static  TCircle operator -(TCircle a, TCircle b)
        {
            TCircle c = new TCircle();
            c.r = Math.Abs (a.r - b.r);
            return c;
        }
          public static TCircle operator *(TCircle a, double n)
        {
            TCircle c = new TCircle();
            c.r = a.r * n;
            return c;
        }
        public static TCircle operator *(double n, TCircle a)
        {
            TCircle c = new TCircle();
            c.r = n * a.r;
            return c;
        }
    }
}
