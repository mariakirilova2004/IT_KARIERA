using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_2
{
    class Footballer
    {
        private string name;
        public string Name  
        {
            get { return name; }
            set 
            {
                if (value == " ") throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }

        private double endurance;
        public double Еndurance
        {
            get { return endurance; }
            set 
            { 
                if (value > 0 && value < 100) endurance = value;
                else throw new ArgumentException($"Endurance should be between 0 and 100.");
            }
        }

        private double sprint;
        public double Sprint
        {
            get { return sprint; }
            set 
            {
                if (value > 0 && value < 100) sprint = value;
                else throw new ArgumentException($"Sprint should be between 0 and 100.");
            }
        }

        private double dribble;
        public double Dribble
        {
            get { return dribble; }
            set 
            {
                if (value > 0 && value < 100) dribble = value;    
                else throw new ArgumentException($"Dribble should be between 0 and 100.");
            }
        }

        private double passing;
        public double Passing
        {
            get { return passing; }
            set 
            {
                if (value > 0 && value < 100) passing = value;
                else throw new ArgumentException($"Passing should be between 0 and 100."); 
            }
        }

        private double shooting;
        public double Shooting
        {
            get { return shooting; }
            set 
            {
                if (value > 0 && value < 100) shooting = value;
                else throw new ArgumentException($"Shooting should be between 0 and 100."); 
            }
        }

        public double Rate()
        {
            return Math.Round((Еndurance + Sprint + Dribble + Passing + Shooting) / 5);
        }

        public Footballer(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            Name = name;
            Еndurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
    }
}
