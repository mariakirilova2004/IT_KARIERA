using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            if (input.Contains(num)) Console.WriteLine($"{num} Exists in the List");
            else Console.WriteLine($"{num} Not exists in the List");
            Console.ReadKey();
        }
    }
}
