using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class CreatedBy
    {
        public int id { get; set; }
        public string credit_id { get; set; }
        public string name { get; set; }
        public int gender { get; set; }
        public string profile_path { get; set; }

        public string getProfilePath()
        {
            return Config.MEDIA_URL + this.profile_path;
        }

    }
 }
