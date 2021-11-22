using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,area;
            Console.Write("a= ");
            a = int.Parse(Console.ReadLine());
            area = a * a;
            Console.Write("Square= ");
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
