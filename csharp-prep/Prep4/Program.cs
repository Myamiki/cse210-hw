using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store user input numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input;

        // Loop to take input until the user enters 0
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine()); // Convert input to an integer

            // Add number to the list if it's not 0
            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0); // Stop loop when user inputs 0

        // Calculate the sum of all numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num; // Add each number to the sum
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average of the numbers
        double average = (double)sum / numbers.Count; // Cast to double for decimal result
        Console.WriteLine($"The average is: {average}");

        // Find the maximum number in the list
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max) // Update max if current number is greater
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge: Find the smallest positive number in the list
        int smallestPositive = int.MaxValue; // Initialize to maximum integer value
        foreach (int num in numbers)
        {
            // Check if the number is positive and less than the current smallest positive
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Sort the list in ascending order and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num); // Display each number after sorting
        }
    }
}
