using System;

namespace Paths_in_maze 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[][] table = new string[n[0]][];
            int[] Eposition = new int[2];
            int[] curr = new int[2];
            curr[0] = 0; curr[1] = 0;
            for (int i = 0; i < n[0]; i++)
            {
                table[i] = new string[n[1]];
            }

            for (int i = 0; i < n[0]; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    table[i][j] = input[j].ToString();
                    if (input[j] == 'e')
                    {
                        Eposition[0] = i;
                        Eposition[1] = j;
                    }
                }
            }

            List<int[]> done = new List<int[]>();
            done.Add(new int[] { 0, 0 });
            Try(table, Eposition, curr, "", done);
        }

        static void Try(string[][] table, int[] Eposition, int[] curr, string locations, List<int[]> done)
        {
            int[] X = new int[] { -1, +1, 0, 0};
            int[] Y = new int[] { 0, 0, -1, +1};
            string[] loc = new string[] { "U", "D", "L", "R" };
            if (curr[0] == Eposition[0] && curr[1] == Eposition[1])
            {
                Console.WriteLine(String.Join(String.Empty, locations));
                return;
            }

            int br = 0;
            List<Dictionary<int[], string>> poss = new List<Dictionary<int[], string>>();
            for (int i = 0; i < X.Length; i++)
            {
                if (curr[0] + X[i] >= 0 && curr[0] + X[i] < table.Length && curr[1] + Y[i] >= 0 && curr[1] + Y[i] < table[curr[0]].Length && !table[curr[0] + X[i]][curr[1] + Y[i]].Contains('*') && done.Find(x => (x[0] == curr[0] + X[i] && x[1] == curr[1] + Y[i])) == null)
                {
                    poss.Add(new Dictionary<int[], string>());
                    poss.Last().Add(new int[] { X[i], Y[i]}, loc[i]);
                }
                else br++;
            }
            if (br == 4) return;
            else
            {
                foreach (var item in poss)
                {
                    List<int[]> newDone = new List<int[]>();
                    for (int i = 0; i < done.Count; i++)
                    {
                        newDone.Add(new int[done[i].Length]);
                        for (int j = 0; j < done[i].Length; j++)
                        {
                            newDone[i][j] = done[i][j];
                        }
                    }
                    newDone.Add(new int[] { curr[0] + item.Last().Key[0], curr[1] + item.Last().Key[1] });
                    Try(table, Eposition, new int[] { curr[0] + item.Last().Key[0], curr[1] + item.Last().Key[1] }, locations + item.Last().Value, newDone);
                }
            }
        }
    }
}