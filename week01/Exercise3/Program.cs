using System;

class Program
{
    static void Main(string[] args)
    {
        // generate a random number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // Create a variable to track the number of guesses
        int guessCount = 0; // Initialize to 0 before any guesses

        // ask the user for their guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        guessCount++; // Increment for first guess

        // loop until the user guesses the magic number
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++; // Increment count with each new guess
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {guessCount} guesses to guess the magic number.");

        // ask the user if they want to play again
        Console.Write("Do you want to play again? (yes/no) ");
        string playAgain = Console.ReadLine();

        if (playAgain == "yes")
        {
            Main(args);
        }
    }
}