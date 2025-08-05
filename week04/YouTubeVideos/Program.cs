using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videos = new List<Video>();

        // --------------------------------------------------
        // Video 1
        // --------------------------------------------------
        Video video1 = new Video("Introduction to C#", "CodeGuru", 1200);
        video1.AddComment(new Comment("Alice", "Great tutorial, very clear explanations!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot with my project. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a video about polymorphism next?"));
        video1.AddComment(new Comment("David", "Fantastic content!"));

        videos.Add(video1);

        // --------------------------------------------------
        // Video 2
        // --------------------------------------------------
        Video video2 = new Video("Advanced Class Design", "Programming Hub", 950);
        video2.AddComment(new Comment("Eve", "The examples were really helpful."));
        video2.AddComment(new Comment("Frank", "Wow, I learned something new about encapsulation."));
        video2.AddComment(new Comment("Grace", "Well-paced and easy to follow."));

        videos.Add(video2);
        
        // --------------------------------------------------
        // Video 3
        // --------------------------------------------------
        Video video3 = new Video("Debugging in Visual Studio", "The Techie", 845);
        video3.AddComment(new Comment("Heidi", "The walkthrough on breakpoints was perfect."));
        video3.AddComment(new Comment("Ivan", "This saved me hours of work. Thank you!"));
        video3.AddComment(new Comment("Judy", "I always wondered how to use the call stack."));

        videos.Add(video3);

        // --------------------------------------------------
        // Display video and comment information
        // --------------------------------------------------
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine();
        }
    }
}