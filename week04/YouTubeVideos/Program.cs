using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> Videos = new List<Video>();

        for (int i = 0; i < 4; i++)
        {
            string title = videoTitles[random.Next(videoTitle.Count)];


        }

        List<string> videoTitles = new List<string>
        {
            "BeautyLand by Marie-Hellen Bertino-- Book Review",
            "New Merch! Book-Talk Holiday Restock!",
            "BeautyLand by Marie-Hellen Bertino-- Book Review",
            "Book-Talk: My top Romances of 2024",
            "Shoe Dog by Phil Knight-- Book Review"
        }

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
        }

        Random random = new Random();
        int length = random.Next(30, 601);


    }
}