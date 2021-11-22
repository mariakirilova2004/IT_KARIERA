using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Stepen(a,b));
            Console.ReadKey();
        }
        static int Stepen(int a,int b)
        {
            int rez=1;
            for (int i = 1; i <=b; i++)
            {
                rez = rez*a
                    ;
            }
            return rez;
        }
    }
}
