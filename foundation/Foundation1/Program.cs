using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("C# Tutorial for Beginners 2024", "Jeff Troys", 700);
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
            video3.AddComment(new Comment("Victor", "Thank you so much!"));
            video3.AddComment(new Comment("Chloe", "The examples were simple yet effective."));

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
