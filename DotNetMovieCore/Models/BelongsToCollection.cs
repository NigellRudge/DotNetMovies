using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class BelongsToCollection
    {
        public int id { get; set; }
        public string name { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }

        public string getPosterPath()
        {
            return Config.MEDIA_URL + this.poster_path;
        }

        public string getBackdropPath()
        {
            return Config.MEDIA_URL + this.backdrop_path;
        }

    }
}
