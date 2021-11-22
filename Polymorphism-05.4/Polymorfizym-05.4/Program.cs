using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizym_05._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Trainer tr = new Trainer(cat);
            Console.WriteLine(tr.Make());
            Trainer tr1 = new Trainer(dog);
            Console.WriteLine(tr1.Make());
            Console.ReadKey();
        }
    }
}
