using System;

// Derived class for Square - inherits from Shape
public class Square : Shape
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field to store the side length of the square
    private double _side;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts color and side, calls base constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override the GetArea method to calculate square area
    // This demonstrates polymorphism - same method name, different implementation
    public override double GetArea()
    {
        // Area of square = side * side
        return _side * _side;
    }
}