using DotNetMovieCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public class MovieService : IMovieService
    {
        public MovieInfo Get(int id)
        {
            var url = $"https://api.themoviedb.org/3/movie/{id}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";

            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<MovieInfo>(body);
            return item;
        }

        public IEnumerable<Movie> GetAll(int page = 0)
        {
            var url = $"https://api.themoviedb.org/3/movie/popular?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page={page}";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<MovieResult>(body);
            return items.results;
        }

        public IEnumerable<Movie> GetNowPlaying()
        {
            var url = "https://api.themoviedb.org/3/movie/now_playing?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<MovieResult>(body);
            return items.results;
        }

        public IEnumerable<Movie> GetTopMovies()
        {
            var url = "https://api.themoviedb.org/3/movie/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<MovieResult>(body);
            return items.results;
        }

        public IEnumerable<Movie> Search(string query)
        {
            var url = $"https://api.themoviedb.org/3/search/movie?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1&include_adult=false&query={query}";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<MovieResult>(body);
            return items.results;
        }

        public IEnumerable<Cast> GetCast(int movieId)
        {
            var url = $"https://api.themoviedb.org/3/movie/{movieId}/credits?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<CreditsResult>(body);
            return items.cast;
        }
        public IEnumerable<Crew> GetCrew(int movieId)
        {
            var url = $"https://api.themoviedb.org/3/movie/{movieId}/credits?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<CreditsResult>(body);
            return items.crew;
        }

        public IEnumerable<Poster> GetMoviePosters(int movieId)
        {
            var url = $"https://api.themoviedb.org/3/movie/{movieId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.posters;
        }
        public IEnumerable<Backdrop> GetBackDrops(int movieId)
        {
            var url = $"https://api.themoviedb.org/3/movie/{movieId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.backdrops;
        }
        
        public IEnumerable<Genre> GetMovieGenres()
        {
            var url = "https://api.themoviedb.org/3/genre/movie/list?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<GenreResult>(body);
            return items.genres;
        }

        public string GetGenreName(int id)
        {
            var output = "";
            foreach(var item in this.GetMovieGenres())
            {
                if (item.id == id)
                    output = item.name;
            }
            return output;
        }
    }
}
