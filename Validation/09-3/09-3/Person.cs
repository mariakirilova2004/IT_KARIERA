using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_3
{
    class Person
    {
        private decimal money;
        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");
                money = value; 
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Product> products = new List<Product>();

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public void Buy(Product pr)
        {
            if (Money - pr.Price < 0) Console.WriteLine($"{Name} can't afford {pr.Namepr}");
            else
            {
                products.Add(pr);
                Money -= pr.Price;
                Console.WriteLine($"{Name} bought {pr.Namepr}");
            }
        }

    }
}
