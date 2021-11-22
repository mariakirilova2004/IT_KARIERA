using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> func = elements => { return elements.Min(); };
            Console.WriteLine(func(list));
            Console.ReadKey();
        }
    }
}
