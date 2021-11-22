using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> chisla = input.Split(
                ).Select(int.Parse).ToList();
            List<int> kvadratniChisla = new List<int>();
            foreach(int chislo in chisla)
            {
                if (Math.Sqrt(chislo) % 1 == 0)
                {
                    kvadratniChisla.Add(chislo);
                }
            }
            kvadratniChisla.Sort();
            kvadratniChisla.Reverse();
            foreach (int chislo in kvadratniChisla)
            {
                Console.Write($"{chislo} ");
            }
            Console.ReadKey();
        }
    }
}
