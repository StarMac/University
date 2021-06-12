using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Part1
{
    public class Equation
    {
        public double a, b, c, d, e, f;
        public double x, y;
        public Equation()
        {
            PrintAll();
        }
        public virtual void Value()
        {
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());
            this.a = a;
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            this.b = b;
            Console.Write("Enter C: ");
            double c = double.Parse(Console.ReadLine());
            this.c = c;
            Console.Write("Enter A2: ");
            double d = double.Parse(Console.ReadLine());
            this.d = d;
            Console.Write("Enter B2: ");
            double e = double.Parse(Console.ReadLine());
            this.e = e;
            Console.Write("Enter C2: ");
            double f = double.Parse(Console.ReadLine());
            this.f = f;

        }
        public void PrintAll()
        {
            Value();

            Console.WriteLine();

            Console.WriteLine("System of equations:");
            Console.WriteLine("{0}x+{1}y={2}", a, b, c);
            Console.WriteLine("{0}x+{1}y={2}", d, e, f);

            Console.WriteLine();

            Solution(a, b, c, d, e, f, x, y);
        }

        public static void Solution(double a, double b, double c, double d, double e, double f, double x, double y)
        {
            x = (c * e - b * f) / (a * e - b * d);
            y = (a * f - c * d) / (a * e - b * d);

            Console.WriteLine("\nX = " + x + "; Y = " + y);

            if ((a * x + b * y == c) && (d * x + e * y == f))
            {
                Console.WriteLine("The point is a solution to a system of equations.");
            }
            else
            { Console.WriteLine("The point is not a solution to a system of equations."); }
        }

    }
}
