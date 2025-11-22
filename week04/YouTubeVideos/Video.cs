using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Channel { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }
    public List<string> Tags { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string channel, int views, int likes, List<string> tags)
    {
        Title = title;
        Channel = channel;
        Views = views;
        Likes = likes;
        Tags = tags;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public bool MentionsProduct(string productName)
    {
        foreach (string tag in Tags)
        {
            if (tag.Contains(productName, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Channel: {Channel}, Views: {Views}, Likes: {Likes}");
        Console.WriteLine("Tags: " + string.Join(", ", Tags));
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
            comment.Display();
        Console.WriteLine();
    }
}
