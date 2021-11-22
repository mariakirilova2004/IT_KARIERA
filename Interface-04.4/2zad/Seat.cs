using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zad
{
    class Seat:ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
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
            return $"I only have Seat {Model} in {Color} color.";
        }
    }
}
