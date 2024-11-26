using System;
using System.Collections.Generic;
using System.Linq;

/*Summary
This block defines a class called Reference that stores:
Book: The book name (e.g., "John").
Chapter: The chapter number (e.g., 3).
StartVerse: The starting verse number (e.g., 16).
EndVerse: The ending verse number, if there is one (e.g., 6 for a range or null for a single verse). */
class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

/*Constructor for a single verse
The Reference constructor is called.
The book parameter gets the value "John".
The chapter parameter gets the value 3.
The startVerse parameter gets the value 16. */

    public Reference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }

/* Constructor for a range of verses
The Reference constructor is called.
The book parameter gets the value "Proverbs".
The chapter parameter gets the value 3.
The startVerse parameter gets the value 5.
The endVerse parameter gets the value 6. */
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

/*The ToString method converts a Reference object into a readable format:
If EndVerse has a value (e.g., 6), it returns a range like "Proverbs 3:5-6".
If EndVerse is null, it returns a single verse like "John 3:16".*/
    public override string ToString()
    {
        return EndVerse.HasValue
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" 
            : $"{Book} {Chapter}:{StartVerse}"; 
    }
}

/* Word Class: Represents an individual word in the scripture
Text: Stores the word itself and allows others to read it but not change it.
IsHidden: Tracks if the word is hidden. Others can see its status but cannot directly modify it.
The constructor initializes the word with its text and makes it visible by default.*/
class Word
{
    public string Text { get; private set; } // Stores the word text
    public bool IsHidden { get; private set; } // Tracks whether the word is hidden

    public Word(string text)
    {
        Text = text;
        IsHidden = false; // Words are visible by default
    }

    // Hide the word (replaces it with underscores) by changing the IsHidden property to true.
    public void Hide()
    {
        IsHidden = true;
    }

    // Reveal the word by setting the IsHidden property back to false.
    public void Reveal()
    {
        IsHidden = false;
    }

/* 
Checks the IsHidden property:
If true, it returns underscores matching the word's length.
If false, it returns the original word text.*/
    public string Display()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

// Scripture Class: Represents a full scripture with its reference and text
class Scripture
{
    public Reference ScriptureReference { get; private set; } // Stores the scripture's reference
    public List<Word> Words { get; private set; } // Stores the scripture text as a list of words

    // Constructor: Initializes the reference and splits the text into words
    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Randomly hides a specified number of visible words
    public void HideRandomWords(int count = 3)
    {
        var visibleWords = Words.Where(word => !word.IsHidden).ToList(); // Get visible words
        if (visibleWords.Count > 0)
        {
            var random = new Random();
            var wordsToHide = visibleWords.OrderBy(x => random.Next()).Take(count); // Randomly select words

            foreach (var word in wordsToHide)
            {
                word.Hide();
            }
        }
    }

    // Checks if all words are hidden
    public bool AreAllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    // Displays the scripture with the reference and hidden words
    public string Display()
    {
        var scriptureText = string.Join(" ", Words.Select(word => word.Display()));
        return $"{ScriptureReference}\n{scriptureText}";
    }
}

// Main Program Class: Handles user interaction and program logic
class Program
{
    static void Main()
    {
        // Load the scripture library
        var scriptures = LoadScriptures();

        // Select a random scripture
        var scripture = GetRandomScripture(scriptures);

        // Main program loop
        while (!scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("\nOptions:");
            Console.WriteLine("Press Enter to hide words.");
            Console.WriteLine("Type 'hint' to reveal a word.");
            Console.WriteLine("Type 'quit' to exit.");

            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (input == "hint")
            {
                RevealHint(scripture);
            }
            else
            {
                scripture.HideRandomWords(); // Hide words on pressing Enter
            }
        }

        // Display a congratulatory message when all words are hidden
        if (scripture.AreAllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine("\nCongratulations! You have memorized the scripture.");
        }
    }

    // Load a list of scriptures for the library
    static List<Scripture> LoadScriptures()
    {
        return new List<Scripture>
        {
            // Add scriptures with a single verse
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want."),
            
            // Add scriptures with multiple verses
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Romans", 8, 38, 39), "For I am convinced that neither death nor life, neither angels nor demons, neither the present nor the future, nor any powers, neither height nor depth, nor anything else in all creation, will be able to separate us from the love of God that is in Christ Jesus our Lord."),
            new Scripture(new Reference("Philippians", 4, 6, 7), "Do not be anxious about anything, but in every situation, by prayer and petition, with thanksgiving, present your requests to God. And the peace of God, which transcends all understanding, will guard your hearts and your minds in Christ Jesus.")
        };
    }

    // Select a random scripture from the library
    static Scripture GetRandomScripture(List<Scripture> scriptures)
    {
        var random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }

    // Reveal one hidden word as a hint
    static void RevealHint(Scripture scripture)
    {
        var hiddenWords = scripture.Words.Where(word => word.IsHidden).ToList(); // Get hidden words
        if (hiddenWords.Count > 0)
        {
            var random = new Random();
            var wordToReveal = hiddenWords[random.Next(hiddenWords.Count)]; // Select a random hidden word
            wordToReveal.Reveal();
        }
        else
        {
            Console.WriteLine("No hidden words to reveal!"); // Handle case where no words are hidden
        }
    }
}
