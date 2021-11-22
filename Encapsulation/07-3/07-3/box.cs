using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_3
{
    class box
    {
        public double length;
        public double width;
        public double height;
        public box(double a, double b, double c)
        {
            length = a;
            width = b;
            height = c;
        }

        public void Povyrhnina()
        {
            double Povyrhnina = length * width * 2 + length * height * 2 + width * height * 2;
            Console.WriteLine($"Surface Area – {Povyrhnina:0.00}");
        }


        public void OkolnaPovyrhnina()
        {
            double OkolnaPovyrhnina = length * height * 2 + width * height * 2;
            Console.WriteLine($"Lateral Surface Area  – {OkolnaPovyrhnina:0.00}");
        }


        public void Obem()
        {
            double Obem = length * width * height;
            Console.WriteLine($"Volume – {Obem:0.00}");
        }
    }
}
