using System;

// CREATIVITY ADDITION: Added a new GratitudeActivity class that shows random gratitude prompts
// to help users reflect on positive things in their life. This demonstrates inheritance by
// extending the Activity base class with the same structure as other activities.
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        // Main menu loop
        while (choice != 5)
        {
            // Display menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            // Process menu choice
            switch (choice)
            {
                case 1:
                    // Create and run breathing activity
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    // Create and run reflecting activity
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case 3:
                    // Create and run listing activity
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case 4:
                    // Create and run gratitude activity
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}