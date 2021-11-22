using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_To_Farenthait
{
    class Program
    {
        static void Main(string[] args)
        {
            float c = float.Parse(Console.ReadLine());
            float f= 1.8f * c + 32f;
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
