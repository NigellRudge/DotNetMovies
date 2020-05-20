using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ActorImage
    {
        public string iso_639_1 { get; set; }
        public int vote_count { get; set; }
        public string media_type { get; set; }
        public string file_path { get; set; }
        public double aspect_ratio { get; set; }
        public ActorImageMedia media { get; set; }
        public int height { get; set; }
        public double vote_average { get; set; }
        public int width { get; set; }
    }
}
