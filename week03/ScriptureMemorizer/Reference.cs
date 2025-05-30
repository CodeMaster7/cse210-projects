using System;

public class Reference
{
    // Private fields to store the scripture reference parts
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; // For verse ranges like "John 3:16-17"

    // Constructor for single verse (like "John 3:16")
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Same verse for start and end
    }

    // Constructor for verse range (like "John 3:16-17")
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the formatted reference string
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            // Single verse: "John 3:16"
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Verse range: "John 3:16-17"
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
