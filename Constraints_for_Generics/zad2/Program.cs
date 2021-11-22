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
            ListT<string> listt = new ListT<string>();
            while(true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                if (commands[0] == "END") break;
                else if (commands[0] == "Add")
                {
                    listt.Add(commands[1]);
                }

                else if (commands[0] == "Remove")
                {
                    listt.Remove(int.Parse(commands[1]));
                }

                else if (commands[0] == "Contains")
                {
                    Console.WriteLine(listt.Contains(commands[1]));
                }

                else if (commands[0] == "Swap")
                {
                    listt.Swap(int.Parse(commands[1]), int.Parse(commands[2]));
                }

                else if (commands[0] == "Greater")
                {
                    Console.WriteLine(listt.CountGreaterThan(commands[1]));
                }

                else if (commands[0] == "Max")
                {
                    Console.WriteLine(listt.Max());
                }

                else if (commands[0] == "Min")
                {
                    Console.WriteLine(listt.Min());
                }

                else if (commands[0] == "Sort")
                {
                    listt = Sorter.Sort(listt);
                }

                else if (commands[0] == "Print")
                {
                    Console.WriteLine(listt.ToString());
                }
            }           
            Console.ReadKey();
        }
    }
}
