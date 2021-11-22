using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kingname = Console.ReadLine();
            King king = new King(kingname);
            string[] royalguards = Console.ReadLine().Split().ToArray();
            string[] footmans = Console.ReadLine().Split().ToArray();
            foreach (var item in royalguards)
            {
                Royal_Guard royalguard = new Royal_Guard(item);
                Royal_Guard.listRoyal_Guard.Add(royalguard);
            }
            foreach (var item in footmans)
            {
                Footman footman = new Footman(item);
                Footman.listFootman.Add(footman);
            }
            while(true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                if (commands[0] == "End") break;
                else if (commands[0] == "Attack")
                {
                    king.Attack();
                    Royal_Guard royal = new Royal_Guard("ctor");
                    royal.OnKingAttackedKing(king, new AttackedKingEventArgs(king.Name));
                    Footman foot = new Footman("ctor");
                    foot.OnKingAttackedKing(king, new AttackedKingEventArgs(king.Name));
                }
                else if(commands[0] == "Kill")
                {
                    for (int i = 0; i < Footman.listFootman.Count; i++)
                    {
                        if (commands[1] == Footman.listFootman[i].Name) Footman.listFootman.RemoveAt(i);
                    }
                    for (int i = 0; i < Royal_Guard.listRoyal_Guard.Count; i++)
                    {
                        if (commands[1] == Royal_Guard.listRoyal_Guard[i].Name) Royal_Guard.listRoyal_Guard.RemoveAt(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
