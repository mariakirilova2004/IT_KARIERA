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
            Box_zad2<int> value = new Box_zad2<int>(5);
            Console.WriteLine(value.ToString());
            Console.ReadKey();
        }
    }
}
