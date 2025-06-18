using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercise Tracking Program ===");
        Console.WriteLine();

        // POLYMORPHISM DEMONSTRATION
        // Create a list of Activity objects (base class reference)
        // This list can hold ANY type that inherits from Activity!
        List<Activity> activities = new List<Activity>();

        // Add one activity of each type to the SAME list
        // This demonstrates polymorphism - different types in same list
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 30, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 30, 20));

        Console.WriteLine("🎯 POLYMORPHISM IN ACTION:");
        Console.WriteLine("Same list, different activity types, each behaves correctly!");
        Console.WriteLine();

        // Iterate through the list
        // Each activity calls its own version of the methods
        foreach (Activity activity in activities)
        {
            // GetSummary() calls the correct overridden methods for each type
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
        Console.WriteLine("🎉 SUCCESS! Three different classes, same interface, perfect polymorphism!");

        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine("INDIVIDUAL TESTING (for verification):");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        // Individual testing (keeping for verification)
        Console.WriteLine("Testing Running Activity:");
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Console.WriteLine($"Distance: {running.GetDistance():F1} miles");
        Console.WriteLine($"Speed: {running.GetSpeed():F1} mph");
        Console.WriteLine($"Pace: {running.GetPace():F1} min per mile");
        Console.WriteLine(running.GetSummary());

        Console.WriteLine();
        Console.WriteLine("Testing Cycling Activity:");
        Cycling cycling = new Cycling(new DateTime(2022, 11, 4), 30, 15.0);
        Console.WriteLine($"Distance: {cycling.GetDistance():F1} miles");
        Console.WriteLine($"Speed: {cycling.GetSpeed():F1} mph");
        Console.WriteLine($"Pace: {cycling.GetPace():F1} min per mile");
        Console.WriteLine(cycling.GetSummary());

        Console.WriteLine();
        Console.WriteLine("Testing Swimming Activity:");
        Swimming swimming = new Swimming(new DateTime(2022, 11, 5), 30, 20);
        Console.WriteLine($"Laps: 20 (each lap = 50 meters)");
        Console.WriteLine($"Distance: {swimming.GetDistance():F1} miles");
        Console.WriteLine($"Speed: {swimming.GetSpeed():F1} mph");
        Console.WriteLine($"Pace: {swimming.GetPace():F1} min per mile");
        Console.WriteLine(swimming.GetSummary());
    }
}