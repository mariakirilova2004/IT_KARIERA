using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktni_klasove_05._3
{
    class Circle:Shape
    {
        private int r;

        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public Circle(int r)
        {
            R = r;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.r;
        }

        public override double CalculateArea()
        {
            return Math.PI * this.r * this.r;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
