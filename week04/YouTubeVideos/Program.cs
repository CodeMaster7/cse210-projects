using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all our videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("How to Learn C# Programming", "CodeMaster", 480);

        // Add comments to Video 1
        Comment comment1 = new Comment();
        comment1.SetCommenterName("Alice");
        comment1.SetCommentText("Great tutorial! Very helpful for beginners.");
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2.SetCommenterName("Bob");
        comment2.SetCommentText("Could you make a video about classes next?");
        video1.AddComment(comment2);

        Comment comment3 = new Comment();
        comment3.SetCommenterName("Charlie");
        comment3.SetCommentText("Thanks for the clear explanations!");
        video1.AddComment(comment3);

        // Add video1 to our list
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("Top 10 Programming Tips", "TechGuru", 720);

        // Add comments to Video 2
        Comment comment4 = new Comment();
        comment4.SetCommenterName("Diana");
        comment4.SetCommentText("Tip #5 changed my coding style completely!");
        video2.AddComment(comment4);

        Comment comment5 = new Comment();
        comment5.SetCommenterName("Eve");
        comment5.SetCommentText("More videos like this please!");
        video2.AddComment(comment5);

        Comment comment6 = new Comment();
        comment6.SetCommenterName("Frank");
        comment6.SetCommentText("I wish I knew these tips when I started coding.");
        video2.AddComment(comment6);

        Comment comment7 = new Comment();
        comment7.SetCommenterName("Grace");
        comment7.SetCommentText("Very practical advice. Subscribed!");
        video2.AddComment(comment7);

        // Add video2 to our list
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Building Your First Web App", "WebDevPro", 900);

        // Add comments to Video 3
        Comment comment8 = new Comment();
        comment8.SetCommenterName("Henry");
        comment8.SetCommentText("Finally got my app working thanks to this!");
        video3.AddComment(comment8);

        Comment comment9 = new Comment();
        comment9.SetCommenterName("Ivy");
        comment9.SetCommentText("Step-by-step instructions were perfect.");
        video3.AddComment(comment9);

        Comment comment10 = new Comment();
        comment10.SetCommenterName("Jack");
        comment10.SetCommentText("Can you do a follow-up on databases?");
        video3.AddComment(comment10);

        // Add video3 to our list
        videos.Add(video3);

        // Display all videos and their information
        Console.WriteLine("=== YouTube Video Tracker ===\n");

        foreach (Video video in videos)
        {
            // Display video information
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            // Display all comments for this video
            List<Comment> videoComments = video.GetComments();
            foreach (Comment comment in videoComments)
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine(); // Empty line between videos
        }
    }
}