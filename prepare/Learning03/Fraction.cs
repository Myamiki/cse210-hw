using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int _numerator;
    private int _denominator;

    // Constructor that initializes the fraction to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor that takes one parameter (numerator) and sets denominator to 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor that takes two parameters (numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to return fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
