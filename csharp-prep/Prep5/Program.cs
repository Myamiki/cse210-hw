using System;

class Program
{
    static void Main(string[] args)
    {
        // Call DisplayWelcome to show the welcome message
        DisplayWelcome();

        // Call PromptUserName to get the user's name
        string userName = PromptUserName();

        // Call PromptUserNumber to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Call SquareNumber to calculate the square of the favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call DisplayResult to show the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate and return the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the final message with the user's name and squared number
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}
