using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Movie
    {
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string poster_path { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public IList<int> genre_ids { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        public List<string> genre_names { get; set; }

        public string getPosterPath()
        {
            return "https://image.tmdb.org/t/p/original/" + this.poster_path;
        }

        public string getBackdropPath()
        {
            return "https://image.tmdb.org/t/p/original/" + this.backdrop_path;
        }
    }


}
