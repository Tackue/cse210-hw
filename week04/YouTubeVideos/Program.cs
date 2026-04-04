using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Build a Gaming PC", "TechWorld", 720);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Brian", "Great explanation."));
        video1.AddComment(new Comment("Cathy", "Make more videos!"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Football Goals", "SportsDaily", 540);
        video2.AddComment(new Comment("Daniel", "Amazing goals!"));
        video2.AddComment(new Comment("Ella", "Loved it."));
        video2.AddComment(new Comment("Frank", "Best compilation."));
        videos.Add(video2);

        Video video3 = new Video("Easy Chocolate Cake Recipe", "HomeKitchen", 360);
        video3.AddComment(new Comment("Grace", "Turned out perfect!"));
        video3.AddComment(new Comment("Henry", "So easy to follow."));
        video3.AddComment(new Comment("Isla", "Great recipe!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine("----------------------------");
        }
    }
}
