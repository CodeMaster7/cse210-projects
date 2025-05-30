using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    // Private field to store our scripture collection
    private List<Scripture> _scriptures;
    private Random _random;

    // Constructor - sets up the library with scriptures
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScriptures(); // Load all our scriptures when library is created
    }

    // Private method to load all scriptures into the library
    private void LoadScriptures()
    {
        // Add all our scriptures to the library
        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        ));

        _scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Joshua", 1, 9),
            "Have I not commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."
        ));
    }

    // Public method to get a random scripture
    public Scripture GetRandomScripture()
    {
        int randomIndex = _random.Next(_scriptures.Count);
        return _scriptures[randomIndex];
    }

    // Public method to get the total number of scriptures
    public int GetCount()
    {
        return _scriptures.Count;
    }

    // Public method to add a new scripture (for adding more scriptures)
    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
}