using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create individual shape objects
        Square square = new Square("Blue", 4);
        Rectangle rectangle = new Rectangle("Green", 5, 3);
        Circle circle = new Circle("Yellow", 2);

        // Test individual shapes
        Console.WriteLine($"Square Color: {square.Color}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle Color: {rectangle.Color}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.Color}, Area: {circle.GetArea()}");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        // Iterate through the list and display color and area
        Console.WriteLine("\nShapes in the list:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}
