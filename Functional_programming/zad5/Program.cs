using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<int, int> add = num => { return num += 1; };
            Func<int, int> multiply = num => { return num *= 2; };
            Func<int, int> substract = num => { return num -= 1; };
            Action<int> print = num => Console.Write(num + " ");
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }
                else if(command == "add")
                {
                    for(int i = 0; i < list.Count; i++)
                    {
                        list[i] = add(list[i]);
                    }
                }
                else if (command == "multiply")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = multiply(list[i]);
                    }
                }
                else if (command == "substract")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i] = substract(list[i]);
                    }
                }
                else if (command == "print")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        print(list[i]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
