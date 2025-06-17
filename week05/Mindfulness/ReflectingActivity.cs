using System;
using System.Collections.Generic;

// Derived class for Reflecting Activity
public class ReflectingActivity : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields
    private List<string> _prompts;
    private List<string> _questions;

    // ==================== CONSTRUCTORS ====================
    // Constructor calls base constructor and initializes prompt lists
    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Initialize prompts list
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize questions list
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // ==================== METHODS ====================
    // Run the reflecting activity
    public void Run()
    {
        DisplayStartingMessage(); // Call base class method

        Console.WriteLine();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;

        // Continue until duration is reached
        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            DisplayQuestion();
            ShowSpinner(15); // Give time to think about each question
        }

        DisplayEndingMessage(); // Call base class method
    }

    // Get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    // Get a random question from the list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    // Display a random prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    // Display a random question
    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()}");
    }
}