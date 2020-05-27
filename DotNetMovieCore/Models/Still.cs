using DotNetMovieCore.config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class Still
    {
        public double aspect_ratio { get; set; }
        public string file_path { get; set; }
        public int height { get; set; }
        public string iso_639_1 { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public int width { get; set; }
        public string GetFilePath()
        {
            if(this.file_path == null)
            {
                return null;
            }
            else
            {
                return Config.MEDIA_URL + this.file_path;
            }
            
        }
    }
}
