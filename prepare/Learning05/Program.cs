using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("blue", 5.0));
        shapes.Add(new Rectangle("green", 6.0, 4.0));
        shapes.Add(new Circle("red", 3.0));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.Color}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
