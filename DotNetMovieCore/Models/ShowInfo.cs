using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ShowInfo
    {
        public string backdrop_path { get; set; }
        public IList<CreatedBy> created_by { get; set; }
        public IList<double> episode_run_time { get; set; }
        public string first_air_date { get; set; }
        public IList<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public bool in_production { get; set; }
        public IList<string> languages { get; set; }
        public string last_air_date { get; set; }
        public LastEpisodeToAir last_episode_to_air { get; set; }
        public string name { get; set; }
        public Episode next_episode_to_air { get; set; }
        public IList<Network> networks { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public IList<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public IList<ProductionCompany> production_companies { get; set; }
        public IList<Season> seasons { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }

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
