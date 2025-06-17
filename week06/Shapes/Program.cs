using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Shape Area Calculator - Polymorphism Demo ===");
        Console.WriteLine();

        // ==================== INDIVIDUAL TESTING ====================
        Console.WriteLine("Testing individual shapes:");
        Console.WriteLine();

        // Test Square
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        // Test Rectangle
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        // Test Circle
        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");

        Console.WriteLine();
        Console.WriteLine("=== POLYMORPHISM DEMONSTRATION ===");
        Console.WriteLine();

        // ==================== POLYMORPHISM WITH LIST ====================
        // Create a list of Shape objects - this demonstrates polymorphism
        // Store different derived types in the same list
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("Yellow", 4));
        shapes.Add(new Rectangle("Purple", 3, 8));
        shapes.Add(new Circle("Orange", 2.5));
        shapes.Add(new Square("Pink", 6));
        shapes.Add(new Circle("Cyan", 1.5));

        Console.WriteLine("Iterating through list of shapes:");
        Console.WriteLine();

        // Iterate through the list - this shows polymorphism in action
        // Each shape's GetArea() method is called, but the correct implementation
        // is used based on the actual object type (not the reference type)
        foreach (Shape shape in shapes)
        {
            // Calls the appropriate GetArea() method for each shape type
            // Square.GetArea(), Rectangle.GetArea(), or Circle.GetArea()
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }

        Console.WriteLine();
        Console.WriteLine("=== POLYMORPHISM EXPLANATION ===");
        Console.WriteLine("Store different shape types in the same list,");
        Console.WriteLine("each one calculates its area correctly using its own method!");
    }
}