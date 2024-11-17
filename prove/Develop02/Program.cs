using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to CSV File");
            Console.WriteLine("4. Load Journal from CSV File");
            Console.WriteLine("5. Save Journal to JSON File");
            Console.WriteLine("6. Load Journal from JSON File");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Random prompt
                    Random random = new Random();
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Your mood (e.g., Happy, Sad, Excited): ");
                    string mood = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response, mood));
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save as CSV: ");
                    string csvFile = Console.ReadLine();
                    journal.SaveToCSV(csvFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load from CSV: ");
                    string loadCsvFile = Console.ReadLine();
                    journal.LoadFromCSV(loadCsvFile);
                    break;

                case "5":
                    Console.Write("Enter filename to save as JSON: ");
                    string jsonFile = Console.ReadLine();
                    journal.SaveToJSON(jsonFile);
                    break;

                case "6":
                    Console.Write("Enter filename to load from JSON: ");
                    string loadJsonFile = Console.ReadLine();
                    journal.LoadFromJSON(loadJsonFile);
                    break;

                case "7":
                    isRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

// Exceeding Requirements:
// 1. Added a mood tracker to each journal entry.
// 2. Enabled saving and loading in both CSV and JSON formats.
// 3. Improved data compatibility with external tools like Excel and JSON readers.
