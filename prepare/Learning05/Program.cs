using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 2);
        Circle circle = new Circle("blue", 2);
        Rectangle rectangle = new Rectangle("green", 2, 3);

        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }

    }
}