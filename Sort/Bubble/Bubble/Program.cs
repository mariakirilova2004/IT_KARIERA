using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            BubbleSort.Sort(input);
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
