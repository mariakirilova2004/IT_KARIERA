using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_3
{
    class box
    {
        private double length;
        public double Length
        {
            get { return length; }
            set 
            {
                if (value < 0) throw new ArgumentException("Length cannot be zero or negative.");
                length = value; 
            }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0) throw new ArgumentException("Width cannot be zero or negative.");
                width = value;
            }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0) throw new ArgumentException("Height cannot be zero or negative.");
                height = value;
            }
        }

        public box(double a, double b, double c)
        {
            Length = a;
            Width = b;
            Height = c;
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
