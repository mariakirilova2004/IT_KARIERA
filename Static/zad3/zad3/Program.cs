using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> ans = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                ans.Add(Square_root.SquareRoot(a));
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
