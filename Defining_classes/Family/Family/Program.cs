using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Family Fam = new Family();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person p1 = new Person(input[0], int.Parse(input[1]));
                Fam.family.Add(p1);
            }
            Fam.SortFam(Fam.family);
            foreach (var item in Fam.family)
            {
                Console.WriteLine($"{item.name} {item.age}");
            }
            Console.ReadKey();
        }
    }
}
