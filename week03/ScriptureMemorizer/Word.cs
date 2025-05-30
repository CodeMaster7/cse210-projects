using System;

public class Word
{
    // Private field to store the actual word text
    private string _text;
    // Private field to track if this word is hidden or not
    private bool _isHidden;

    // Constructor - takes the word text and sets it as not hidden initially
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // New words start visible
    }

    // Method to hide this word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show this word (in case we want to unhide it)
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if this word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text - shows underscores if hidden, actual text if visible
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create underscores the same length as the original word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
