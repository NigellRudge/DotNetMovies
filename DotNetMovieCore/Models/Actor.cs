using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Actor
    {
        public double popularity { get; set; }
        public string known_for_department { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public string profile_path { get; set; }
        public bool adult { get; set; }
        public IList<KnownFor> known_for { get; set; }
        public int gender { get; set; }

        public string GetProfilePath()
        {
            return this.profile_path == null ? null : Config.MEDIA_URL + this.profile_path;
        }

        public List<string> GetKnowMovies()
        {
            List<string> output = new List<string>();
            var count = this.known_for.Count >= 3 ? 3 : this.known_for.Count;
            foreach(var item in this.known_for.ToList().GetRange(0,count))
            {
                    output.Add(item.original_name);
            }
            return output;
        }
    }
}
