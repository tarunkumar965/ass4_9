using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_9
{
    public enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    public class Geometry
    {
        public static double CalculateArea(ShapeType shape, double[] dimensions)
        {
            switch (shape)
            {
                case ShapeType.Circle:
                    double radius = dimensions[0];
                    return Math.PI * Math.Pow(radius, 2);

                case ShapeType.Square:
                    double side = dimensions[0];
                    return Math.Pow(side, 2);

                case ShapeType.Triangle:
                    double baseLength = dimensions[0];
                    double height = dimensions[1];
                    return 0.5 * baseLength * height;

                default:
                    throw new ArgumentException("Invalid shape type.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dimensions;

        
            dimensions = new double[] { 5 };
            double circleArea = Geometry.CalculateArea(ShapeType.Circle, dimensions);
            Console.WriteLine($"Area of Circle: {circleArea}");

         
            dimensions = new double[] { 4 };
            double squareArea = Geometry.CalculateArea(ShapeType.Square, dimensions);
            Console.WriteLine($"Area of Square: {squareArea}");

           
            dimensions = new double[] { 3, 7 };
            double triangleArea = Geometry.CalculateArea(ShapeType.Triangle, dimensions);
            Console.WriteLine($"Area of Triangle: {triangleArea}");
        }
    }
}
