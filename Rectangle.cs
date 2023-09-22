using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console
{
    public class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
            Name = "Rectangle";
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
