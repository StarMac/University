using System;

namespace lab2_3
{
    class Program
    {
        public delegate void Div(int[] mas);
        static void Main(string[] args)
        {
            int[] arr = {-7,-5,-3,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21};
            Div d3 = new Div(Div3);
            Div d7 = new Div(Div7);
            d3(arr);
            d7(arr);
            Console.ReadKey();
        }
        public static void Div3(int[] mas)
        {
            Console.WriteLine("Numbers divisible by 3: ");
            foreach (int number in mas)
            {
                if (number % 3 == 0 && number != 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
        public static void Div7(int[] mas)
        {
            Console.WriteLine("Numbers divisible by 7: ");
            foreach (int number in mas)
            {
                if (number % 7 == 0 && number != 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
