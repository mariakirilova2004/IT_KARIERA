using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f=1;
            for(int i=1;i<=n;i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
