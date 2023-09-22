using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console
{
    public abstract class Shape : IShape
    {
        protected string Name { get; set; }
        public abstract double Area();

        public abstract double Perimeter();

        public  void PrintShapeMeasurements()
        {
            System.Console.WriteLine($"The Area of this {Name} is {Area()} and the Perimeter is {Perimeter()}");
        }
    }
}
