using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        {
            YouTubeLibrary library = new YouTubeLibrary();

            Video video1 = new Video("C# Tutorial", "DevChannel", 10000, 500, new List<string> { "C#", "Programming" });
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "I like the C# examples."));

            Video video2 = new Video("Product Review", "TechGuru", 20000, 1200, new List<string> { "Review", "Laptop" });
            video2.AddComment(new Comment("Charlie", "Does it mention the product?"));

            library.AddVideo(video1);
            library.AddVideo(video2);

            ProductTracker tracker = new ProductTracker("C#");
            tracker.FindMentions(library.Videos);

            Console.WriteLine("\nAll videos in library:");
            foreach (var v in library.Videos)
            {
                v.DisplayInfo();
            }
        }
    }

}
