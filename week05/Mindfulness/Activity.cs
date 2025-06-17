using System;
using System.Threading;

// Base class for all mindfulness activities
public class Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields to demonstrate encapsulation
    private string _name;
    private string _description;
    private int _duration;

    // ==================== CONSTRUCTORS ====================
    // Constructor for the base activity class
    public Activity(string name, string description)
    {
        // Set the activity name and description
        _name = name;
        _description = description;
    }

    // ==================== METHODS (GETTERS) ====================
    // Get the duration
    public int GetDuration()
    {
        return _duration;
    }

    // ==================== METHODS ====================
    // Display starting message for all activities
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display ending message for all activities
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    // Show spinner animation
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    // Show countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}