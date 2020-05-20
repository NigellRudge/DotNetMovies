using DotNetMovieCore.config;
using System.Collections.Generic;

namespace DotNetMovieCore.Models
{
    public class KnownFor
    {
        public string original_name { get; set; }
        public IList<int> genre_ids { get; set; }
        public string media_type { get; set; }
        public string name { get; set; }
        public IList<string> origin_country { get; set; }
        public int vote_count { get; set; }
        public string first_air_date { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public int id { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }

        public string GetPosterPath()
        {
            return this.poster_path == null ? null : Config.MEDIA_URL + this.poster_path;
        }

        public string GetBackdropPath()
        {
            return this.backdrop_path == null ? null : Config.MEDIA_URL + this.backdrop_path;
        }
    }
}