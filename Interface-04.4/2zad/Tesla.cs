using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }
        private int batteries;

        public int Batteries
        {
            get { return batteries; }
            set { batteries = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"I have Tesla model: {Model} and is color is: {Color} with only {Batteries} batteries.";
        }
    }
}
