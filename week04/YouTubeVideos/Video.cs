using System;
using System.Collections.Generic;

public class Video
{
    // Private fields - only this class can directly touch these
    private string _title;
    private string _author;
    private int _length;  // Length in seconds
    private List<Comment> _comments;  // List to hold Comment objects

    // Constructor - runs when a new Video object is created
    public Video(string title, string author, int length)
    {
        _title = title;           // Set title directly
        _author = author;         // Set author directly
        _length = length;         // Set length directly
        _comments = new List<Comment>();  // initialize empty list
    }

    // Getter method for title
    public string GetTitle()
    {
        return _title;
    }

    // Setter method for title
    public void SetTitle(string title)
    {
        _title = title;
    }

    // Getter method for author
    public string GetAuthor()
    {
        return _author;
    }

    // Setter method for author
    public void SetAuthor(string author)
    {
        _author = author;
    }

    // Getter method for length
    public int GetLength()
    {
        return _length;
    }

    // Setter method for length
    public void SetLength(int length)
    {
        _length = length;
    }

    // Method to add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to get all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
