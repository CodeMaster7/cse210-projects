using System;

// Derived class for English/Writing assignments
// Shows how to extend base class functionality with writing-specific features
public class WritingAssignment : Assignment
{
    // ==================== PRIVATE VARIABLES ====================
    // Private field
    private string _title;

    // ==================== CONSTRUCTORS ====================
    // Constructor accepts 3 parameters and forwards 2 to the parent class
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Calls parent constructor
    {
        // Set the title
        _title = title;
    }

    // ==================== METHODS ====================
    // Get the writing information
    public string GetWritingInformation()
    {
        // Must use getter method because _studentName is private in parent class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}