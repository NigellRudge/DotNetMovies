using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IRefitMovieService
    {
        [Get("/movie/top_rated?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<MovieResult> GetAllMovies();

        [Get("/movie/now_playing?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1")]
        Task<MovieResult> GetNowPlayingMovies();

        [Get("/movie/{id}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<MovieInfo> GetMovieInfo(int id);

        [Get("/search/movie?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1&include_adult=false")]
        Task<MovieResult> SearchMovie(string query);

        [Get("/movie/{movieId}/credits?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<CreditsResult> GetCast(int movieId);

        [Get("/movie/{movieId}/credits?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<CreditsResult> GetCrew(int movieId);

        [Get("/movie/{movieId}/images?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<ImageResult> GetMoviePosters(int movieId);

        [Get("/movie/{movieId}/images?api_key=a28d205a378cece6baa18ba20119765b")]
        Task<ImageResult> GetMovieBackdrops(int movieId);

        [Get("/genre/movie/list?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<GenreResult> GetMovieGenres();
        
        [Get("/movie/{movieId}/videos?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<VideoResult> GetMovieTrailer(int movieId);
    }
}
