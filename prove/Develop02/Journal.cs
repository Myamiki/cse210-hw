using System;
using System.Collections.Generic;
using System.IO;

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

    // Save journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
            }
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}
