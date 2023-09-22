using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordanAbstractionPractice.Console.UI
{
    public static class UserInput
    {
        //get input from user for how many shapes we will create
        public static int GetNumberOfShapes()
        {
            System.Console.WriteLine("How many shapes would you like to create");
            string numOfShapesString = System.Console.ReadLine();
            try
            {
                return int.Parse(numOfShapesString);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine (ex.Message);
                throw;
            }
            
        }

        //we ask the user for input each time for however many shapes they wanted to create
        //input needed is the shape and the parameters for that shape
        //then we store the shape  parameters in the dictionary and we will use that data with our factory to create our shapes
        public static Dictionary<ShapeEnum, List<List<double>>> GetShapeParameters(int numOfShapes)
        {
            Dictionary<ShapeEnum, List<List<double>>> shapePairs = new Dictionary<ShapeEnum, List<List<double>>>();
            for (int i = 0; i < numOfShapes; i++)
            {
                //get shape choice aka circle rectangle
                System.Console.WriteLine("For Circle Enter 0 for Rectangle enter 1 for triangle enter 2");
                string input = System.Console.ReadLine();
                int readInput = int.Parse(input);
                //convert input into shapeEnum0
                ShapeEnum shapeEnum = (ShapeEnum)readInput;

                //use shape enum to create the shape
                if (shapeEnum == ShapeEnum.Circle)
                {
                    //create a list to hold the parameters for the shape
                    List<double> paramaters = new List<double>();
                    //get parameters for shape and then add them to the parameters list
                    System.Console.WriteLine("Circle has a parameter requirement for radius. Enter the radius of the circle.");
                    for (int j = 0; j < 1; j++)
                    {
                        string radiusInput = System.Console.ReadLine();
                        int radius = int.Parse(radiusInput);
                        paramaters.Add(radius);
                    }
                    //this logic allows us to handle the dictionary because it can only except one key of the same name
                    //this section is finished by adding the key and values to the dictionary
                    if (shapePairs.ContainsKey(shapeEnum))
                        shapePairs[shapeEnum].Add(paramaters);
                    else
                    {
                        var list = new List<List<double>>();
                        list.Add(paramaters);
                        shapePairs.Add(shapeEnum, list);
                    }

                }
                //same exact process but for rectangle
                else if (shapeEnum == ShapeEnum.Rectangle)
                {
                    List<double> paramaters = new List<double>();
                    System.Console.WriteLine("Rectangle has a parameter  requirement for length and width. Enter the length and width of the rectangle.");
                    for (int j = 0; j < 1; j++)
                    {
                        System.Console.WriteLine("Enter length");
                        string lengthInput = System.Console.ReadLine();
                        int length = int.Parse(lengthInput);
                        paramaters.Add(length);
                        System.Console.WriteLine("Enter width");
                        string widthInput = System.Console.ReadLine();
                        int width = int.Parse(widthInput);
                        paramaters.Add(width);
                    }

                    if (shapePairs.ContainsKey(shapeEnum))
                        shapePairs[shapeEnum].Add(paramaters);
                    else
                    {
                        var list = new List<List<double>>();
                        list.Add(paramaters);
                        shapePairs.Add(shapeEnum, list);
                    }
                }
                else if (shapeEnum == ShapeEnum.Triangle)
                {
                    List<double> paramaters = new List<double>();
                    System.Console.WriteLine("Triangle has a parameter  requirement for side 1 side 2 and side 3. Enter the sides of the triangle.");
                    for (int j = 0; j < 1; j++)
                    {
                        System.Console.WriteLine("Enter side1");
                        string side1Input = System.Console.ReadLine();
                        int side1 = int.Parse(side1Input);
                        paramaters.Add(side1);
                        System.Console.WriteLine("Enter side2");
                        string side2Input = System.Console.ReadLine();
                        int side2 = int.Parse(side2Input);
                        paramaters.Add(side2);
                        System.Console.WriteLine("Enter side3");
                        string side3Input = System.Console.ReadLine();
                        int side3 = int.Parse(side3Input);
                        paramaters.Add(side3);
                    }

                    if (shapePairs.ContainsKey(shapeEnum))
                        shapePairs[shapeEnum].Add(paramaters);
                    else
                    {
                        var list = new List<List<double>>();
                        list.Add(paramaters);
                        shapePairs.Add(shapeEnum, list);
                    }
                }


            }
            return shapePairs;
        }


    }
}
