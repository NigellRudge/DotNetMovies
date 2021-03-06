﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class MovieInfoLong
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public BelongsToCollection belongs_to_collection { get; set; }
        public int budget { get; set; }
        public IList<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public IList<ProductionCompany> production_companies { get; set; }
        public IList<ProductionCountry> production_countries { get; set; }
        public string release_date { get; set; }
        public int revenue { get; set; }
        public int runtime { get; set; }
        public IList<SpokenLanguage> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public ImageResultShort images { get; set; }
        public CreditResultShort credits { get; set; }
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
