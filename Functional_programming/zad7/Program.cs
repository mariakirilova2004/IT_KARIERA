using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = int.Parse(Console.ReadLine());
            List<string> list = Console.ReadLine().Split().ToList();
            list = list.Where(name => name.Length <= command).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
