using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>(2, 1);
            Console.WriteLine(scale.getHeavier());
            Console.ReadKey();
        }
    }
}
