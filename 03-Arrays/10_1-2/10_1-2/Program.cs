using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string masiv = Console.ReadLine();
            int[] chisla = masiv.Split().Select(int.Parse).ToArray();
            int[] br = new int[65535];
            int maxInd = br[0];
            int maxNum = 0;
            for(int i = 0; i< chisla.Length; i++)
            {
                br[chisla[i]]++;
            }
            for (int i = 1; i < 65535; i++)
            {
                if (br[i] > maxInd) { maxNum = i; maxInd = br[i]; }
            }
            Console.WriteLine(maxNum);
            Console.ReadKey();
        }
    }
}
