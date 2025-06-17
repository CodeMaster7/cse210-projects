using System;
using System.Collections.Generic;

// Derived class for Gratitude Activity
public class GratitudeActivity : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields for gratitude prompts
    private List<string> _prompts;

    // ==================== CONSTRUCTORS ====================
    // Constructor calls base constructor and initializes prompt list
    public GratitudeActivity()
        : base("Gratitude Activity", "This activity will help you reflect on the good things in your life by focusing on things you are grateful for.")
    {
        // Initialize gratitude prompts list
        _prompts = new List<string>
        {
            "Think of someone who has helped you recently.",
            "What is something beautiful you saw today?",
            "Think of a skill or talent you are grateful to have.",
            "What is something that made you smile this week?",
            "Think of a place that brings you peace.",
            "What is something about your health you appreciate?",
            "Think of a memory that always makes you happy.",
            "What is something you learned recently that you're thankful for?",
            "Think of a challenge that helped you grow.",
            "What is something simple that you often take for granted?"
        };
    }

    // ==================== METHODS ====================
    // Run the gratitude activity
    public void Run()
    {
        DisplayStartingMessage(); // Call base class method

        Console.WriteLine();
        Console.WriteLine("Focus on each gratitude prompt and take time to really feel thankful.");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;

        // Continue showing prompts until duration is reached
        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            DisplayGratitudePrompt();
            ShowSpinner(8); // Give time to reflect on each prompt
            Console.WriteLine();
        }

        DisplayEndingMessage(); // Call base class method
    }

    // Display a random gratitude prompt
    private void DisplayGratitudePrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"💝 {prompt}");
    }
}