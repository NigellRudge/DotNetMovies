using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class ShowsViewModel
    {
        public IEnumerable<Show> TopRatedShows { get; set; }
        public IEnumerable<Show> NowAiringShows { get; set; }

        public IEnumerable<Genre> genres { get; set; }
    }
}
