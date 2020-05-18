using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> TopRatedMovies { get; set; }
        public IEnumerable<Movie> NowPlayingMovies { get; set; }
        public IEnumerable<Genre> genres { get; set; }
    }
}
