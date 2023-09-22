using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console
{
    public static class ShapeCreator
    {
        
        public  static List<Shape> CreateShapes(Dictionary<ShapeEnum, List<List<double>>> shapePairs)
        {
            var shapes = new List<Shape>();
            foreach (KeyValuePair<ShapeEnum, List<List<double>>> pair in shapePairs)
            {
                var numOfValues = pair.Value.Count;
                for (int i = 0; i < numOfValues; i++)
                {
                    Shape shape = ShapeFactory.CreateShape(pair.Key, pair.Value[i]);
                    shapes.Add(shape);
                }
            }
            return shapes;
        }
    }
}
