using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br=0;
            for(int i=2;i<n;i++)
            {
                if (Math.Abs(n % i) == 0 && Math.Abs(n)!=2) {br = 1; break; }
            }
            if(br==1 || n==1 || n==0 || n==-1)
            Console.WriteLine("Not Prime");
            else
            Console.WriteLine("Prime");
            Console.ReadKey();
        }
    }
}
