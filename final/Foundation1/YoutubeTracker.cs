using System;
using System.Collections.Generic;

namespace YouTubeApp
{
    public class YouTubeTracker
    {
        private List<Video> _videos;
        
        public YouTubeTracker()
        {
            _videos = new List<Video>();
        }
        
        public void AddVideo(Video video)
        {
            _videos.Add(video);
        }
        
        public void DisplayAllVideos()
        {
            foreach (var video in _videos)
            {
                video.DisplayVideoInfo();
            }
        }
    }
}
