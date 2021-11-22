using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_1
{
    class Pizza
    {
        private int brtops;
        public int Brtops
        {
            get { return brtops; }
            set 
            {
                if (value > 0 && value < 10) brtops = value;
                else throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length > 0 && value.Length < 16) name = value;
                else throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
        }

        public List<Topping> toppings = new List<Topping>();
        public Dough dough;

        public Pizza()
        {

        }

        public Pizza(string name, int br) : this()
        {
            Brtops = br;
            Name = name;
        }

        public double Calories
        {
            get
            {
                double cal;
                cal = dough.Caloriesd + toppings.Sum(x => x.Caloriest);
                return cal;
            }
        }
    }
}
