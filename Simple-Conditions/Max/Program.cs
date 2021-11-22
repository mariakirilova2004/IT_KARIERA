using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a,b));
            Console.ReadKey();
        }
    }
}
