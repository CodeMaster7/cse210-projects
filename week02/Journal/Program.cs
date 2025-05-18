using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of our classes
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // create a variable to keep track of whether the program is running
        bool running = true;

        // Main program loop
        while (running)
        {
            // Display menu
            Console.WriteLine("\n===== Journal Program =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("\nWhat would you like to do? ");

            string choice = Console.ReadLine();

            // Process user choice
            switch (choice)
            {
                case "1":
                    // Get a random prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");

                    // Get title for the entry
                    Console.Write("Enter a title for this entry: ");
                    string title = Console.ReadLine();

                    // Get user's response
                    Console.WriteLine("Enter your response (type 'done' on a new line when finished):");
                    // create a variable to store the user's response
                    string response = "";
                    // create a variable to store the user's input
                    string line;
                    // create a loop to get the user's response
                    do
                    {
                        // get the user's input
                        line = Console.ReadLine();
                        // if the user's input is not "done", add the input to the response
                        if (line.ToLower() != "done")
                        {
                            response += line + "\n";
                        }
                        // if the user's input is "done", exit the loop
                    } while (line.ToLower() != "done");

                    // Create new entry
                    Entry newEntry = new Entry
                    {
                        // create a new entry
                        _date = DateTime.Now.ToShortDateString(),
                        // store the title
                        _title = title,
                        // create a new prompt
                        _promptText = prompt,
                        // create a new entry
                        _entryText = response.TrimEnd()
                    };

                    // Add entry to journal
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case "2":
                    // Display all entries
                    Console.WriteLine("\n===== Journal Entries =====");
                    journal.DisplayAll();
                    break;

                case "3":
                    // Save journal to file
                    Console.Write("\nEnter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    // Load journal from file
                    Console.Write("\nEnter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5":
                    // Exit program
                    running = false;
                    Console.WriteLine("\nThank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}