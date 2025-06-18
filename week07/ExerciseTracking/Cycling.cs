using System;

// Derived class for Cycling activities
public class Cycling : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field specific to cycling activities
    private double _speed; // Speed in mph

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts date, minutes, and speed
    // Calls base constructor to set shared fields
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override abstract methods from base class with cycling-specific calculations

    // For cycling, we calculate distance from speed and time
    // Formula: Distance = speed * time (converted to hours)
    // Using GetMinutes() method - explicit method call (academic approach!)
    public override double GetDistance()
    {
        return _speed * (GetMinutes() / 60.0);
    }

    // For cycling, we store speed directly
    public override double GetSpeed()
    {
        return _speed;
    }

    // Pace is the inverse of speed
    // Formula: Pace (min per mile) = 60 / speed
    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    // Custom summary for Cycling activities
    // Shows cycling-specific information and formatting
    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetMinutes()} min) - " +
               $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile 🚴‍♂️";
    }
}