using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Eternal Quest - Goal Tracking Program ===");
        Console.WriteLine();

        // CREATIVITY FEATURE: Added Achievement Rank System
        // Players earn ranks based on total points: BEGINNER → NOVICE → INTERMEDIATE → ADVANCED → EXPERT → MASTER → LEGEND
        // Displays current rank with player info and celebrates rank-ups when they occur

        // Create goal manager and start the program
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}