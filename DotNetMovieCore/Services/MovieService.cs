using DotNetMovieCore.Models;
using Newtonsoft.Json;
using Refit;
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
        private string BASE_URL = "https://api.themoviedb.org/3";
        public MovieInfo Get(int id)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            return service.GetMovieInfo(id).Result;
        }

        public IEnumerable<Movie> GetAll(int page = 0)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            return service.GetAllMovies().Result.results;
        }

        public IEnumerable<Movie> GetNowPlaying()
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            return service.GetNowPlayingMovies().Result.results;
        }

        public IEnumerable<Movie> GetTopMovies()
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            return service.GetAllMovies().Result.results;
            
        }

        public IEnumerable<Movie> Search(string query)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.SearchMovie(query).Result.results;
            return items;
        }

        public IEnumerable<Cast> GetCast(int movieId)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetCast(movieId).Result.cast;
            return items;

        }
        public IEnumerable<Crew> GetCrew(int movieId)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetCrew(movieId).Result.crew;
            return items;
        }

        public IEnumerable<Poster> GetMoviePosters(int movieId)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetMoviePosters(movieId).Result.posters;
            return items;
        }
        public IEnumerable<Backdrop> GetBackDrops(int movieId)
        {
             var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetMovieBackdrops(movieId).Result.backdrops;
            return items;
        }
        
        public IEnumerable<Genre> GetMovieGenres()
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetMovieGenres().Result.genres;
            return items;
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

        public VideoItem GetMovieTrailer(int movieId)
        {
            var service = RestService.For<IRefitMovieService>(BASE_URL);
            var items = service.GetMovieTrailer(movieId).Result.results.ToList().First();
            return items;
        }
    }
}
