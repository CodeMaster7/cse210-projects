using System;

// Derived class for Rectangle - inherits from Shape
public class Rectangle : Shape
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields to store the length and width of the rectangle
    private double _length;
    private double _width;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts color, length, and width, calls base constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override the GetArea method to calculate rectangle area
    // This demonstrates polymorphism - same method name, different implementation
    public override double GetArea()
    {
        // Area of rectangle = length * width
        return _length * _width;
    }
}