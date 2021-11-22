using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizym_05._4
{
    class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public string Perform()
        {
            return MakeTrick() + Environment.NewLine + MakeNoise();
        }
    }
}
