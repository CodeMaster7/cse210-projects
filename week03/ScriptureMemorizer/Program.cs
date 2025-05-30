using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. Random Scripture Library: Instead of hardcoding one scripture, created a library
 *    of 5 different scriptures that randomly selects one each run for variety
 * 2. Stretch Challenge: Implemented the bonus requirement to only hide visible words
 *    instead of potentially hiding already hidden words
 */

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS: Using ScriptureLibrary class for random scripture selection
        // instead of hardcoding a single scripture - it gives variety and a better user experience
        // create a library for storing scriptures
        ScriptureLibrary library = new ScriptureLibrary();

        // ADD MORE SCRIPTURES HERE (before starting the game)
        library.AddScripture(new Scripture(
            new Reference("Matthew", 5, 16),
            "Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."
        ));

        // EXCEEDING REQUIREMENTS: Random selection from library of 5 scriptures
        Scripture scripture = library.GetRandomScripture();

        // Show user how many scriptures are in the library
        Console.WriteLine($"Scripture Library has {library.GetCount()} scriptures loaded.");
        Console.WriteLine("Press any key to start memorizing...");
        Console.ReadKey();

        // Main program loop - meets all core requirements
        while (true)
        {
            // Clear the console screen
            Console.Clear();

            // Display the scripture with reference and text
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Empty line for spacing

            // Check if all words are hidden - if so, end the program
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are now hidden. Great job memorizing!");
                break; // Exit the program
            }

            // Prompt user for input
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            // Check if user wants to quit
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Thanks for using Scripture Memorizer!");
                break; // Exit the program
            }

            // EXCEEDING REQUIREMENTS: HideRandomWords() implements the stretch challenge
            // by only selecting from visible words, not already hidden ones
            scripture.HideRandomWords(3); // Hide 3 random words each time
        }
    }
}