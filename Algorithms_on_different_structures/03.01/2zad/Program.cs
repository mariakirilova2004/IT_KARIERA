using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] input1 = input.ToArray();
            int num = int.Parse(Console.ReadLine());
            int index = 0;
            foreach (var item in input)
            {
                if (item > num)
                {
                    input.Insert(index, num);
                    break;
                }
                index++;
            }
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in input1)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
