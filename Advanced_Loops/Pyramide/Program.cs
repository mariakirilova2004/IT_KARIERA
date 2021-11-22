using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 1;
            for(int row=1;row<=n;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    Console.Write(br+" ");
                    br++;
                    if (br > n) break;
                }
                Console.WriteLine();
                if (br > n) break;
            }  
            Console.ReadKey();
        }
    }
}
