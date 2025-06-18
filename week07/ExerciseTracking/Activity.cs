using System;

// Base class for all exercise activities - demonstrates inheritance and polymorphism
public abstract class Activity
{
    // ==================== PRIVATE FIELDS (ACADEMIC APPROACH) ====================
    // Private fields - proper encapsulation, only accessible through methods
    private DateTime _date;
    private int _minutes;

    // ==================== CONSTRUCTORS ====================
    // Constructor that accepts date and minutes (shared by all activities)
    public Activity(DateTime date, int minutes)
    {
        SetDate(date);
        SetMinutes(minutes);
    }

    // ==================== GETTER METHODS (PROPER PROTECTED ACCESS) ====================
    // Protected getter methods - only Activity family can access
    protected DateTime GetDate()
    {
        return _date;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    // ==================== PRIVATE SETTER METHODS ====================
    // Private setters - only this base class can modify these values
    // This ensures data integrity and proper encapsulation
    private void SetDate(DateTime date)
    {
        _date = date;
    }

    private void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    // ==================== ABSTRACT METHODS ====================
    // Abstract methods that MUST be implemented by derived classes
    // Each activity type calculates these differently

    // Get the distance traveled (miles or kilometers)
    public abstract double GetDistance();

    // Get the speed (mph or kph)
    public abstract double GetSpeed();

    // Get the pace (minutes per mile or minutes per km)
    public abstract double GetPace();

    // Get a formatted summary of the activity
    // Each activity type can customize its own summary format!
    public abstract string GetSummary();
}