using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3
{
    class Product
    {
        private  int weight;

        public  int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Product(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
