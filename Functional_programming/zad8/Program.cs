using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list1 = list.Where(num => num % 2 == 0).ToList();
            list1.Sort();
            List<int> list2 = list.Where(num => num % 2 != 0).ToList();
            list2.Sort();
            Console.Write(string.Join(" ", list1));
            Console.Write(" ");
            Console.Write(string.Join(" ", list2));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
