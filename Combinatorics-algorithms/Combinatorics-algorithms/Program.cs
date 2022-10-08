using System;

namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Perm(n));
        }

        public static long Perm(long num)
        {
            if (num == 1) return 1;
            return num * Perm(num - 1);
        }
    }
}