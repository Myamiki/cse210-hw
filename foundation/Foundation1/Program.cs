using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    // Comment Class
    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }

    // Video Class
    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } 
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        // Add a comment to the video
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Get the number of comments
        public int GetCommentCount()
        {
            return Comments.Count;
        }

        // Display video details
        public void DisplayVideoDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {Length} seconds");
            Console.WriteLine($"Number of Comments: {GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 30)); // Separator
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of videos section
            Video video1 = new Video("C# Tutorial for beginners 2024", "Jeff Troys", 700);
            Video video2 = new Video("C# Introduction to Abstraction", "Timoth Shona", 850);
            Video video3 = new Video("C# Abstract Classes and Methods Part 1", "Brian Smith", 470);

            // Add comments to video 1
            video1.AddComment(new Comment("Bella22", "I have been struggling with C# for weeks, but this tutorial helped me finally get it!!!"));
            video1.AddComment(new Comment("Nicky@89", "Honestly, one of the best beginner-friendly C# tutorials I've seen. Thanks Jeff!"));
            video1.AddComment(new Comment("Blues@45", "Wow, Jeff Troys really made C# easy to understand! This tutorial is perfect for beginners like me in 2024. Thank you for breaking it down so well!"));

            // Add comments to video 2
            video2.AddComment(new Comment("Sasha", "Highly recommend!"));
            video2.AddComment(new Comment("Tody", "Introduction to Abstraction by Timoth Shona is a game-changer for beginners!"));
            video2.AddComment(new Comment("Brian", "I have always struggled with abstraction, but this tutorial made it click."));

            // Add comments to video 3
            video3.AddComment(new Comment("Peter", "This is exactly what I needed to finally understand abstract classes. Brian Smith made it so clear. Thanks for this amazing tutorial!"));   
            video3.AddComment(new Comment("Mandy", "Brian Smith was so helpful."));
            video3.AddComment(new Comment("Victor","Thank you so much!"));
            video3.AddComment(new Comment("Chloe","The examples were simple yet effective."));
            // Store videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Display details of each video
            foreach (var video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}

