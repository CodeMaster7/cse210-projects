using System;
using System.Collections.Generic;

// Derived class for Listing Activity
public class ListingActivity : Activity
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields
    private int _count;
    private List<string> _prompts;

    // ==================== CONSTRUCTORS ====================
    // Constructor calls base constructor and initializes prompt list
    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // Initialize prompts list
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0;
    }

    // ==================== METHODS ====================
    // Run the listing activity
    public void Run()
    {
        DisplayStartingMessage(); // Call base class method

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage(); // Call base class method
    }

    // Display a random prompt from the list
    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");
    }

    // Get list of items from user
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        Console.WriteLine($"Start listing! You have {GetDuration()} seconds:");

                // Continue until overall time is up
        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            // Add the item first if it's valid
            if (!string.IsNullOrEmpty(input))
            {
                items.Add(input);
            }

            // Then check if time is up after they finish typing
            if ((DateTime.Now - startTime).TotalSeconds >= GetDuration())
            {
                Console.WriteLine("Time's up!");
                break;
            }
        }

        return items;
    }
}