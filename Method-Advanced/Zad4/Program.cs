using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int a=GetMultipleEven(n);
            int b = GetMultipleOdd(n);
            Console.WriteLine(a*b);
            Console.ReadKey();
        }
        static int GetMultipleEven(int number)
        {
            int a=0;
            while(number>0)
            {
                int current = number % 10;
                if (current % 2 == 0) a = a + current;
                number = number / 10;
            }
            return a;
        }
        static int GetMultipleOdd(int number)
        {
            int a = 0;
            while (number > 0)
            {
                int current = number % 10;
                if (current % 2 != 0) a = a + current;
                number = number / 10;
            }
            return a;
        }
    }
}
