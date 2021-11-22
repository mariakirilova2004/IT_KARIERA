using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_2
{
    class Team
    {
        public List<Footballer> team = new List<Footballer>();
        private string nameTeam;
        public string NameTeam
        {
            get { return nameTeam; }
            set 
            {
                if (value == " ") throw new ArgumentException("A name should not be empty.");
                nameTeam = value; 
            }
        }

        private int rating;
        public void Rating()
        {
            double Sum = 0;
            if (team.Count == 0) Console.WriteLine($"{NameTeam} - 0");
            else
            {
                foreach (var player in team)
                {
                    Sum += player.Rate();
                }
                Sum /= team.Count;
                Console.WriteLine($"{NameTeam} - {Sum}");

            }
                
        }

        public Team(string name)
        {
            NameTeam = name;
        }
    }
}
