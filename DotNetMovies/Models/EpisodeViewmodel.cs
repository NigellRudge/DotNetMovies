using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class EpisodeViewmodel
    {
        public Episode episode;
        public List<Still> images;
        public VideoItem trailer;
    }
}
