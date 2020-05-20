using DotNetMovieCore.Models;
using System.Collections.Generic;

namespace DotNetMovieCore.Services
{
    public interface IMovieService
    {
        MovieInfo Get(int id);
        IEnumerable<Movie> GetAll(int page = 0);
        IEnumerable<Movie> GetNowPlaying();
        IEnumerable<Movie> GetTopMovies();
        IEnumerable<Movie> Search(string query);
        IEnumerable<Cast> GetCast(int movieId);
        IEnumerable<Crew> GetCrew(int movieId);
        IEnumerable<Backdrop> GetBackDrops(int movieId);
        IEnumerable<Poster> GetMoviePosters(int movieId);
        IEnumerable<Genre> GetMovieGenres();
        string GetGenreName(int id);

        VideoItem GetMovieTrailer(int movieId);
    }
}