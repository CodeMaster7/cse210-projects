using System;

public class Comment
{
    // Private fields - only this class can directly touch these
    private string _commenterName;
    private string _commentText;

    // Getter method for commenter name
    public string GetCommenterName()
    {
        return _commenterName;
    }

    // Setter method for commenter name
    public void SetCommenterName(string commenterName)
    {
        _commenterName = commenterName;
    }

    // Getter method for comment text
    public string GetCommentText()
    {
        return _commentText;
    }

    // Setter method for comment text
    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }
}
