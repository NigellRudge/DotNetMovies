using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Crew
    {
        public string credit_id { get; set; }
        public string department { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string job { get; set; }
        public string name { get; set; }
        public string profile_path { get; set; }

        public string getProfilePath()
        {
            return this.profile_path == null? null : Config.MEDIA_URL + this.profile_path;
        }
    }
}
