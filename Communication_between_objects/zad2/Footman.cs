using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Footman
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Footman(string name)
        {
            Name = name;
        }

        public static List<Footman> listFootman =  new List<Footman>();

        public void Kill_Footman(string name)
        {
            for (int i = 0; i < listFootman.Count; i++)
            {
                if(listFootman[i].Name == name)
                {
                    listFootman.RemoveAt(i);
                    break;
                }
            }
        }

        public void OnKingAttackedKing(object sender, AttackedKingEventArgs args)
        {
            King king = new King(args.KingName);
            king.AttackedKing += OnKingAttackedKing;
            foreach (var item in listFootman)
            {
                Console.WriteLine($"Footman {item.Name} is panicking!");
            }
        }
    }
}
