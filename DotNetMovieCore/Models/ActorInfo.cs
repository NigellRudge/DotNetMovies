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
        public List<string> also_known_as { get; set; }
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

        public int GetAge()
        {
            var today = DateTime.Now;
            var birthDate = DateTime.Parse(this.birthday);
            var age = today.Year - birthDate.Year;
            return age;
        }
        public string GetOccupasion()
        {
            if (this.known_for_department.ToLower() == "acting")
            {
                return this.gender == 2 ? "Actor" : "Actress";
            }
            else
            {
                return this.known_for_department;
            }
        }

        public List<String> GetOtherNames()
        {
            var count = this.also_known_as.Count >= 4 ? 4 : this.also_known_as.Count;
            return this.also_known_as.GetRange(0, count);
        }

    }
}
