using System;

namespace VideoTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            YouTubeTracker tracker = new YouTubeTracker();
            
            Video video1 = new Video("C# Tutorial", "John Doe", 600);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            
            Video video2 = new Video("Introduction to OOP", "Jane Smith", 800);
            video2.AddComment(new Comment("Charlie", "Well explained."));
            
            tracker.AddVideo(video1);
            tracker.AddVideo(video2);
            
            tracker.DisplayAllVideos();
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
