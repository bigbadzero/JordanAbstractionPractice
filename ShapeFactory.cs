using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console
{
    public static class ShapeFactory
    {
        public static Shape CreateShape(ShapeEnum shapeEnum, List<double> constructors)
        {
            Shape type;
            switch (shapeEnum)
            {
                case ShapeEnum.Circle:
                    type = new Circle(constructors[0]);
                    break;
                case ShapeEnum.Rectangle:
                    type = new Rectangle(constructors[0], constructors[1]);
                    break;
                case ShapeEnum.Triangle:
                    type = new Triangle(constructors[0], constructors[1], constructors[2]);
                    break;
                // Add more cases for other shape types if needed
                default:
                    type = null;
                    break;
            }
            return type;
        }
    }
}

