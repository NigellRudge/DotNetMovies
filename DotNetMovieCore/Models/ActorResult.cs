using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ActorResult
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public IList<Actor> results { get; set; }
    }
}
