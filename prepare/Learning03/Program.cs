using System;


class Program
{
    static void Main()
    {
        // Create fractions using all three constructors
        Fraction fraction1 = new Fraction();           // Default: 1/1
        Fraction fraction2 = new Fraction(6);          // 6/1
        Fraction fraction3 = new Fraction(6, 7);       // 6/7

        // Display the results
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");  // Output: 1/1

        Console.WriteLine($"Fraction 1 decimal: {fraction3.GetDecimalValue()}");

        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");  // Output: 6/1

    }
}