using DotNetMovieCore.Models;
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
        private string BASE_URL = "https://api.themoviedb.org/3";
        public IEnumerable<Show> GetPopularShows()
        {
            /*var url = $"https://api.themoviedb.org/3/tv/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<ShowResult>(body);
            return item.results;*/

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetPopularShows().Result.results;
        }

        public IEnumerable<Show> GetTopRatedShows()
        {
            /*var url = $"https://api.themoviedb.org/3/tv/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<ShowResult>(body);
            return item.results; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetTopRatedShows().Result.results;
        }

        public ShowInfo GetShowInfo(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<ShowInfo>(body);
            return item;*/
            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetShowInfo(showId).Result;
        }

        public IEnumerable<Show> GetNowAiring()
        {
            /* var url = $"https://api.themoviedb.org/3/tv/on_the_air?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
             var result = new HttpClient().GetAsync(url).Result;
             var body = result.Content.ReadAsStringAsync().Result;
             var item = JsonConvert.DeserializeObject<ShowResult>(body);
             return item.results;*/

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetNowAiring().Result.results;
        }

        public IEnumerable<Cast> GetShowCast(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/credits?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<CreditsResult>(body);
            return items.cast; */

             var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetShowCredits(showId).Result.cast;
        }

        public IEnumerable<Crew> GetShowCrew(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/credits?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<CreditsResult>(body);
            return items.cast; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetShowCredits(showId).Result.crew;
        }

        public IEnumerable<Poster> GetShowPosters(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.posters; */

             var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetImages(showId).Result.posters;
        }

        public IEnumerable<Backdrop> GetShowBackdrops(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.posters; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetImages(showId).Result.backdrops;
        }

        public IEnumerable<Genre> GetGenres()
        {
            /*var url = "https://api.themoviedb.org/3/genre/tv/list?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<GenreResult>(body);
            return items.genres; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetGenres().Result.genres;
        }

        public SeasonInfo GetSeasonInfo(int showId, int seasonId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/season/{seasonId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<SeasonInfo>(body);
            return items;*/
            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetSeasonInfo(showId, seasonId).Result;
        }

        public IEnumerable<Backdrop> GetSeasonBackdrops(int showId, int seasonId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/season/{seasonId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.backdrops; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetSeasonImages(showId, seasonId).Result.backdrops;
        }

        public IEnumerable<Poster> GetSeasonPosters(int showId, int seasonId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/season/{seasonId}/images?api_key=a28d205a378cece6baa18ba20119765b";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<ImageResult>(body);
            return items.backdrops; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetSeasonImages(showId, seasonId).Result.posters;
        }

        public Episode GetEpisodeInfo(int showId, int seasonId, int episodeId)
        {
            var url = $"https://api.themoviedb.org/3/tv/{showId}/season/{seasonId}/episode/{episodeId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<Episode>(body);
            return item;
        }
        public VideoItem GetShowTrailer(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/videos?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<VideoResult>(body);
            return items.results.First(); */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetShowTrailer(showId).Result.results.First();
        }

        public VideoItem GetSeasonTrailer(int showId)
        {
            /*var url = $"https://api.themoviedb.org/3/tv/{showId}/videos?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var items = JsonConvert.DeserializeObject<VideoResult>(body);
            return items.results; */

            var service = RestService.For<IRefitShowService>(BASE_URL);
            return service.GetSeasonTrailer(showId).Result.results.First();
        }

        public IEnumerable<Still> GetEpisodeImages(int showId, int seasonId, int episodeId)
        {
            var url = $"https://api.themoviedb.org/3/tv/{showId}/season/{seasonId}/episode/{episodeId}/images?api_key=a28d205a378cece6baa18ba20119765b&language=en-US";
            var result = new HttpClient().GetAsync(url).Result;
            var body = result.Content.ReadAsStringAsync().Result;
            var item = JsonConvert.DeserializeObject<EpisodeImageResult>(body);
            return item.stills;
        }

    }
}
