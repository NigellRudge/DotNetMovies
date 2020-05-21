using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Utils
{
    public class ApiOptions
    {
        public ApiOptions()
        {

        }
        public string BaseUrl { get; set; }
        public string MediaUrl { get; set; }
        public string ApiKey { get; set; }
        public string YoutubeUrl { get; set; }
    }
}
