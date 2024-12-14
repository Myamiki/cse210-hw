using System;

public class Square : Shape
{
    // Private member variable for the side length
    private double _side;

    // Constructor that accepts the color and side length, calls the base constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea() method to calculate the area of the square
    public override double GetArea()
    {
        return _side * _side; // Area = side^2
    }
}
