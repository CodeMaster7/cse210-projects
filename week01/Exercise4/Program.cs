using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> numbers = new List<int>();
        int number = -1; // Initialize to any non-zero value

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop until the user enters 0
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            // Only add the number if it's not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Display the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list.
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}