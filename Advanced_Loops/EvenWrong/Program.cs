using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenWrong
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    int a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0) { Console.WriteLine("Even number entered: {0}", a); break; }
                    else Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }      
            Console.ReadKey();
        }
    }
}
