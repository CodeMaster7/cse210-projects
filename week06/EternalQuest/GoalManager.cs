using System;
using System.Collections.Generic;
using System.IO;

// GoalManager class - manages all goals and user interactions
public class GoalManager
{
    // ==================== PRIVATE VARIABLES ====================
    // Private fields to manage goals and score
    private List<Goal> _goals;
    private int _score;

    // ==================== CONSTRUCTORS ====================
    // Constructor initializes empty goal list and zero score
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // ==================== METHODS ====================
    // Start the main program loop
    public void Start()
    {
        int choice = 0;

        while (choice != 7)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Show Rank Progression");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    ShowRankProgression();
                    break;
                case 7:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    // Display current player score and achievement rank
    public void DisplayPlayerInfo()
    {
        string rank = GetPlayerRank();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Current Rank: {rank}");
    }

    // CREATIVITY FEATURE: Get player's achievement rank based on total points
    // This motivates users to earn more points and shows their progress
    public string GetPlayerRank()
    {
        if (_score >= 10000) return "🏆 LEGEND";
        if (_score >= 5000) return "⭐ MASTER";
        if (_score >= 2000) return "🥇 EXPERT";
        if (_score >= 1000) return "🥈 ADVANCED";
        if (_score >= 500) return "🥉 INTERMEDIATE";
        if (_score >= 100) return "🌟 NOVICE";
        return "🌱 BEGINNER";
    }

    // CREATIVITY FEATURE: Show rank progression chart to motivate users
    public void ShowRankProgression()
    {
        Console.WriteLine();
        Console.WriteLine("=== ACHIEVEMENT RANK PROGRESSION ===");
        Console.WriteLine();

        string currentRank = GetPlayerRank();

        Console.WriteLine($"🌱 BEGINNER    (0+ points)     {(currentRank == "🌱 BEGINNER" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"🌟 NOVICE      (100+ points)   {(currentRank == "🌟 NOVICE" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"🥉 INTERMEDIATE (500+ points)   {(currentRank == "🥉 INTERMEDIATE" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"🥈 ADVANCED    (1000+ points)  {(currentRank == "🥈 ADVANCED" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"🥇 EXPERT      (2000+ points)  {(currentRank == "🥇 EXPERT" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"⭐ MASTER      (5000+ points)  {(currentRank == "⭐ MASTER" ? "← YOU ARE HERE" : "")}");
        Console.WriteLine($"🏆 LEGEND      (10000+ points) {(currentRank == "🏆 LEGEND" ? "← YOU ARE HERE" : "")}");

        Console.WriteLine();

        // Show points needed for next rank
        if (_score < 100)
            Console.WriteLine($"💪 You need {100 - _score} more points to reach NOVICE rank!");
        else if (_score < 500)
            Console.WriteLine($"💪 You need {500 - _score} more points to reach INTERMEDIATE rank!");
        else if (_score < 1000)
            Console.WriteLine($"💪 You need {1000 - _score} more points to reach ADVANCED rank!");
        else if (_score < 2000)
            Console.WriteLine($"💪 You need {2000 - _score} more points to reach EXPERT rank!");
        else if (_score < 5000)
            Console.WriteLine($"💪 You need {5000 - _score} more points to reach MASTER rank!");
        else if (_score < 10000)
            Console.WriteLine($"💪 You need {10000 - _score} more points to reach LEGEND rank!");
        else
            Console.WriteLine("🎉 Congratulations! You've reached the highest rank!");
    }

    // List all goals with their details
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            // polymorphism - each goal type shows different details
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // List goal names for selection
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Create a new goal based on user input
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch (goalType)
        {
            case 1:
                // Create Simple Goal
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                // Create Eternal Goal
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                // Create Checklist Goal
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    // Record an event for a selected goal
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            // Store old rank to check for rank-up
            string oldRank = GetPlayerRank();

            // polymorphism - each goal type handles events differently
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;

            // Check for rank advancement and celebrate!
            string newRank = GetPlayerRank();
            if (oldRank != newRank)
            {
                Console.WriteLine();
                Console.WriteLine("🎉 RANK UP! 🎉");
                Console.WriteLine($"You've advanced from {oldRank} to {newRank}!");
                Console.WriteLine("Keep up the great work!");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    // Save goals to file
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save score first
            writer.WriteLine(_score);

            // Save each goal's string representation
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    // Load goals from file
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear(); // Clear existing goals

            string[] lines = File.ReadAllLines(filename);

            // First line is the score
            _score = int.Parse(lines[0]);

            // Remaining lines are goals
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string goalType = parts[0];

                switch (goalType)
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                        // Set completion status if saved (don't add points when loading)
                        if (parts.Length > 4 && bool.Parse(parts[4]))
                        {
                            simpleGoal.RecordEvent(); // This will mark it complete but we won't add points
                        }
                        _goals.Add(simpleGoal);
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                        break;

                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3],
                        int.Parse(parts[4]), int.Parse(parts[5]));
                        // Set amount completed if saved (don't add points when loading)
                        if (parts.Length > 6)
                        {
                            int amountCompleted = int.Parse(parts[6]);
                            for (int j = 0; j < amountCompleted; j++)
                            {
                                checklistGoal.RecordEvent(); // Record events to set progress (points already in score)
                            }
                        }
                        _goals.Add(checklistGoal);
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}