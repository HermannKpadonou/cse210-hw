using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> shapes = new List<Shapes>();

            Circle circle = new Circle();
            circle.SetRadius(5);
            circle.SetColor("Red");
            shapes.Add(circle);

            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(4);
            rectangle.SetWidth(6);
            rectangle.SetColor("Blue");
            shapes.Add(rectangle);

            Square square = new Square();
            square.SetSideLength(3);
            square.SetColor("Green");
            shapes.Add(square);

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
            }
        }
    }
}