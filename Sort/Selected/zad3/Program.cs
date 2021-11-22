using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            zad3_SelectionSort.Sort(input);
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
