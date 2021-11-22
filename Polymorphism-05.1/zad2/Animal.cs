using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string favouriteFood;

        public string FavouriteFood
        {
            get { return favouriteFood; }
            set { favouriteFood = value; }
        }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I'm {Name} and my favourite food is {FavouriteFood}";
        }
    }
}
