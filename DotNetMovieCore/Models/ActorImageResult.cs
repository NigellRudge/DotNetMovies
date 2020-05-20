using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ActorImageResult
    {
        public int id { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public IList<ActorImage> results { get; set; }
        public int total_pages { get; set; }
    }
}
