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
        static void Randome(ref List <int> array, int n)

        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)

            {
                    array.Add (rnd.Next(-5, 5));
            }
        }
        static void Output(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        

        static void Resize(ref List<int> array, int t, int k)
        {
            array.RemoveRange(k, t);        
        }
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> array = new List<int>();
            Randome(ref array, n);
            Output(array);
            Console.WriteLine();
            int t = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Resize(ref array, t, k);
            Output(array);
            Console.ReadKey();
        }
    }
}