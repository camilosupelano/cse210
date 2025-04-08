using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 7);
        Shape rectangle = new Rectangle("Green", 8, 12);
        Shape circle = new Circle("Blue", 6);

        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}