using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();
        // Create videos
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 900);
        Video video3 = new Video("C# Best Practices", "Emily Davis", 1200);
        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        video2.AddComment(new Comment("David", "Excellent tutorial."));
        video2.AddComment(new Comment("Eve", "This was very informative."));
        video2.AddComment(new Comment("Frank", "Well explained."));
        video3.AddComment(new Comment("Grace", "Awesome content!"));
        video3.AddComment(new Comment("Hank", "Thanks for sharing."));
        video3.AddComment(new Comment("Ivy", "This was really useful."));
        // Add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        // Display video details and comments
        foreach (Video video in videos){
            Console.WriteLine(video);
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
            Console.WriteLine();
        }
    }
}