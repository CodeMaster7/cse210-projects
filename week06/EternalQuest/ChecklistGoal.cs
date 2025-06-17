using System;

// Derived class for Checklist Goals - must be completed a certain number of times
public class ChecklistGoal : Goal
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields specific to checklist goals
    private int _amountCompleted; // How many times completed so far
    private int _target;          // How many times needed to complete
    private int _bonus;           // Bonus points when fully completed

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts name, description, points, target, and bonus
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override RecordEvent to increment completion and award points/bonus
    public override int RecordEvent()
    {
        _amountCompleted++;
        int points = int.Parse(_points);
        Console.WriteLine($"Congratulations! You have earned {points} points!");

        // Check if goal is now complete and award bonus
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Bonus! You have earned {_bonus} points for completing the goal!");
            return points + _bonus; // Return regular points plus bonus
        }

        return points; // Return just regular points
    }

    // Override IsComplete to check if target has been reached
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override GetDetailsString to show progress
    public override string GetDetailsString()
    {
        // Show [X] if complete, [ ] if incomplete, plus progress
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Override GetStringRepresentation for saving to file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}