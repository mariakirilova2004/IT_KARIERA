using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gosho", 13);
            Console.WriteLine(Person.Count);
            Console.ReadKey();
        }
    }
}
