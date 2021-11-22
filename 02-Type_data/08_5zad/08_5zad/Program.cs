using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_5zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string age = Console.ReadLine();
            string fm = Console.ReadLine();
            string id = Console.ReadLine();
            string number = Console.ReadLine();
            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {fm}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Personal ID: {number}");
            Console.ReadKey();
        }
    }
}
