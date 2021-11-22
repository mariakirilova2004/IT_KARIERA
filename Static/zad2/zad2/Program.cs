using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Geometry.SquarePerimeter(3));
            Console.WriteLine(Geometry.SquareArea(3));
            Console.WriteLine(Geometry.RectanglePerimeter(3, 2));
            Console.WriteLine(Geometry.RectangleArea(3, 2));
            Console.WriteLine(Geometry.CircleArea(3));
            Console.ReadKey();
        }
    }
}
