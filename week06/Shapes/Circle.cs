using System;

// Derived class for Circle - inherits from Shape
public class Circle : Shape
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field to store the radius of the circle
    private double _radius;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts color and radius, calls base constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override the GetArea method to calculate circle area
    // This demonstrates polymorphism - same method name, different implementation
    public override double GetArea()
    {
        // Area of circle = π * radius²
        // Math.PI provides the value of π (pi)
        return Math.PI * _radius * _radius;
    }
}