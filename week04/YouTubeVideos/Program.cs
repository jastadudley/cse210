using System;
using System.Net;
using System.Reflection;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        List<string> videoTitles = new List<string>
        {
            "BeautyLand by Marie-Hellen Bertino-- Book Review",
            "New Merch! Book-Talk Holiday Restock!",
            "BeautyLand by Marie-Hellen Bertino-- Book Review",
            "Book-Talk: My top Romances of 2024",
            "Shoe Dog by Phil Knight-- Book Review"
        };
        List<string> authors = new List<string>
        {
            "Axel .M",
            "Elise W.",
            "Jamie F.",
            "Julia S.",
            "James A.",
            "Yvonne D.",
            "Haskell D.",
            "Breelin D.",
            "Tamberin D.",
            "Mikayla C.",
            "Anastacia T."
        };
        Random random = new Random();
        int length = random.Next(30, 601);

        for (int i = 0; i < 4; i++)
        {
            string title = videoTitles[random.Next(videoTitles.Count)];
            string author = authors[random.Next(authors.Count)];
            length = random.Next(30, 601);

            Video video = new Video(title, author, length);

            for (int j = 0; j < 3; j++)
            {
                string commenter = authors[random.Next(authors.Count)];
                string commentText = "I was also obsessed witht this newst book!";
                video.AddComment(new Comment(commenter,commentText));
            }
            videos .Add(video);  
        }

        foreach (Video vid in videos)
        {
            vid.DisplayVideoInfo();
        }
    }
}