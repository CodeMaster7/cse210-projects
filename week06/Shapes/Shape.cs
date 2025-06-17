using System;

// Abstract base class for all shapes - demonstrates inheritance and polymorphism
// Abstract class because it contains abstract methods that must be implemented by derived classes
public abstract class Shape
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field to store the color of the shape
    private string _color;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts the color and sets it
    public Shape(string color)
    {
        _color = color;
    }

    // ==================== METHODS (GETTERS/SETTERS) ====================
    // Get the color of the shape
    public string GetColor()
    {
        return _color;
    }

    // Set the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }

    // ==================== ABSTRACT METHODS ====================
    // Abstract method to get area - MUST be implemented in derived classes
    // No default implementation because it doesn't make sense for a generic "shape"
    // This demonstrates polymorphism - same method signature, different implementations
    public abstract double GetArea();
}