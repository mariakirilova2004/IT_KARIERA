using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_1
{
    class Dough
    {
        private string type;
        public string Type
        {
            get { return type; }
            set 
            {
                if (value == "white" || value == "wholegrain") type = value;
                else throw new ArgumentException("Invalid type of dough.");
            }
        }

        private double grams;
        public double Grams
        {
            get { return grams; }
            set 
            {
                if (value > 0 && value <= 200) grams = value;
                else throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
        }

        private string vtasvane;
        public string Vtasvane
        {
            get { return vtasvane; }
            set 
            {
                if (value == "crispy" || value == "chewy" || value == "homemade") vtasvane = value;
                else throw new ArgumentException("Invalid type of dough.");
            }
        }

        public double Caloriesd
        {
            get 
            {
                double cal = Grams * 2;

                if (Type == "white") cal = cal * 1.5;
                else if (Type == "wholegrain") cal = cal * 1.0;

                if (Vtasvane == "crispy") cal = cal * 0.9;
                else if (Vtasvane == "chewy") cal = cal * 1.1;
                else if (Vtasvane == "homemade") cal = cal * 1.0;
                return cal; 
            }
        }

        public Dough()
        {

        }
        public Dough(string type, string vtasvane, double grams) : this()
        {
            Type = type;
            Grams = grams;
            Vtasvane = vtasvane;
        }
    }
}
