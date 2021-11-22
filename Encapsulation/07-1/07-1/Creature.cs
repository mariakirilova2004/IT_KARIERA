using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_1
{
    class Creature
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int years;
        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        private string areal;
        public string Areal
        {
            get { return areal; }
            set { areal = value; }
        }
    }
}
