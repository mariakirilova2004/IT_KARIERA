using System;
using System.Text;

namespace Hourse_walk
{ 
    public class MyTry
    {
        public static int N = 5;
        public static int[,] table = new int[N,N];
        internal static void Main(string[] args)
        {
            int K = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    table[i, j] = 0;
                }
            }
            Try(K, new int[] { 0, 0 });
        }
        public static void Try(int K, int[] next)
        {
            table[next[0], next[1]] = K;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (table[i, j] > 0) count++;

                }
            }
 
            if (count == table.Length * table.Length)
            {
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < table.Length; i++)
                {
                    for (int j = 0; j < table.Length; j++)
                    {
                        str.Append(" " + table[i,j]);
                    }
                    str.AppendLine();
                }
                Console.WriteLine(str.ToString());
                return;
            }
            List<int[]> possible = new List<int[]>();
            if (next[0] - 2 >= 0 && next[1] - 1 >= 0) possible.Add(new int[] { next[0] - 2, next[1] - 1 });
            if (next[0] - 2 >= 0 && next[1] + 1 < N) possible.Add(new int[] { next[0] - 2, next[1] + 1 });
            if (next[0] + 1 < N && next[1] - 2 >= 0) possible.Add(new int[] { next[0] + 1, next[1] - 2 });
            if (next[0] - 1 >= 0 && next[1] - 2 >= 0) possible.Add(new int[] { next[0] - 1, next[1] - 2 });
            if (next[0] + 1 < N && next[1] + 2 < N) possible.Add(new int[] { next[0] + 1, next[1] + 2 });
            if (next[0] - 1 >= 0 && next[1] + 2 < N) possible.Add(new int[] { next[0] - 1, next[1] + 2 });
            if (next[0] + 2 < N && next[1] - 1 >= 0) possible.Add(new int[] { next[0] + 2, next[1] - 1 });
            if (next[0] + 2 < N && next[1] + 1 < N) possible.Add(new int[] { next[0] + 2, next[1] + 1 });
           
            count = 0;
            foreach (var position in possible)
            {
                if (table[position[0], position[1]] == 0)
                {
                    Try(K + 1, position);
                    StringBuilder str = new StringBuilder();

                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            str.Append(" " + table[i, j]);
                        }
                        str.AppendLine();
                    }
                    Console.WriteLine(str.ToString());
                    count++;
                }
                else count++;
            }
            if (possible.Count == count)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (table[i, j] == K) table[i, j] = 0;
                    }
                }
                return;
            }
        }
    }
}