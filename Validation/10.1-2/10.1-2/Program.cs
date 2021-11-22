using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            while(true)
            {
                string[] input = Console.ReadLine().Split(';').ToArray();
                if (input[0] == "END") break;
                else
                {
                    if (input[0] == "Team")
                    {
                        teams.Add(new Team(input[1]));
                    }

                    if (input[0] == "Add")
                    {
                        int cont = 0;
                        foreach (var teamcr in teams)
                        {
                            if (teamcr.NameTeam == input[1])
                            {
                                try
                                {
                                teamcr.team.Add(new Footballer(input[2], int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7])));
                                }
                                catch(ArgumentException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                cont++;
                                break;
                            }
                        }
                        if(cont == 0) Console.WriteLine($"Team {input[1]}  does not exists.");
                    }

                    if (input[0] == "Remove")
                    {
                        int cont = 0;
                        foreach (var teamcr in teams)
                        {
                            if (teamcr.NameTeam == input[1])
                            {
                                int i = 0;
                                foreach (var names in teamcr.team)
                                {
                                    if (names.Name == input[2]) { teamcr.team.RemoveAt(i); cont++; break; }
                                    i++;
                                }
                            }
                        }
                        if (cont == 0) Console.WriteLine($"Player {input[2]} is not in {input[1]} team. ");
                    }

                    if (input[0] == "Rating")
                    {
                        int cont = 0;
                        foreach (var teamcr in teams)
                        {
                            if (teamcr.NameTeam == input[1]) { teamcr.Rating(); cont++; break; }
                        }
                        if (cont == 0) Console.WriteLine($"Team {input[1]}  does not exists.");
                    }

                }
            }
                          

            Console.ReadKey();
        }
    }
}
