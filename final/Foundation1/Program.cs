using System;

namespace YouTubeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Initialize the YouTubeTracker
            YouTubeTracker tracker = new YouTubeTracker();
            
            // Create sample videos
            Video video1 = new Video("C# Tutorial", "John Doe", 600);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            
            Video video2 = new Video("Introduction to OOP", "Jane Smith", 800);
            video2.AddComment(new Comment("Charlie", "Well explained."));
            
            // Add videos to the tracker
            tracker.AddVideo(video1);
            tracker.AddVideo(video2);
            
            // Display all videos along with their comments
            tracker.DisplayAllVideos();
            
            // Wait for user input before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
