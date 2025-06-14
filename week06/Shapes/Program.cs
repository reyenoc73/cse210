using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Getcolor()}, Area: {shape.Getarea()}");
        }

        Square square = new Square("Red", 5);
        Console.WriteLine($"Color: {square.Getcolor()}");
        Console.WriteLine($"Area:{square.Getarea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Color: {rectangle.Getcolor()}");
        Console.WriteLine($"Area: {rectangle.Getarea()}");

        Circle circle = new Circle("Yellow", 3);
        Console.WriteLine($"Color: {circle.Getcolor()}");
        Console.WriteLine($"Area:{circle.Getarea()}");
    }
}