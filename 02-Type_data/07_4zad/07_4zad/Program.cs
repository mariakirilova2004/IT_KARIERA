using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_4zad
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=97;i<=123;i++)
            {
                for (int j = 97; j <= 121; j++)
                {
                    for (int q = 97; q <= 121; q++)
                    {
                        char a = Convert.ToChar(i);
                        char b = Convert.ToChar(j);
                        char c = Convert.ToChar(q);
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
