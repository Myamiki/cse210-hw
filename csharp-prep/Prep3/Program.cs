using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        Random randomGenerator = new Random(); // Move the Random generator outside the loop

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101); // Generate magic number
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Guess the magic number between 1 and 100!");

            // Game loop
            while (guess != magicNumber) 
            {
                Console.Write("What is your guess? ");
                
                // Input validation
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    attempts++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {attempts} attempts!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Prompt to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
