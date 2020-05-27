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
        private Task<IEnumerable<Genre>> genres;

        public MovieService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;
            this.genres = this.GetMovieGenres();
            
        }
        public async Task<MovieInfo> Get(int id)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var result = await service.GetMovieInfo(id, config.ApiKey);
                return result;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Movie>> GetAll(int page = 0)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = service.GetAllMovies(config.ApiKey).Result.results;
                foreach (var movie in results)
                {
                    movie.GetGenreString(await this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Movie>> GetNowPlaying()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = (await service.GetNowPlayingMovies(config.ApiKey)).results;
                foreach(var movie in results)
                {
                    movie.GetGenreString(await this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Movie>> GetTopMovies()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                var results = (await service.GetAllMovies(config.ApiKey)).results;
                foreach (var movie in results)
                {
                    movie.GetGenreString(await this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Movie>> Search(string query)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.SearchMovie(config.ApiKey,query)).results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Cast>> GetCast(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetCast(movieId,config.ApiKey)).cast;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }
        public async Task<IEnumerable<Crew>> GetCrew(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetCrew(movieId, config.ApiKey)).crew;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Poster>> GetMoviePosters(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetMoviePosters(movieId, config.ApiKey)).posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<IEnumerable<Backdrop>> GetBackDrops(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetMovieBackdrops(movieId, config.ApiKey)).backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        
        public async Task<IEnumerable<Genre>> GetMovieGenres()
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return  (await service.GetMovieGenres(config.ApiKey)).genres;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<string> GetGenreName(int id)
        {
            var output = "";
            foreach(var item in await this.GetMovieGenres())
            {
                if (item.id == id)
                    output = item.name;
            }
            return output;
        }

        public async Task<VideoItem> GetMovieTrailer(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetMovieTrailer(movieId,config.ApiKey)).results.ToList().First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<MovieInfoLong> GetMovieInfoLong(int movieId)
        {
            try
            {
                var service = RestService.For<IRefitMovieService>(config.BaseUrl);
                return (await service.GetMovieInfoLong(movieId, config.ApiKey));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }

}
