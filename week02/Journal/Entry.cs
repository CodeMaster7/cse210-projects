using System;

// Class to represent a single journal entry
public class Entry
{
    // Member variables as shown in the UML diagram
    public string _date;         // Stores the date of the entry
    public string _promptText;   // Stores the prompt that was given
    public string _entryText;    // Stores the user's response to the prompt
    public string _title;        // Stores the title of the entry

    // Method to display the entry in a formatted way
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); // Empty line for creating a new line for better readability
    }
}