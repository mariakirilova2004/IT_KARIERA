using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = 1.79549 * USD;
            BGN = Math.Round(BGN,2);
            Console.WriteLine($"{BGN} BGN");
            Console.ReadKey();
        }
    }
}
