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
                    matrix[i, j] = rnd.Next(-5, 5);
                }
            }
        }
        static void Output(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)

            {                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string space = " ";

                    if (matrix[i, j] >= 0)
                    {
                        space = "  ";
                    }
                    Console.Write("{0}{1} ", space, matrix[i, j]);
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

        static void MaxSumAndIndex(ref int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int min = int.MaxValue;
                int i1 = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (min > matrix[i,j])
                    {
                        min = matrix[i, j]; 
                        i1 = i; 

                    }
                }
                int temp = matrix[0, j];
                matrix[0, j] = min;
                matrix[i1, j] = temp;
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
            Output(matrix);
            Console.WriteLine();
            MaxSumAndIndex(ref matrix);
            Output(matrix);
            Console.ReadKey();
        }
    }
}