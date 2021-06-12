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
        static void Randome(ref int[][] matrix, int m)

        {

            Random rnd = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = rnd.Next(-5, 5);
                }
            }
        }
        static void Output(int[][] matrix, int m)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    string space = " ";

                    if (matrix[i][j] >= 0)
                    {
                        space = "  ";
                    }
                    Console.Write("{0}{1}",space, matrix[i][j]);
                }
                Console.WriteLine();
            }
        }


        static void Resize(ref int[][] matrix, ref int[][] matrixResized, int k, int m)
        {
            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i != k)
                {
                    Array.Copy(matrix[i], 0, matrixResized[count], 0, m);
                    count++;
                }
            }
        }
        static void Value(string n_m, ref int n, ref int m)
        {
            int[] n_m_Box = n_m.Split(' ').Select(int.Parse).ToArray();
            n = n_m_Box[0];
            m = n_m_Box[1];
        }
        static void ArrayInitialization(ref int[][] matrix, int m)
        {
            for (int i =0; i < matrix.Length; i++)
                {
                matrix[i] = new int[m];
                }
        }
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            string n_m = Console.ReadLine();
            Value(n_m, ref n, ref m);
            int[][] matrix = new int[n][];
            ArrayInitialization(ref matrix, m);
            Randome(ref matrix, m);
            Output(matrix, m);
            Console.WriteLine();
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[][] matrixResized = new int[n-1][];
            ArrayInitialization(ref matrixResized, m);
            Resize(ref matrix, ref matrixResized, k, m);
            Output(matrixResized, m);
            Console.ReadKey();
        }
    }
}