using System;
using System.Collections.Generic;

public class ProductTracker
{
    public string ProductName { get; set; }

    public ProductTracker(string productName)
    {
        ProductName = productName;
    }

    public void FindMentions(List<Video> videos)
    {
        foreach (var video in videos)
        {
            if (video.MentionsProduct(ProductName))
            {
                Console.WriteLine($"Product found in video: {video.Title}");
            }
        }
    }
}
