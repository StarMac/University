using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            TCircle Circle = new TCircle(2.7);
            Circle.R = -2.3;
            Console.WriteLine("First Circle Raduisses:" + Circle.ToString());
            Circle.GetPerimeter();
            Circle.GetSquare();
            Console.Write("SectorSquare with number '10' ");
            Circle.GetSectorSquare(10);
            Console.WriteLine();

            TCircle Circle1 = new TCircle(1.5);
            Circle1.R = -2.3;
            Console.WriteLine("Second Circle Raduisses:" + Circle1.ToString());
            Circle1.GetPerimeter();
            Circle1.GetSquare();
            Console.Write("SectorSquare with number '10' ");
            Circle1.GetSectorSquare(10);
            Console.WriteLine(Circle1.ToString());

            Console.WriteLine("Sum of two triangles:" + Circle + Circle1);
            Console.WriteLine("the difference of two triangles:" + (Circle - Circle1));
            Console.WriteLine("Multiplication of a triangle by a number 1.2: " + (1.2 * Circle1));
            Console.Write("Comparing of two circles: ");
            TCircle.Compare(Circle, Circle1);
            Console.WriteLine();

            TCone cone = new TCone(1.5 , 2);
            Console.WriteLine("Cone:" + cone.ToString());
            cone.Scope();

        }
    }
}