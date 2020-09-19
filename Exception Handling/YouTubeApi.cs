using System;
using System.Collections.Generic;

namespace Exception_Handling
{
    public class YouTubeApi
    {
        public List<Video> GetVideo(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of video objects
                
                throw new Exception("Oops some low level YouTube exception");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from youTube.", ex);
            }

            return new List<Video>();
        }
    }
}