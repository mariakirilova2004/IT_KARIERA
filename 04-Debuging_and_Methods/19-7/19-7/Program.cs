using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            double stepen = double.Parse(Console.ReadLine());
            double T = Up(chislo, stepen);
            Console.WriteLine(T);
            Console.ReadKey();
        }
        static double Up(double chislo, double stepen)
        {
            return Math.Pow(chislo, stepen);
        }
    }
}
