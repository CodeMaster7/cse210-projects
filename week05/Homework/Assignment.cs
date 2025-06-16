using System;

// Base class for all assignments
public class Assignment
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields to demonstrate encapsulation
    private string _studentName;
    private string _topic;

    // ==================== CONSTRUCTORS ====================
    // Public constructor allows creating Assignment objects directly
    public Assignment(string studentName, string topic)
    {
        // Set the student name and topic
        _studentName = studentName;
        _topic = topic;
    }

    // ==================== METHODS (GETTERS) ====================
    // Derived classes can use these to access parent class data
    // Get the student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Get the topic
    public string GetTopic()
    {
        return _topic;
    }

    // Get the summary
    public string GetSummary()
    {
        return $"{_studentName}: {_topic}";
    }
}