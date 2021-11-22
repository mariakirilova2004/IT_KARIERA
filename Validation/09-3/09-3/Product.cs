using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_3
{
    class Product
    {
        private string namepr;
        public string Namepr
        {
            get { return namepr; }
            set 
            {
                if (value == " ") throw new ArgumentException ("Name cannot be empty");
                namepr = value; 
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set 
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");
                price = value; 
            }
        }

        public Product(string namepr, decimal price)
        {
            Namepr = namepr;
            Price = price;
        }
    }
}
