using System;

// Derived class for Simple Goals - can be completed once
public class SimpleGoal : Goal
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field to track if this goal is complete
    private bool _isComplete;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts name, description, and points, calls base constructor
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false; // Start as incomplete
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override RecordEvent to mark goal as complete and award points
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            int points = int.Parse(_points);
            Console.WriteLine($"Congratulations! You have earned {points} points!");
            return points;
        }
        else
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
    }

    // Override IsComplete to return the completion status
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override GetDetailsString to show completion status with checkbox
    public override string GetDetailsString()
    {
        // Show [X] if complete, [ ] if incomplete
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    // Override GetStringRepresentation for saving to file
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}