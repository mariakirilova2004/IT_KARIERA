using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_on_time_exam.Views
{
    public class Display
    {
        public int hourEx { get; set; }
        public int minEx { get; set; }
        public int hourAr { get; set; }
        public int minAr { get; set; }

        public string Rez;

        public Display()
        {
            this.hourEx = 0;
            this.minEx = 0;
            this.hourAr = 0;
            this.minAr = 0;
            GetValues();
        }

        public void GetValues()
        {
            hourEx = int.Parse(Console.ReadLine());
            minEx = int.Parse(Console.ReadLine());
            hourAr = int.Parse(Console.ReadLine());
            minAr = int.Parse(Console.ReadLine());
        }

        public void GetRez()
        {
            Console.WriteLine(Rez);
        }
    }
}
