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
        [Get("/tv/on_the_air?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ShowResult> GetNowAiring();

        [Get("/tv/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ShowResult> GetPopularShows();

        [Get("/tv/{showId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ShowInfo> GetShowInfo(int showId);

        [Get("/tv/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&")]
        Task<ShowResult> GetTopRatedShows();

        [Get("/tv/{showId}/credits?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<CreditsResult> GetShowCredits(int showId);

        [Get("/tv/{showId}/images?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<ImageResult> GetImages(int showId);

        [Get("/genre/tv/list?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<GenreResult> GetGenres();

        [Get("/tv/{showId}/season/{seasonId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<SeasonInfo> GetSeasonInfo(int showId, int seasonId);

        [Get("/tv/{showId}/season/{seasonId}/images?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<ImageResult> GetSeasonImages(int showId, int seasonId);

        [Get("/tv/{showId}/videos?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<VideoResult> GetShowTrailer(int showId);

        [Get("/tv/{showId}/videos?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<VideoResult> GetSeasonTrailer(int showId);

        [Get("/tv/{showId}/season/{seasonId}/episode/{episodeId}/images?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ImageResult> GetEpisodeImages(int showId, int seasonId, int episodeId);
    }
}
