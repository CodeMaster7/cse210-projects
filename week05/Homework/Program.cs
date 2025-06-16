using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a basic Assignment object
        Assignment assignment1 = new Assignment("Emma Thompson", "Biology");
        Console.WriteLine(assignment1.GetSummary());

        // add a new line
        Console.WriteLine();

        // Create a MathAssignment object
        MathAssignment mathWork = new MathAssignment("Alex Rodriguez", "Algebra", "12.5", "5-15, 22-28");
        Console.WriteLine(mathWork.GetSummary());
        Console.WriteLine(mathWork.GetHomeworkList());

        // add a new line
        Console.WriteLine();

        // Create a WritingAssignment object
        WritingAssignment englishWork = new WritingAssignment("Sarah Mitchell", "English Literature", "The Impact of Social Media on Modern Communication");
        Console.WriteLine(englishWork.GetSummary());
        Console.WriteLine(englishWork.GetWritingInformation());
    }
}