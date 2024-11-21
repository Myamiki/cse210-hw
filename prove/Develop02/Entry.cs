using System;

// Represents a single journal entry
public class Entry
{
    public string Date { get; set; } // Date of the entry
    public string Prompt { get; set; } // Prompt question
    public string Response { get; set; } // User's response
    public string Mood { get; set; } // Mood of the user

    // Constructor to initialize an entry
    public Entry(string prompt, string response, string mood)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    // Displays the entry details in a user-friendly format
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine("------------------------------");
    }
}
