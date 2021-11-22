using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f=1,f0=1;
            for(int i=2;i<=n;i++)
            {
                int f1 = f;
                f = f + f0;
                f0 = f1;
            }
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
