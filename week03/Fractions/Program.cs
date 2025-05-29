using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Fraction object
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Testing setters and getters - set new values and verify with getters
        Console.WriteLine("\n--- Testing Setters and Getters ---");

        // Test setting and getting values for f1
        f1.SetTop(1);
        f1.SetBottom(3);

        // Use getters to retrieve and display the values we just set
        Console.WriteLine($"After setting f1 to 1/3:");
        Console.WriteLine($"Top value (using getter): {f1.GetTop()}");
        Console.WriteLine($"Bottom value (using getter): {f1.GetBottom()}");
        Console.WriteLine($"Fraction string: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal value: {f1.GetDecimalValue()}");

        // Test changing values again to verify setters work multiple times
        Console.WriteLine("\n--- Testing Multiple Changes ---");
        f1.SetTop(7);
        f1.SetBottom(8);

        Console.WriteLine($"After changing f1 to 7/8:");
        Console.WriteLine($"Top value (using getter): {f1.GetTop()}");
        Console.WriteLine($"Bottom value (using getter): {f1.GetBottom()}");
        Console.WriteLine($"Fraction string: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal value: {f1.GetDecimalValue()}");

        // Test with different fraction object
        Console.WriteLine("\n--- Testing with f2 ---");
        f2.SetTop(2);
        f2.SetBottom(5);

        Console.WriteLine($"After setting f2 to 2/5:");
        Console.WriteLine($"Top value (using getter): {f2.GetTop()}");
        Console.WriteLine($"Bottom value (using getter): {f2.GetBottom()}");
        Console.WriteLine($"Fraction string: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal value: {f2.GetDecimalValue()}");
    }
}