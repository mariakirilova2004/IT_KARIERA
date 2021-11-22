using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Team wolf = new Team("Wolf");
            Person p1 = new Person("Maria", 20);
            Person p2 = new Person("Koko", 40);
            Person p3 = new Person("Pele", 30);
            Person p4 = new Person("Silva", 45);
            Person p5 = new Person("Tonka", 5);
            Person p6 = new Person("Golri", 50);
            Person p7 = new Person("Haliv", 78);
            wolf.AddPlayer(p1);
            wolf.AddPlayer(p2);
            wolf.AddPlayer(p3);
            wolf.AddPlayer(p4);
            wolf.AddPlayer(p5);
            wolf.AddPlayer(p6);
            wolf.AddPlayer(p7);
            Console.WriteLine(wolf.FirstTeam.Count);
            Console.WriteLine(wolf.ReserveTeam.Count);
            Console.ReadKey();
        }
    }
}
