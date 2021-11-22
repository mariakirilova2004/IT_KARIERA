using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine("even");
            }
            else 
            {
                Console.WriteLine("odd");
            }
            Console.ReadKey();
        }
    }
}
