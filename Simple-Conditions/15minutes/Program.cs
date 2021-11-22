using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m;
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            m = m + 15;            
            if (m > 60)
            {
                h++;
                m = m-60;
            }
            if (h > 23) h = 0;
                Console.Write($"{h}:");
                if (m / 10 < 1)
                {
                    Console.Write($"0{m}");
                }
                else
                {
                    Console.Write(m);
                }
            Console.ReadKey();
        }
    }
}
