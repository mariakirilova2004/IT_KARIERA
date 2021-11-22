using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            input = input.Concat(input1).ToArray();
            zad5_SelectionSort.Sort(input);
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
