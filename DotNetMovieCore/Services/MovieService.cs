using DotNetMovieCore.config;
using DotNetMovieCore.Models;
using DotNetMovies.Utils;
using Microsoft.Extensions.Options;
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
        private ApiOptions config;
        private IEnumerable<Genre> genres;

        public MovieService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;
            this.genres = this.GetMovieGenres();
            
        }
        public MovieInfo Get(int id)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = service.GetMovieInfo(id, config.ApiKey).Result;
                return service.GetMovieInfo(id,config.ApiKey).Result;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public IEnumerable<Movie> GetAll(int page = 0)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = service.GetAllMovies(config.ApiKey).Result.results;
                foreach (var movie in results)
                {
                    movie.GetGenreString(this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Movie> GetNowPlaying()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = service.GetNowPlayingMovies(config.ApiKey).Result.results;
                foreach(var movie in results)
                {
                    movie.GetGenreString(this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Movie> GetTopMovies()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = service.GetAllMovies(config.ApiKey).Result.results;
                foreach (var movie in results)
                {
                    movie.GetGenreString(this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public IEnumerable<Movie> Search(string query)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.SearchMovie(config.ApiKey,query).Result.results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Cast> GetCast(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetCast(movieId,config.ApiKey).Result.cast;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }
        public IEnumerable<Crew> GetCrew(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetCrew(movieId, config.ApiKey).Result.crew;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Poster> GetMoviePosters(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetMoviePosters(movieId, config.ApiKey).Result.posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public IEnumerable<Backdrop> GetBackDrops(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetMovieBackdrops(movieId, config.ApiKey).Result.backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        
        public IEnumerable<Genre> GetMovieGenres()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetMovieGenres(config.ApiKey).Result.genres;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
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
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return service.GetMovieTrailer(movieId,config.ApiKey).Result.results.ToList().First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }

    public interface IOptions<T>
    {
    }
}
