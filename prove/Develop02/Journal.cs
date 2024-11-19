using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

// Handles journal operations such as adding, displaying, saving, and loading entries
public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // Stores all journal entries

    // Adds a new entry to the journal
    public void AddEntry(string prompt, string response, string mood)
    {
        _entries.Add(new Entry(prompt, response, mood));
    }

    // Displays all entries in the journal
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Saves journal entries to a JSON file
    // Added simplification: Users don't need to decide between file formats
    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(_entries);
        File.WriteAllText(filename, json);
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Loads journal entries from a JSON file
    // Added validation: Ensures only valid data is read
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
        Console.WriteLine($"Journal loaded from {filename}");
    }
}
