using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inch= ");
            float inch=float.Parse(Console.ReadLine());
            float cm = inch * 2.54f;
            Console.Write("Cm= ");
            Console.WriteLine(cm);
            Console.ReadKey();
        }
    }
}
