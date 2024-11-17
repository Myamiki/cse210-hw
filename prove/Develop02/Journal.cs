using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    // List to store entries
    private List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Display all entries in the journal
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

    // Save journal entries to a CSV file
    public void SaveToCSV(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Response,Mood"); // CSV header
            foreach (var entry in _entries)
            {
                string line = $"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\",\"{entry.Mood}\"";
                writer.WriteLine(line);
            }
        }
        Console.WriteLine($"Journal saved as CSV to {filename}");
    }

    // Load journal entries from a CSV file
    public void LoadFromCSV(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++) // Skip the header row
        {
            string[] parts = lines[i].Split(',');

            if (parts.Length == 4)
            {
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"');
                string response = parts[2].Trim('"');
                string mood = parts[3].Trim('"');

                _entries.Add(new Entry(prompt, response, mood) { Date = date });
            }
        }
        Console.WriteLine($"Journal loaded from CSV file: {filename}");
    }

    // Save journal entries to a JSON file
    public void SaveToJSON(string filename)
    {
        string json = JsonSerializer.Serialize(_entries);
        File.WriteAllText(filename, json);
        Console.WriteLine($"Journal saved as JSON to {filename}");
    }

    // Load journal entries from a JSON file
    public void LoadFromJSON(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
        Console.WriteLine($"Journal loaded from JSON file: {filename}");
    }
}
