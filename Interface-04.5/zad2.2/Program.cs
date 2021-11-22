using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ').ToArray();
            string[] input2 = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < input1.Length; i++)
            {
                Smartphone sm = new Smartphone();
                sm.Calls = input1[i];
                sm.Calling();
            }
            for (int i = 0; i < input2.Length; i++)
            {
                Smartphone sm = new Smartphone();
                sm.Browses = input2[i];
                sm.Browsing();
            }
            Console.ReadKey();
        }
    }
}
