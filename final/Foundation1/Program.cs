using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "Thanks for sharing.");
        videos.Add(video1);

        Video video2 = new Video("Object-Oriented Programming", "Jane Smith", 720);
        video2.AddComment("Charlie", "Very informative.");
        video2.AddComment("David", "Could use more examples.");
        videos.Add(video2);

        Video video3 = new Video("C# Collections", "Mary Johnson", 480);
        video3.AddComment("Eve", "Helped me a lot.");
        video3.AddComment("Frank", "Well explained.");
        videos.Add(video3);

        
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLengthInSeconds());
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Name: " + comment.GetName());
                Console.WriteLine("Text: " + comment.GetText());
            }

            Console.WriteLine();
        }
    }
}
