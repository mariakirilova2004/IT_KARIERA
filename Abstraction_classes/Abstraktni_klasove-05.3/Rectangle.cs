using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktni_klasove_05._3
{
    class Rectangle:Shape
    {
        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 2 + this.Height * 2;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height; 
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
