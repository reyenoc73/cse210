using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Exploring Oaxaca Street Food", "Chef Maria", 540);
        video1.AddComment(new Comment("Ana", "Amazing video! I miss tlayudas."));
        video1.AddComment(new Comment("Luis", "Great quality and delicious dishes!"));
        video1.AddComment(new Comment("Sofia", "I love how you explain each recipe."));

        Video video2 = new Video("Traditional Oaxacan Dishes", "CookingOaxaca", 680);
        video2.AddComment(new Comment("Carlos", "Can’t wait to visit and try this!"));
        video2.AddComment(new Comment("Laura", "Mole negro is my favorite."));
        video2.AddComment(new Comment("Miguel", "You should add subtitles!"));

        Video video3 = new Video("Tour of the Markets in Oaxaca", "TravelWithJess", 720);
        video3.AddComment(new Comment("Emma", "Love the culture and colors!"));
        video3.AddComment(new Comment("Daniel", "Very informative, thank you!"));
        video3.AddComment(new Comment("Nina", "You should do a follow-up!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
