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

namespace DotNetMovieCore.Services
{
    public class ShowService : IShowService
    {
        private ApiOptions config;
        private IEnumerable<Genre> genres;

        public ShowService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;
            this.genres = this.GetGenres();

        }
        public IEnumerable<Show> GetPopularShows()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = service.GetPopularShows(config.ApiKey).Result.results;
                foreach(var show in results)
                {
                    show.GetGenreString(this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Show> GetTopRatedShows()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = service.GetTopRatedShows(config.ApiKey).Result.results;
                foreach (var show in results)
                {
                    show.GetGenreString(this.genres);
                }
                return results;
                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public ShowInfo GetShowInfo(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetShowInfo(showId, config.ApiKey).Result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Show> GetNowAiring()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = service.GetNowAiring(config.ApiKey).Result.results;
                foreach (var show in results)
                {
                    show.GetGenreString(this.genres);
                }
                return results;
                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Cast> GetShowCast(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetShowCredits(showId, config.ApiKey).Result.cast;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Crew> GetShowCrew(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetShowCredits(showId, config.ApiKey).Result.crew;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Poster> GetShowPosters(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetImages(showId, config.ApiKey).Result.posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Backdrop> GetShowBackdrops(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetImages(showId, config.ApiKey).Result.backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public IEnumerable<Genre> GetGenres()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetGenres(config.ApiKey).Result.genres;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public SeasonInfo GetSeasonInfo(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetSeasonInfo(showId, seasonId, config.ApiKey).Result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Backdrop> GetSeasonBackdrops(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetSeasonImages(showId, seasonId, config.ApiKey).Result.backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Poster> GetSeasonPosters(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetSeasonImages(showId, seasonId, config.ApiKey).Result.posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public Episode GetEpisodeInfo(int showId, int seasonId, int episodeId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetEpisodeInfo(showId,seasonId,episodeId,config.ApiKey).Result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public VideoItem GetShowTrailer(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetShowTrailer(showId, config.ApiKey).Result.results.First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public VideoItem GetSeasonTrailer(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetSeasonTrailer(showId, config.ApiKey).Result.results.First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public IEnumerable<Still> GetEpisodeImages(int showId, int seasonId, int episodeId)
        {
            try 
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return service.GetEpisodeImages(showId, seasonId, episodeId, config.ApiKey).Result.stills;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
            
        }

    }
}
