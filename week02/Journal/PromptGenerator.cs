using System;
using System.Collections.Generic;

// Class to generate random prompts for journal entries
public class PromptGenerator
{
    // Member variable to store the list of prompts
    public List<string> _prompts;

    // Constructor to initialize with at least 5 different prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was something new I learned today?",
            "What am I grateful for today?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        // Create a Random object to generate random numbers
        Random random = new Random();

        // Get a random index within the list
        int index = random.Next(_prompts.Count);

        // Return the prompt at the random index
        return _prompts[index];
    }
}