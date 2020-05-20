using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ActorInfo
    {
        public string birthday { get; set; }
        public string known_for_department { get; set; }
        public string deathday { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<string> also_known_as { get; set; }
        public int gender { get; set; }
        public string biography { get; set; }
        public double popularity { get; set; }
        public string place_of_birth { get; set; }
        public string profile_path { get; set; }
        public bool adult { get; set; }
        public string imdb_id { get; set; }
        public string homepage { get; set; }

        public string getProfilePath()
        {
            return Config.MEDIA_URL + this.profile_path;
        }

    }
}
