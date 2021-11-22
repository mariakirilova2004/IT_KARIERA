using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b=double.Parse(Console.ReadLine());
            double hb = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(b,hb));
            Console.ReadKey();
        }
        static double Area(double b1,double hb1)
        {
            double area = (b1 * hb1)/2.0;
            return area;
        }
    }
}
