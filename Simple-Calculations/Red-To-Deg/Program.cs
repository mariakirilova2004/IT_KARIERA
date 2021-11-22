using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Red_To_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double d = 180*r/ Math.PI;
            d = Math.Round(d);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
