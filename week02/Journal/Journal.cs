using System;
using System.Collections.Generic;
using System.IO;

// Class to manage a collection of journal entries
public class Journal
{
    // Member variable to store the list of entries
    public List<Entry> _entries;

    // Constructor to initialize the entries list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        // Check if journal is empty
        if (_entries.Count == 0)
        {
            Console.WriteLine("Journal is empty. Add some entries first!");
            return;
        }

        // Loop through and display each entry
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save the journal to a file
    public void SaveToFile(string file)
    {
        try
        {
            // Create a StreamWriter to write to the file
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                // Write each entry to the file with a separator
                foreach (Entry entry in _entries)
                {
                    // Using ~|~ as a separator that's unlikely to appear in content
                    outputFile.WriteLine($"{entry._date}~|~{entry._title}~|~{entry._promptText}~|~{entry._entryText}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    // Method to load the journal from a file
    public void LoadFromFile(string file)
    {
        try
        {
            // Check if file exists
            if (!File.Exists(file))
            {
                Console.WriteLine("File not found!");
                return;
            }

            // Clear current entries
            _entries.Clear();

            // Read all lines from the file
            string[] lines = File.ReadAllLines(file);

            // Process each line
            foreach (string line in lines)
            {
                // Split the line using our separator
                string[] parts = line.Split("~|~");

                // Check if the file has all 4 parts of the entry
                if (parts.Length >= 4)
                {
                    // Create a new entry from the file data
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _title = parts[1],
                        _promptText = parts[2],
                        _entryText = parts[3]
                    };

                    // Add the entry to our list
                    _entries.Add(entry);
                }
                // Handle older file format without titles (for backward compatibility)
                else if (parts.Length == 3)
                {
                    // Create a new entry from the file data
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _title = "[No Title]", // Default title for older entries
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };

                    // Add the entry to our list
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Number of entries loaded: {_entries.Count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}