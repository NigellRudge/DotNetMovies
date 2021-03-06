﻿using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Episode
    {
        public string air_date { get; set; }
        public int episode_number { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string production_code { get; set; }
        public int season_number { get; set; }
        public int show_id { get; set; }
        public string still_path { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public IList<Crew> crew { get; set; }
        public IList<GuestStar> guest_stars { get; set; }

        public string GetStilPath()
        {
            return this.still_path == null ? null : Config.MEDIA_URL + this.still_path;
        }

        public string GetEpisodeString()
        {
            var output = "";
            var season = "";
            var episode = "";
            if(this.season_number < 10)
            {
                season = "S0" + Convert.ToString(this.season_number);
            }
            else
            {
                season = "S" + Convert.ToString(this.season_number);
            }
            if(this.episode_number < 10)
            {
                episode = "E0" + Convert.ToString(this.episode_number);
            }
            else
            {
                episode = "E" + Convert.ToString(this.episode_number);
            }
            output = season + episode;
            return output;
        }
    }
}
