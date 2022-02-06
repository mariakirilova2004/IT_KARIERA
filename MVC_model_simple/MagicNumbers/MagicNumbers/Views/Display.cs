using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Views
{
    public class Display
    {
        public Display()
        {
            GetValues();
        }

        public int MagicNum { get; set; }
        public List<int> MagicNums { get; set; }
        public void GetValues()
        {
            MagicNum = int.Parse(Console.ReadLine());
        }
        public void GetRez()
        {
            Console.WriteLine(String.Join(" ", MagicNums));
        }
    }
}
