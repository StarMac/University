using System;

namespace lab2_4
{
    class Program
    {

        public delegate double Del(double a, double r, int num);
        static void Main(string[] args)
        {
            Console.Write("Enter the accuracy: ");
            int num = int.Parse(Console.ReadLine());
            var a = 1.0;
            var r = 1.0 / 2.0;

            Console.WriteLine("1) 1 + 1/2 + 1/4 + 1/8 + 1/16 + ...\n" +
                "2) 1 + 1/2! + 1/3! + 1/4! + 1/5! + ...\n" +
                "3) 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...\n");
            Del del1 = FirstSum;
            Console.WriteLine($"The result of the first formula: {del1?.Invoke(a, r, num)}");
            Del del2 = SecondSum;
            Console.WriteLine($"The result of the second formula: {del2?.Invoke(a, r, num)}");
            Del del3 = ThirdSum;
            Console.WriteLine($"The result of the third formula: {del3?.Invoke(a, r, num)}");
            del3.Invoke(a, r, num);
            Console.ReadKey();
        }
        private static double FirstSum(double a, double r, int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += a;
                a *= r;
            }
            return Math.Round(sum, 2);
        }
        private static double SecondSum(double a, double r, int n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return Math.Round(sum, 2);
        }
        private static double Factorial(double num)
        {
            double res = 1;
            for (double i = num; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        private static double ThirdSum(double a, double r, int n)
        {
            var sum = 0.0;
            var PlusOrMinus = true;
            var changingSignsCount = -1;
            double tmp = sum + a;

            for (int i = 1; i <= n; i++)
            {
                changingSignsCount++;

                if (PlusOrMinus)
                {
                    sum += tmp;
                }
                else
                {
                    sum -= tmp;
                }
                if (changingSignsCount == 1)
                {
                    PlusOrMinus = !PlusOrMinus;
                    changingSignsCount = 0;
                }

                tmp = a *= r;
            }
            return Math.Round(sum, 2);
        }
    }
}