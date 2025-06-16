using System;

// Derived class for Mathematics assignments
public class MathAssignment : Assignment
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields
    private string _textbookSection;
    private string _problems;

    // ==================== CONSTRUCTORS ====================
    // Constructor takes 4 parameters and passes 2 to the parent constructor
    // This demonstrates constructor chaining in inheritance
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Calls Assignment constructor
    {
        // Set the fields specific to math assignments
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // ==================== METHODS ====================
    // Method specific to mathematics assignments
    // Returns a formatted string showing what homework to complete
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}