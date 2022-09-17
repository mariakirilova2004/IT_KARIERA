﻿using System;
namespace SolveHanoyTowers
{
    public class Program
    {
        internal static void Main()
        {
            int numberOfDisks = 5;
            Console.WriteLine("Брой дискове: {0}", numberOfDisks);
            SolveHanoy('A', 'C', 'B', numberOfDisks);
        }
        private static void MoveDisk(int n, char a, char b)
        {
            Console.WriteLine("Преместете диск {0} от {1} на {2}", n, a, b);
        }
        private static void SolveHanoy(char a, char c, char b, int n)
        {
            if (n == 1)
            {
                MoveDisk(1, a, c);
            }
            else
            {
                SolveHanoy(a, b, c, n - 1);
                MoveDisk(n, a, c);
                SolveHanoy(b, c, a, n - 1);
            }
        }
    }
}
