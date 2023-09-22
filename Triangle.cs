using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console
{
    public class Triangle : Shape
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Name = "Triangle";
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Area()
        {
            double s = (Side1 + Side2 + Side3) / 2; // Semi-perimeter
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
