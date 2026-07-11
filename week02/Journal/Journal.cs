// The Journal class stores all journal entries.
// It can add entries, display them, save them to a file,
// and load them from a file.

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
    // Member Variables
    // Stores all journal entries in a list.
    private List<Entry> _entries = new List<Entry>();
    // Methods
    // Adds a new journal entry to the list.
    internal void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays every journal entry.
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all journal entries to a text file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}");
            }
        }

        Console.WriteLine("\nJournal saved successfully!\n");
    }

    // Loads journal entries from a text file.
    public void LoadFromFile(string filename)
    {
        // Remove old entries before loading.
        _entries.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine("\nFile not found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }

        Console.WriteLine("\nJournal loaded successfully!\n");
    }
}