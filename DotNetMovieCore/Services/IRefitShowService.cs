using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IRefitShowService
    {
        [Get("/tv/on_the_air?language=en-US")]
        Task<ShowResult> GetNowAiring(string api_key);

        [Get("/tv/top_rated?language=en-US")]
        Task<ShowResult> GetPopularShows(string api_key);

        [Get("/tv/{showId}?language=en-US")]
        Task<ShowInfo> GetShowInfo(int showId, string api_key);

        [Get("/tv/top_rated")]
        Task<ShowResult> GetTopRatedShows(string api_key);

        [Get("/tv/{showId}/credits?language=en-US")]
        Task<CreditsResult> GetShowCredits(int showId, string api_key);

        [Get("/tv/{showId}/images")]
        Task<ImageResult> GetImages(int showId, string api_key);

        [Get("/genre/tv/list?language=en-US")]
        Task<GenreResult> GetGenres(string api_key);

        [Get("/tv/{showId}/season/{seasonId}?language=en-US")]
        Task<SeasonInfo> GetSeasonInfo(int showId, int seasonId, string api_key);

        [Get("/tv/{showId}/season/{seasonId}/images")]
        Task<ImageResult> GetSeasonImages(int showId, int seasonId, string api_key);

        [Get("/tv/{showId}/videos?language=en-US")]
        Task<VideoResult> GetShowTrailer(int showId, string api_key);

        [Get("/tv/{showId}/videos?language=en-US")]
        Task<VideoResult> GetSeasonTrailer(int showId, string api_key);

        [Get("/tv/{showId}/season/{seasonId}/episode/{episodeId}/images?language=en-US")]
        Task<EpisodeImageResult> GetEpisodeImages(int showId, int seasonId, int episodeId, string api_key);

        [Get("/tv/{showId}/season/{seasonId}/episode/{episodeId}?language=en-US")]
        Task<Episode> GetEpisodeInfo(int showId, int seasonId, int episodeId, string api_key);
    }
}
