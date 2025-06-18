using System;

// Derived class for Running activities
public class Running : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field specific to running activities
    private double _distance; // Distance in miles

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts date, minutes, and distance
    // Calls base constructor to set shared fields
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override abstract methods from base class with running-specific calculations

    // For running, we store distance directly
    public override double GetDistance()
    {
        return _distance;
    }

    // Speed = distance / time (converted to hours)
    // Formula: Speed (mph) = (distance / minutes) * 60
    // Using GetMinutes() method - explicit method call (academic approach!)
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Pace = time / distance
    // Formula: Pace (min per mile) = minutes / distance
    // Using GetMinutes() method - explicit method call (academic approach!)
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    // Custom summary for Running activities
    // Shows running-specific information and formatting
    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Running ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile 🏃‍♂️";
    }
}