using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Models
{
    public class MagicNum
    {
        public MagicNum(int num)
        {
            Num = num;
            Nums = new List<int>();
        }

        public int Num { get; set; }
        public List<int> Nums { get; set; }
        public List<int> GenerateNums()
        {
            for (int i = 100000; i < 1000000; i++)
            {
                int NUM = i;
                int num1 = NUM % 10;
                NUM /= 10;
                int num2 = NUM % 10;
                NUM /= 10;
                int num3 = NUM % 10;
                NUM /= 10;
                int num4 = NUM % 10;
                NUM /= 10;
                int num5 = NUM % 10;
                NUM /= 10;
                int num6 = NUM % 10;
                if (num1 * num2 * num3 * num4 * num5 * num6 == Num) Nums.Add(i);
            }
            return Nums;
        }
    }
}
