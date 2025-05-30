using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Class attributes
    private Reference _reference;           // Stores the scripture reference (like John 3:16)
    private List<Word> _words;             // Stores all words in the scripture text

    // Constructor Scripture(Reference reference, string text)
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into individual words and create Word objects
        string[] wordsArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide random word
    public void HideRandomWords(int numberToHide)
    {
        // Get all visible words (not already hidden)
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        // Don't try to hide more words than are available
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        // Create random number generator
        Random random = new Random();

        // Hide the specified number of random words
        for (int i = 0; i < wordsToHide; i++)
        {
            // Pick a random visible word and hide it
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex); // Remove from list so we don't pick it again
        }
    }

    // Method to get display text
    public string GetDisplayText()
    {
        // Start with the reference
        string result = _reference.GetDisplayText() + " ";

        // Add each word's display text (hidden words show as underscores)
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim(); // Remove the extra space at the end
    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        // Return true only if ALL words are hidden
        return _words.All(word => word.IsHidden());
    }
}
