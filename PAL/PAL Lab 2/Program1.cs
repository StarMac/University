using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExB
{
    class Program
    {
        static void Randome(ref int[,] matrix)

        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)

            {                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string space = " ";
                    matrix[i, j] = rnd.Next(-5, 5);
                    if (matrix[i, j] >= 0)
                    {
                        space = "  ";
                    }
                    Console.Write("{0}{1} ",space, matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Value(string n_m, ref int n, ref int m)
        {
            int[] n_m_Box = n_m.Split(' ').Select(int.Parse).ToArray();
            n = n_m_Box[0];
            m = n_m_Box[1];
        }

        static void MaxSumAndIndex(int n, int m,  int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int product = 1;
                bool boolean = true;
                for (int j = 0; j < matrix.GetLength(1) && boolean == true; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        boolean = false;
                    }
                    product *= matrix[i, j];
                }
                if  (boolean)
                {
                    
                    Console.WriteLine("in {1} row product equals: {0}", product, i);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            string n_m = Console.ReadLine();
            Value(n_m, ref n, ref m);
            int[,] matrix = new int[n,m];
            Randome(ref matrix);
            MaxSumAndIndex(n, m, matrix);

            Console.ReadKey();
        }
    }
}