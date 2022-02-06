using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.Views
{
    public class Display
    {
        public Display()
        {
            V = 0;
            P1 = 0;
            P2 = 0;
            N = 0;
            GetValues();
        }
        public int V { get; set; }
        public int P1 { get; set; }
        public int P2 { get; set; }
        public float N { get; set; }
        public string Rez { get; set; }

        public void GetValues()
        {
            V = int.Parse(Console.ReadLine());
            P1 = int.Parse(Console.ReadLine());
            P2 = int.Parse(Console.ReadLine());
            N = float.Parse(Console.ReadLine());
        }

        public void GetRez()
        {
            Console.WriteLine(Rez);
        }
    }
}
