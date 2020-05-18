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
            return "https://image.tmdb.org/t/p/original/" + this.profile_path;
        }
    }
}
