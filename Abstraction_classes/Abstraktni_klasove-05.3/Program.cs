using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktni_klasove_05._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2,3);
            Circle c = new Circle(3);
            Console.WriteLine(r.Draw());
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(r.CalculatePerimeter());
            Console.WriteLine(c.Draw());
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
