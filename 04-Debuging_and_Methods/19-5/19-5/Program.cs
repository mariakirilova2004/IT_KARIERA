using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsium = double.Parse(Console.ReadLine());
            celsium = Celsium(celsium);
            Console.WriteLine("{0:0.00}", celsium);
            Console.ReadKey();
        }
        static double Celsium(double faren)
        {
            faren = (faren - 32) * 5 / 9;
            return faren;
        }
    }
}
