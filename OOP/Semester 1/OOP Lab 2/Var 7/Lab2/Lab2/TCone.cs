using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class TCone:TCircle
    {
        static Random rnd = new Random();
        private double height;

        public TCone()
        {
            r = rnd.Next(1, 10);
            height = rnd.Next(1, 10);
        }
        public TCone(double r, double height)
        {
            this.r = r;
            this.height = height;
        }
        public TCone(TCone cone)
        {
            this.r = cone.r;
            this.height = cone.r;
        }

        public override string ToString()
        {
            return Convert.ToString("Radius:" + r + "; Height:" + height);
        }

        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
        public void Scope()
        {
            double scope = height / 3 * Math.PI * r * r;
            Console.WriteLine("Cone scope is: " + scope);
        }
    }
}
