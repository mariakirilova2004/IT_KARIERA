using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_1
{
    class Topping
    {
        private double gramstopping;
        public double GramsTopping
        {
            get { return gramstopping; }
            set
            {
                if (value > 0 && value <= 50) gramstopping = value;
                else throw new ArgumentException($"{NameTopping} weight should be in the range [1..50].");
            }
        }


        private string nametopping;
        public string NameTopping
        {
            get { return nametopping; }
            set
            {
                if (value == "meat" || value == "veggies" || value == "cheese" || value == "sauce") nametopping = value;
                else throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
        }

        public double Caloriest
        {
            get
            {
                double cal = GramsTopping * 2;

                if (NameTopping == "meat") cal = cal * 1.2;
                else if (NameTopping == "veggies") cal = cal * 0.8;
                else if (NameTopping == "cheese") cal = cal * 1.1;
                else if (NameTopping == "sauce") cal = cal * 0.9;
                return cal;
            }
        }

        public Topping(string name, double grams)
        {
            NameTopping = name;
            GramsTopping = grams;
        } 
    }
}
