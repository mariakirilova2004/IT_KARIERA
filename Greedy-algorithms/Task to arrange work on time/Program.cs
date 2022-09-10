namespace zad3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> variations = new List<Person>();
            List<Person> people = new List<Person>();
            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                people.Add(new Person(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2])));
            }
            people = people.OrderByDescending(x => x.Price).ThenBy(x => x.Index).ToList();
            variations.Add(people[0]);
            Person next = people[0];
            while(next != null)
            {
                next = people.Where(x => x.Hours > next.Hours).FirstOrDefault();
                if (next != null) variations.Add(next);
            }

            foreach (var item in variations)
            {
                Console.Write("j" + item.Index + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Maximum profit " + variations.Sum(x => x.Price));
        }
    }
    public class Person
    {
        public Person(int index, int hours, int price)
        {
            this.Index = index;
            this.Hours = hours;
            this.Price = price;
        }

        public int Index { get; set; }
        public int Hours { get; set; }
        public int Price { get; set; }
    }
}