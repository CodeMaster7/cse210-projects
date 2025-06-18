using System;

// Derived class for Swimming activities
public class Swimming : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field specific to swimming activities
    private int _laps; // Number of laps completed

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts date, minutes, and number of laps
    // Calls base constructor to set shared fields
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // ==================== OVERRIDDEN METHODS ====================
    // Override abstract methods from base class with swimming-specific calculations

    // For swimming, we calculate distance from laps
    // Formula from requirements: Distance (miles) = swimming laps * 50 / 1000 * 0.62
    // Each lap is 50 meters, convert to kilometers, then to miles
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;
    }

    // Speed = distance / time (converted to hours)
    // Formula: Speed (mph) = (distance / minutes) * 60
    // Using GetMinutes() method - explicit method call (academic approach!)
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60;
    }

    // Pace = time / distance
    // Formula: Pace (min per mile) = minutes / distance
    // Using GetMinutes() method - explicit method call (academic approach!)
    public override double GetPace()
    {
        double distance = GetDistance();
        return GetMinutes() / distance;
    }

    // Custom summary for Swimming activities
    // Shows swimming-specific information including lap count!
    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Swimming ({GetMinutes()} min) - " +
               $"{_laps} laps @ 50m each, Distance: {GetDistance():F1} miles, " +
               $"Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile 🏊‍♂️";
    }
}