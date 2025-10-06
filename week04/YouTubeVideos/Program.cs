using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("The Life of Prophet Nelson", "Gospel Channel", 1800);
        Video video2 = new Video("Prophet Nelson's Ministry Legacy", "Christian TV", 1560);
        Video video3 = new Video("Homage to Prophet Nelson", "Faith Network", 1320);


        // Add comments to videos
        video1.AddComment(new Comment("Brother John", "A true man of God who touched millions of lives with his teachings."));
        video1.AddComment(new Comment("Sister Mary", "His legacy of faith and love will continue to inspire generations to come."));
        video1.AddComment(new Comment("Pastor David", "We celebrate his life and the powerful ministry he built through devotion and service."));

        video2.AddComment(new Comment("Elder James", "Prophet Nelson's sermons transformed my spiritual journey forever."));
        video2.AddComment(new Comment("Deaconess Sarah", "His compassion and wisdom were a beacon of light in our community."));
        video2.AddComment(new Comment("Minister Paul", "Though he's gone to glory, his teachings continue to guide us daily."));

        video3.AddComment(new Comment("Brother Michael", "Rest in peace, dear Prophet. Your work on earth was truly blessed."));
        video3.AddComment(new Comment("Sister Grace", "My heartfelt condolences to his family and the entire congregation."));
        video3.AddComment(new Comment("Elder Thomas", "He finished his race strong. What an exemplary life of service to God!"));
        
        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2,
            video3 };

        // Display videos

        Console.WriteLine("=== YouTube Video Management System ===");
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }

        Console.WriteLine("End of YouTubeVideos Project.");}
}
       