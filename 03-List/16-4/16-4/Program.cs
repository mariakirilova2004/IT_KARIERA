using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] chisla = input.Split().Select(int.Parse).ToArray();
            int[] rez = new int[1000];
            for (int i = 0; i < chisla.Length; i++)
            {
                rez[chisla[i]]++;
            }
            for (int i = 0; i < rez.Length; i++)
            {
                if (rez[i] != 0) Console.WriteLine($"{i} -> {rez[i]}");
            }
            Console.ReadKey();
        }
    }
}
