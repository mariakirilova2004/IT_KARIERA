using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepen2Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Math.Pow(2, n); i = i * 2*2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
