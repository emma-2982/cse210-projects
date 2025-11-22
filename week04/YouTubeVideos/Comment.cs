using System;

public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public bool MentionsProduct(string productName)
    {
        return Text.Contains(productName, StringComparison.OrdinalIgnoreCase);
    }

    public void Display()
    {
        Console.WriteLine($"- {Author}: {Text}");
    }
}
