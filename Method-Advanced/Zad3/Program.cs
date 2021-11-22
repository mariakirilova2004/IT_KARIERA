using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            Console.WriteLine(GetMax(a,b));
            Console.ReadKey();
        }
        static int GetMax(int a,int b)
        {
            if (a > b) return a;
            else return b;
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)<0) return a;
            else return b;
        }
        static char GetMax(char a, char b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}
