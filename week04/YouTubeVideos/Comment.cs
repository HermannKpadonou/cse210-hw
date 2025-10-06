using System;

public class Comment
{
    public string commenterName;
    public string commentText;

    public Comment(string commenterName, string commentText)
    {
        this.commenterName = commenterName;
        this.commentText = commentText;
    }

    public void Display()
    {
        Console.WriteLine($"- {commenterName}: {commentText}");
    }
}