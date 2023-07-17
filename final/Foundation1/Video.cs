using System;
using System.Collections.Generic;
class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string value)
    {
        title = value;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string value)
    {
        author = value;
    }

    public int GetLengthInSeconds()
    {
        return lengthInSeconds;
    }

    public void SetLengthInSeconds(int value)
    {
        lengthInSeconds = value;
    }

    public Video(string title, string author, int lengthInSeconds)
    {
        SetTitle(title);
        SetAuthor(author);
        SetLengthInSeconds(lengthInSeconds);
        comments = new List<Comment>();
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}