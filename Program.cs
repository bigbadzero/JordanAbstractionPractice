// See https://aka.ms/new-console-template for more information
using JordanAbstractionPractice.Console;
using JordanAbstractionPractice.Console.UI;


int numOfShapes = UserInput.GetNumberOfShapes();
Dictionary<ShapeEnum, List<List<double>>> shapePairs = new Dictionary<ShapeEnum, List<List<double>>>();
shapePairs = UserInput.GetShapeParameters(numOfShapes);
List<Shape> shapes = ShapeCreator.CreateShapes(shapePairs);

//for each shape call the printShapeMeasurements method
foreach (var shape in shapes)
{
    shape.PrintShapeMeasurements();
}

