using DotNetMovieCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IMovieService
    {
        Task<MovieInfo> Get(int id);
        Task<IEnumerable<Movie>> GetAll(int page = 0);
        Task<IEnumerable<Movie>> GetNowPlaying();
        Task<IEnumerable<Movie>> GetTopMovies();
        Task<IEnumerable<Movie>> Search(string query);
        Task<IEnumerable<Cast>> GetCast(int movieId);
        Task<IEnumerable<Crew>> GetCrew(int movieId);
        Task<IEnumerable<Backdrop>> GetBackDrops(int movieId);
        Task<IEnumerable<Poster>> GetMoviePosters(int movieId);
        Task<IEnumerable<Genre>> GetMovieGenres();
        Task<string> GetGenreName(int id);

        Task<MovieInfoLong> GetMovieInfoLong(int id);
        VideoItem GetMovieTrailer(int movieId);
    }
}