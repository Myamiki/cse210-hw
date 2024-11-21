using System;

class Program
{
    static void Main(string[] args)
    {
        // Test default constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Output: 1

        // Test constructor with numerator only
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); // Output: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // Output: 5

        // Test constructor with numerator and denominator
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString()); // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Output: 0.75

        // Test getters and setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine(fraction3.GetFractionString()); // Output: 1/3
        Console.WriteLine(fraction3.GetDecimalValue());   // Output: 0.3333333333333333
    }
}
