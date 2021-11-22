using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] charArray = word.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int rez = charArray[i] - 'a';
                Console.WriteLine($"{charArray[i]} -> {rez}");
            }
            Console.ReadKey();
        }
    }
}
