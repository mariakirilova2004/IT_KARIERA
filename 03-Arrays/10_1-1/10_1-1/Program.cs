using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string masiv = Console.ReadLine();
            int[] chisla = masiv.Split().Select(int.Parse).ToArray();
            int min = chisla[0];
            int max = chisla[0];
            int sum = chisla[0];
            for (int i = 1; i < chisla.Length; i++)
            {
                if (chisla[i] < min) min = chisla[i];
                if (chisla[i] > max) max = chisla[i];
                sum += chisla[i];
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {(float)sum / chisla.Length}");
            Console.ReadKey();
        }
    }
}
