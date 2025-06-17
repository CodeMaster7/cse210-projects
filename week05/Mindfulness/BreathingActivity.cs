using System;
using System.Threading;

// Derived class for Breathing Activity
public class BreathingActivity : Activity
{
    // ==================== CONSTRUCTORS ====================
    // Constructor calls base constructor with activity-specific information
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // ==================== METHODS ====================
    // Run the breathing activity
    public void Run()
    {
        DisplayStartingMessage(); // Call base class method

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        bool breatheIn = true;

        // Continue until duration is reached
        while ((DateTime.Now - startTime).TotalSeconds < GetDuration())
        {
            if (breatheIn)
            {
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();
            }
            else
            {
                Console.Write("Now breathe out...");
                ShowCountDown(6);
                Console.WriteLine();
            }

            breatheIn = !breatheIn; // Alternate between breathe in and out
        }

        DisplayEndingMessage(); // Call base class method
    }
}