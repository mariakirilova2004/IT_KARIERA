using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preizpolzvane_na_klasove
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList arr = new RandomList();
            arr.Add("Hello");
            arr.Add("World");
            arr.Add("!");
            arr.Add(";");
            arr.RandomString();
            Console.ReadKey();
        }
    }
}
