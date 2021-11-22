using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            zad4_SelectionSort.Sort(input);
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine($"{input[a[0] - 1]} {input[a[1] - 1]}");
            Console.ReadKey(); 
        }
    }
}
