using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<int> numbers = str.Split().Select(int.Parse).ToList();
            int br = 0;
            if (numbers.Count == 1)
            {
                Console.WriteLine("1 is already condensed to number");
            }
            else
            {
            for(; ; )
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if(i != numbers.Count-1)
                    {
                       numbers[i] = numbers[i] + numbers[i + 1];
                    }
                    else
                    {
                        numbers.RemoveAt(i);
                        if (i == 1)
                        {
                            br++;
                            break;
                        }
                    }
                }
                if (br == 1) break;
            }
            Console.WriteLine(numbers[0]);

            }
            
            Console.ReadKey();
        }
    }
}
