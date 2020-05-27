using DotNetMovieCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IShowService
    {
        Task<IEnumerable<Still>> GetEpisodeImages(int showId, int seasonId, int episodeId);
        Task<Episode> GetEpisodeInfo(int showId, int seasonId, int episodeId);
        Task<IEnumerable<Genre>> GetGenres();
        Task<IEnumerable<Show>> GetNowAiring();
        Task<IEnumerable<Show>> GetPopularShows();
        Task<IEnumerable<Backdrop>> GetSeasonBackdrops(int showId, int seasonId);
        Task<SeasonInfo> GetSeasonInfo(int showId, int seasonId);
        Task<IEnumerable<Poster>> GetSeasonPosters(int showId, int seasonId);
        Task<VideoItem> GetSeasonTrailer(int showId);
        Task<IEnumerable<Backdrop>> GetShowBackdrops(int showId);
        Task<IEnumerable<Cast>> GetShowCast(int showId);
        Task<IEnumerable<Crew>> GetShowCrew(int showId);
        Task<ShowInfo> GetShowInfo(int showId);
        Task<IEnumerable<Poster>> GetShowPosters(int showId);
        Task<VideoItem> GetShowTrailer(int showId);
        Task<IEnumerable<Show>> GetTopRatedShows();
    }
}