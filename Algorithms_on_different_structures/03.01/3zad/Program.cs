using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            double avg = 0;
            foreach (var item in input)
            {
                sum += item;
            }
            avg = sum / input.Count;
            Console.WriteLine($"Sum={sum}; Average={avg:0.00}");
            Console.ReadKey();
        }
    }
}
