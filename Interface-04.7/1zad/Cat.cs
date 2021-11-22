using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Cat:Animal
    {
        public Cat(string name, int age):base(name,age)
        {

        }
        public string MakeNoise()
        {
            return "Meow!" + Environment.NewLine + base.MakeNoise();
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
