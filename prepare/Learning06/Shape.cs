using System;

public class Shape
{
    // Private member variable for the color
    private string _color;

    // Constructor that accepts the color and sets it
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and Setter for the color
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    // Virtual method for GetArea (to be overridden by derived classes)
    public virtual double GetArea()
    {
        return 0; // Default implementation, returns 0
    }
}
