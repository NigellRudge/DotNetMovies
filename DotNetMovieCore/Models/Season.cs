using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Season
    {
        public string air_date { get; set; }
        public int episode_count { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }

        public string getPosterPath()
        {
            return this.poster_path == null ? null : "https://image.tmdb.org/t/p/original/" + this.poster_path;
        }
 
        public string getSeasonNumber()
        {
            string output;
            if(this.season_number < 10)
            {
                output = "S0" + season_number.ToString();
            }
            else
            {
                output = "S" + season_number.ToString();
            }
            return output;
        }
    }
}
