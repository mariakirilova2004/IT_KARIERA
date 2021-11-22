using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(20, "Pesho");
            Person person2 = new Person(18, "Gosho");
            Person person3 = new Person(43, "Stamat");
            person1.Show();
            person2.Show();
            person3.Show();
            Console.ReadKey();
        }
    }
}
