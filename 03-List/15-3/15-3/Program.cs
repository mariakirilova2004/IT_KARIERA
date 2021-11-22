using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();
            List<int> num = new List<int>();
            foreach(int n in numbers)
            {
                if(n >= 0)
                {
                    num.Add(n);
                }
            }
            num.Reverse();
            int br = 0;
            foreach(int n in num)
            {
                if (n != 0) br++;
                Console.Write($"{n} ");
            } 
            if (br == 0)
            {
                Console.WriteLine("Empty");
            }
            Console.ReadKey();
        }
    }
}
