using System;
using System.Collections.Generic;

namespace ExceptionHandlingDemo
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string name)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new YouTubeException("Could Not Fetch", ex);
            }
            return new List<Video>();
        }
    }

    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}


