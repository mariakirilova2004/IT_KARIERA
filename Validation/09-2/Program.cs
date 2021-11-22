using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                box box1 = new box(a, b, c);
                box1.Povyrhnina();
                box1.OkolnaPovyrhnina();
                box1.Obem();
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
