using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class VideoItem
    {
        public string id { get; set; }
        public string iso_639_1 { get; set; }
        public string iso_3166_1 { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string site { get; set; }
        public int size { get; set; }
        public string type { get; set; }

        public string GetVideoUrl()
        {
            return Config.VIDEO_URL + this.key;
        }
    }
}
