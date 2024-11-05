using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        // Create a variable to store the letter grade
        string letter = "";
        string sign = ""; // To store the "+" or "-" sign

        // Determine the letter grade
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

        // Only add "+" or "-" for B, C, and D grades (A+ does not exist, F+ and F- do not exist)
        if (letter != "A" && letter != "F")
        {
            int lastDigit = gradePercentage % 10; // Get the last digit of the percentage

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Print the letter grade with sign (if applicable)
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying and you'll do better next time.");
        }
    }
}
