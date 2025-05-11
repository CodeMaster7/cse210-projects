using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");

        // Convert the user's input to an integer
        int gradePercentage = int.Parse(Console.ReadLine());

        // Initialize a variable to store the letter grade
        string letter;

        // Determine the letter grade using if-else statements
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Get the last digit of the grade percentage using the modulo operator (%)
        int lastDigit = gradePercentage % 10;

        // Initialize the sign variable
        string sign = "";

        // Determine the sign based on the last digit
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases
        // 1. There is no A+ grade
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // 2. There is no F+ or F- grade, only F
        if (letter == "F")
        {
            sign = "";
        }

        // Display the letter grade and sign together
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Check if the user passed the course (needs at least 70%)
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Keep studying and you'll do better next time!");
        }
    }
}