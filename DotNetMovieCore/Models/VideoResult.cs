using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class VideoResult
    {
        public int id { get; set; }
        public IList<VideoItem> results { get; set; }
    }
}
