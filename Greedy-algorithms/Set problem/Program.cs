namespace zad4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            List<List<int>> variations = new List<List<int>> ();
            List<List<int>> sets = new List<List<int>>();
            for (int j = 0; j < n; j++)
            {
                List<int> input = Console.ReadLine().Split(',').Select(int.Parse).ToList();
                sets.Add(input);
            }
            sets = sets.OrderByDescending(x => x.Count).ToList();
            int i = 0;
            variations.Add(sets[i]);
            foreach (var num in sets[i])
            {
                universe.Remove(num);
            }
            while (universe.Count > 0 && i < n - 1)
            {
                i++;
                if (!universe.Any(x => sets[i].Contains(x))) continue;
                List<int> curr = sets[i];
                foreach (var num in sets[i])
                {
                    universe.Remove(num);
                }
                variations.Add(curr);
            }

            foreach (var item in variations)
            {
                Console.WriteLine("{" + String.Join(',', item) + "}");
            }
        }
    }
}