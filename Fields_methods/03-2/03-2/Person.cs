using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_2
{
    class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(int age, string name)
        {
            Age = age;            
            Name = name;            
        }

        public void Show()
        {
            Console.WriteLine($"{Name} -> {Age} years old");
        }
    }
}
