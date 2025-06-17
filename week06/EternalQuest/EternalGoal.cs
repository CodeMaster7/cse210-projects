using System;

// Derived class for Eternal Goals - never complete, always give points
public class EternalGoal : Goal
{
    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts name, description, and points, calls base constructor
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        // Eternal goals don't need additional fields - they're never complete
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override RecordEvent to always award points (never complete)
    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }

    // Override IsComplete - eternal goals are never complete
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    // Override GetDetailsString to show it's never complete
    public override string GetDetailsString()
    {
        // Eternal goals always show [ ] because they're never complete
        return $"[ ] {_shortName} ({_description})";
    }

    // Override GetStringRepresentation for saving to file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}