using System;

public class Entry
{
    // Properties of a journal entry
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor to initialize an entry
    public Entry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    // Display entry details
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("------------------------------");
    }
}
