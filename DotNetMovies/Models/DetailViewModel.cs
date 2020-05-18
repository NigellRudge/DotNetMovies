using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class DetailViewModel
    {
        public MovieInfo movie;
        public List<Cast> cast;
        public List<Crew> crew;
        public List<Backdrop> backdrops;
        public List<Poster> posters;
    }
}
