using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class SeasonInfo
    {
        public string _id { get; set; }
        public string air_date { get; set; }
        public IList<Episode> episodes { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public int id { get; set; }
        public string poster_path { get; set; }
        public int season_number { get; set; }
    }

}
