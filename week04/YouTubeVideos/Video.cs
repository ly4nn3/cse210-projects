using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments;

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public float GetLength()
    {
        return _length;
    }
}