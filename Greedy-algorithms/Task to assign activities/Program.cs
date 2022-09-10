using System;

namespace zad1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> variations = new List<Person>();
            List<Person> people = new List<Person>();
            for (int j = 0; j < 8; j++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                people.Add(new Person(input[0], int.Parse(input[1]), int.Parse(input[2])));
            }

            people = people.OrderBy(x => x.End).ToList();
            Person next = people[0];
            int i= 0;
            variations.Add(people[i]);
            while (next != null)
            {
                next = people.Where(x => next.End <= x.Start).FirstOrDefault();
                if(next != null)variations.Add(next);
            }

            foreach (var item in variations)
            {
                Console.Write(item.Name + " ");
                Console.Write(item.Start + " ");
                Console.Write(item.End + " ");
                Console.WriteLine();
            }
        }
    }

    public class Person
    {
        public Person(string name, int start, int end)
        {
            this.Name = name;
            this.Start = start;
            this.End = end;
        }

        public string Name { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }
}

