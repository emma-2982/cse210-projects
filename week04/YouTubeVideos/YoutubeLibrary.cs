using System;
using System.Collections.Generic;

public class YouTubeLibrary
{
    public List<Video> Videos { get; set; }

    public YouTubeLibrary()
    {
        Videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        Videos.Add(video);
    }

    public List<Video> FilterByTag(string tag)
    {
        return Videos.FindAll(v => v.Tags.Contains(tag));
    }

    public List<Video> FilterWithProduct(string productName)
    {
        return Videos.FindAll(v => v.MentionsProduct(productName));
    }
}
