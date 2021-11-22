using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split().Select(int.Parse).ToList();
            int lastNumber = numbers[numbers.Count - 1];
            List<int> noLastNum = new List<int>();
            foreach(int n in numbers)
            {
                if(n != lastNumber)
                {
                    noLastNum.Add(n);
                }
            }
            foreach(int n in noLastNum)
            {
                Console.Write($"{n} ");
            }
            Console.ReadKey();
        }
    }
}
