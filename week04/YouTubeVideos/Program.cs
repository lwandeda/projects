using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 30 Minutes", "John Smith", 1800);

        video1.AddComment(new Comment("Sarah", "Excellent tutorial!"));
        video1.AddComment(new Comment("Mike", "Very easy to understand."));
        video1.AddComment(new Comment("Peter", "Thank you for sharing."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video("HTML for Beginners", "Jane Brown", 1200);

        video2.AddComment(new Comment("Alice", "Amazing lesson."));
        video2.AddComment(new Comment("Tom", "Very helpful."));
        video2.AddComment(new Comment("Chris", "Keep making videos!"));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video("JavaScript Basics", "David Wilson", 1500);

        video3.AddComment(new Comment("Emily", "I learned a lot."));
        video3.AddComment(new Comment("Ryan", "Great explanation."));
        video3.AddComment(new Comment("Sophia", "Thanks!"));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Object-Oriented Programming", "Linda Adams", 2100);

        video4.AddComment(new Comment("James", "Fantastic content."));
        video4.AddComment(new Comment("Emma", "This helped my homework."));
        video4.AddComment(new Comment("Daniel", "Very clear explanation."));

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}