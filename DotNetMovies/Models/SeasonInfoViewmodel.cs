using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class SeasonInfoViewmodel
    {
        public SeasonInfo season { get; set; }
        public ShowInfo show { get; set; }

        public VideoItem trailer { get; set; }
        public List<Poster> posters { get; set; }
        public List<Backdrop> backdrops { get; set; }
    }
}
