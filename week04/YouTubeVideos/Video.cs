using System;

public class Video
{
    public string title;
    public string author;
    public int lengthInSeconds;
    public List<Comment> comments = new List<Comment>();


    public Video(string title, string author, int lengthInSeconds)
    {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length (seconds): {lengthInSeconds}");
        Console.WriteLine($"Number of Comments: {comments.Count}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            comment.Display();
        }
    }
}