using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while(true)
            {
                Console.WriteLine("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100) break;
                Console.WriteLine("Invalid number!");
            }
            Console.WriteLine($"The number is: {n}");
            Console.ReadKey();
        }
    }
}
