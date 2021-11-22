using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            string[] let = niz.Split().ToArray();
            for(int i=let.Length-1; i>=0; i--)
            {
                Console.Write($"{let[i]} ");
            }
            Console.ReadKey();
        }
    }
}
