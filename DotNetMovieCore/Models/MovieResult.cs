using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class MovieResult
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public IList<Movie> results { get; set; }
    }
}
