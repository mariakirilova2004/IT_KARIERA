using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Animal : IMakeNoise, IMakeTrick
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string MakeNoise()
        {
            return $"My name is {name}. I am {age} old.";
        }

        public string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
