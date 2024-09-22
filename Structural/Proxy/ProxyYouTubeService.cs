using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Structural.Proxy
{
    public class ProxyYouTubeService : IYouTubeService
    {
        private YouTubeService _youTubeService;
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

        public ProxyYouTubeService(YouTubeService youTubeService) => _youTubeService = youTubeService;
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Proxy youtube service getting video id: {videoId}");


            if (_cache.TryGetValue(videoId, out byte[] cacheVideo)) {
                Console.WriteLine($"Getting from cache {videoId}");
                return cacheVideo;
            }
            
            var video = _youTubeService.GetVideo(videoId);
            _cache.Add(videoId,video);

            return video;
        }
    }
}
