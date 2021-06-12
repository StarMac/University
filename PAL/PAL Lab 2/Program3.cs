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
        static void Randome(ref int[] matrix)

        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)

            {
                    matrix[i] = rnd.Next(-5, 5);
            }
        }
        static void Output(int[] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("{0} ", matrix[i]);
            }
            Console.WriteLine();
        }
        

        static void Resize(ref int[] matrix, ref int[] matrixResized, int t, int k)
        {
            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i < k || i >= k + t)
                {
                    matrixResized[count] = matrix[i];
                    count++;
                }
            }
        }
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] matrix = new int[n];
            Randome(ref matrix);
            Output(matrix);
            Console.WriteLine();
            int t = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] matrixResized = new int[matrix.Length - t];
            Resize(ref matrix, ref matrixResized, t, k);
            Output(matrixResized);
            Console.ReadKey();
        }
    }
}