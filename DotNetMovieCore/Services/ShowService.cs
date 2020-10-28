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
    public class ShowService : IShowService
    {
        private readonly ApiOptions config;
        private readonly Task<IEnumerable<Genre>> genres;

        public ShowService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;
            this.genres =  this.GetGenres();

        }
        public async Task<IEnumerable<Show>> GetPopularShows()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = (await service.GetPopularShows(config.ApiKey)).results;
                foreach(var show in results)
                {
                    show.GetGenreString(await this.genres);
                }
                return results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Show>> GetTopRatedShows()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = (await service.GetTopRatedShows(config.ApiKey)).results;
                foreach (var show in results)
                {
                    show.GetGenreString(await this.genres);
                }
                return results;
                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<ShowInfo> GetShowInfo(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetShowInfo(showId, config.ApiKey));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Show>> GetNowAiring()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                var results = (await service.GetNowAiring(config.ApiKey)).results;
                foreach (var show in results)
                {
                    show.GetGenreString(await this.genres);
                }
                return results;
                
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Cast>> GetShowCast(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return  (await service.GetShowCredits(showId, config.ApiKey)).cast;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Crew>> GetShowCrew(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return  (await service.GetShowCredits(showId, config.ApiKey)).crew;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Poster>> GetShowPosters(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return  (await service.GetImages(showId, config.ApiKey)).posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Backdrop>> GetShowBackdrops(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetImages(showId, config.ApiKey)).backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Genre>> GetGenres()
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetGenres(config.ApiKey)).genres;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<SeasonInfo> GetSeasonInfo(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetSeasonInfo(showId, seasonId, config.ApiKey));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Backdrop>> GetSeasonBackdrops(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetSeasonImages(showId, seasonId, config.ApiKey)).backdrops;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Poster>> GetSeasonPosters(int showId, int seasonId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetSeasonImages(showId, seasonId, config.ApiKey)).posters;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<Episode> GetEpisodeInfo(int showId, int seasonId, int episodeId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return  (await service.GetEpisodeInfo(showId,seasonId,episodeId,config.ApiKey));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
        public async Task<VideoItem> GetShowTrailer(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetShowTrailer(showId, config.ApiKey)).results.First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<VideoItem> GetSeasonTrailer(int showId)
        {
            try
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetSeasonTrailer(showId, config.ApiKey)).results.First();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<IEnumerable<Still>> GetEpisodeImages(int showId, int seasonId, int episodeId)
        {
            try 
            {
                var service = RestService.For<IRefitShowService>(config.BaseUrl);
                return (await service.GetEpisodeImages(showId, seasonId, episodeId, config.ApiKey)).stills;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
            
        }

    }
}
