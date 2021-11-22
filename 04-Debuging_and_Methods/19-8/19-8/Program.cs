using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                GetMax(a, b);
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void GetMax(string a, string b)
        {
            if (Int32.Parse(a) > Int32.Parse(b)) Console.WriteLine(a);
            else Console.WriteLine(b);
        }
        static void GetMax(int a, int b)
        {
            if (a > b) Console.WriteLine(a);
            else Console.WriteLine(b);
        }
        static void GetMax(char a, char b)
        {
            if (a > b) Console.WriteLine(a);
            else Console.WriteLine(b);
        }
    }
}
