using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            object combine = $"{word1} {word2}";
            string word3 = (string)combine;
            Console.WriteLine(word3);
            Console.ReadKey();
        }
    }
}
