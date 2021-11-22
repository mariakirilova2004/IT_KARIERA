using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_2_Reverse_
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            string[] let = niz.Split().ToArray();
            let.Reverse(let);
            foreach(string i in let)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}
