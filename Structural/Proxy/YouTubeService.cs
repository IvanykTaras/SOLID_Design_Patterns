using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Proxy
{
    public class YouTubeService : IYouTubeService
    {
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"YouTube service download video: {videoId}");

            return new byte[videoId];
        }
    }
}
