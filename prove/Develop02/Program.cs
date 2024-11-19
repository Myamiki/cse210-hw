 using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Journal object to handle all journal operations
        PromptGenerator promptGenerator = new PromptGenerator(); // Handles prompt generation

        bool isRunning = true;

        while (isRunning)
        {
            // Display menu options
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Generate a random prompt and collect user input
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Your mood (e.g., Happy, Sad, Excited): ");
                    string mood = Console.ReadLine();
                    journal.AddEntry(prompt, response, mood); // Use Journal method to add entry
                    break;

                case "2":
                    journal.Display(); // Display all journal entries
                    break;

                case "3":
                    Console.Write("Enter filename to save journal (default: journal.json): ");
                    string saveFilename = Console.ReadLine();
                    saveFilename = string.IsNullOrWhiteSpace(saveFilename) ? "journal.json" : saveFilename;
                    journal.SaveToFile(saveFilename); // Save journal to file
                    break;

                case "4":
                    Console.Write("Enter filename to load journal (default: journal.json): ");
                    string loadFilename = Console.ReadLine();
                    loadFilename = string.IsNullOrWhiteSpace(loadFilename) ? "journal.json" : loadFilename;
                    journal.LoadFromFile(loadFilename); // Load journal from file
                    break;

                case "5":
                    isRunning = false; // Exit the application
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
