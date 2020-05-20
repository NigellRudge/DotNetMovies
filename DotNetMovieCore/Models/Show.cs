﻿using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Show
    {
        public string original_name { get; set; }
        public IList<int> genre_ids { get; set; }
        public string name { get; set; }
        public double popularity { get; set; }
        public IList<string> origin_country { get; set; }
        public int vote_count { get; set; }
        public string first_air_date { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public int id { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }

        public string getPosterPath()
        {
            return Config.MEDIA_URL + poster_path;
        }

        public string getBackdropPath()
        {
            return Config.MEDIA_URL + this.backdrop_path;
        }

    }
}
