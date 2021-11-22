using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                Person p1 = new Person(int.Parse(input[1]), input[0]);
                people.Add(p1);
            }
            people.OrderBy(o => o.name);
            people.Reverse();
            foreach (var person in people)
            {
                if(person.age != 0)
                Console.WriteLine($"{person.name} - {person.age}");
            }
            Console.ReadKey();
        }
    }
}
