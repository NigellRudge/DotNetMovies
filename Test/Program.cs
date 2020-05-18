using DotNetMovieCore.Models;
using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = $"https://api.themoviedb.org/3/movie/299536?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var client = new HttpClient();

            var result = client.GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<MovieInfo>(body);
            Console.WriteLine(item.genres.Count);
        }

    }
}
