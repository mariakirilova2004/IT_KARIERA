using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<double> numbers = input.Split().Select(double.Parse).ToList();
            numbers.Sort();
            Console.Write(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
            {
                    Console.Write($" <= {numbers[i]}");
            }
            Console.ReadKey();
        }
    }
}
