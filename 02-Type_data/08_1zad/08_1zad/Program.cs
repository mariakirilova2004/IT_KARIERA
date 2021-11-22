using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine($"Hello, {name} {surname}. You are {age} years old.");
            Console.ReadKey();
        }
    }
}
