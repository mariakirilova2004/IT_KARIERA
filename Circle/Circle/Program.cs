using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius:");
            double r = double.Parse(Console.ReadLine());
            double area = Math.Round(Math.PI * r * r,2);
            double perimeter = Math.Round(Math.PI * (2 * r),2);
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
            Console.ReadKey();
        }
    }
}
