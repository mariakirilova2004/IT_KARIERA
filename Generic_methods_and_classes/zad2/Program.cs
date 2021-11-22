using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> arr = new List<string>();
            for (int i = 0; i < commands; i++)
            {
                string input = Console.ReadLine();
                arr.Add(input);
            }
            ListT<string> listt = new ListT<string>(arr);
            int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            listt.list = listt.Swap(swap[0], swap[1]);
            Console.WriteLine(listt.ToString());
            Console.ReadKey();
        }

    }
}
