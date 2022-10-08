using System;

namespace Dividing_into_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ready = new List<List<int>>();
            for (int p = n - 1; p >= 1; p--)
            {
                Divide(p, (p).ToString(), n, 0, p);
            }       
        }
        public static List<List<int>> ready;
        public static void Divide(int p, string sequence, int n, int i, int sum)
        {
            if (sum == n)
            {
                int br = 0;
                foreach (var item in ready)
                {
                    List<int> separated = sequence.Split("+").Select(int.Parse).ToList();
                    if (item.All(x => sequence.Contains(x.ToString())) && separated.Count == item.Count) break;
                    else br++;
                }
                if (br == ready.Count)
                {
                    Console.WriteLine(sequence);
                    ready.Add(sequence.Split("+").Select(int.Parse).ToList());
                    return;
                }
                else return;
            }

            if (sum > n) return;
            
            for (i = n - p - i; i >= 1; i--)
            { 
                Divide(p, sequence + "+" + i, n, i, sum + i);
            }
        }
    }
}