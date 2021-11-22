using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zad
{
    class Dog: Animal
    {
        public Dog(string name, int age): base(name, age)
        {
                
        }

        public string MakeNoise()
        {
            return "Woof!" + Environment.NewLine + base.MakeNoise();
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
