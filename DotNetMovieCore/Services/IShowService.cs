using DotNetMovieCore.Models;
using System.Collections.Generic;

namespace DotNetMovieCore.Services
{
    public interface IShowService
    {
        IEnumerable<Still> GetEpisodeImages(int showId, int seasonId, int episodeId);
        Episode GetEpisodeInfo(int showId, int seasonId, int episodeId);
        IEnumerable<Genre> GetGenres();
        IEnumerable<Show> GetNowAiring();
        IEnumerable<Show> GetPopularShows();
        IEnumerable<Backdrop> GetSeasonBackdrops(int showId, int seasonId);
        SeasonInfo GetSeasonInfo(int showId, int seasonId);
        IEnumerable<Poster> GetSeasonPosters(int showId, int seasonId);
        VideoItem GetSeasonTrailer(int showId);
        IEnumerable<Backdrop> GetShowBackdrops(int showId);
        IEnumerable<Cast> GetShowCast(int showId);
        IEnumerable<Crew> GetShowCrew(int showId);
        ShowInfo GetShowInfo(int showId);
        IEnumerable<Poster> GetShowPosters(int showId);
        VideoItem GetShowTrailer(int showId);
        IEnumerable<Show> GetTopRatedShows();
    }
}