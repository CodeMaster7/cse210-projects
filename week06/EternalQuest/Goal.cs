using System;

// Abstract base class for all goals
// Abstract because it contains abstract methods that must be implemented by derived classes
public abstract class Goal
{
    // ==================== PRIVATE VARIABLES ====================
    // Protected fields so derived classes can access them directly
    protected string _shortName;
    protected string _description;
    protected string _points;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts name, description, and points
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // ==================== ABSTRACT METHODS ====================
    // Abstract method to record an event - MUST be implemented in derived classes
    // Returns the points earned from this event
    // No base implementation because each goal type handles events differently
    public abstract int RecordEvent();

    // Abstract method to check if goal is complete - MUST be implemented in derived classes
    // No base implementation because completion logic varies by goal type
    public abstract bool IsComplete();

    // Abstract method to get details as string - MUST be implemented in derived classes
    // No base implementation because each goal type displays differently
    public abstract string GetDetailsString();

    // Abstract method to get string representation - MUST be implemented in derived classes
    // No base implementation because each goal type saves different data
    public abstract string GetStringRepresentation();
}