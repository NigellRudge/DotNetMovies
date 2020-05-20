using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class EpisodeImageResult
    {
        public int id { get; set; }
        public IList<Still> stills { get; set; }
    }
}
