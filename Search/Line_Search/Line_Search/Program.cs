using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine(LineSearch(a, element));
            Console.ReadKey();
        }

        public static int LineSearch<T>(T[] a, T element)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
