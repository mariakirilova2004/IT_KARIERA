using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Royal_Guard
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Royal_Guard(string name)
        {
            Name = name;
        }
        public static List<Royal_Guard> listRoyal_Guard = new List<Royal_Guard>();

        public void Kill_Royal_Guard(string name)
        {
            for (int i = 0; i < listRoyal_Guard.Count; i++)
            {
                if (listRoyal_Guard[i].Name == name)
                {
                    listRoyal_Guard.RemoveAt(i);
                    break;
                }
            }
        }

        public void OnKingAttackedKing(object sender, AttackedKingEventArgs args)
        {
            King king = new King(args.KingName);
            king.AttackedKing += OnKingAttackedKing;
            foreach (var item in listRoyal_Guard)
            {
                Console.WriteLine($"Royal Guard {item.Name} is defending!");
            }
        }
    }
}
