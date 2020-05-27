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
        [Get("/movie/top_rated?language=en-US")]
        Task<MovieResult> GetAllMovies(string api_key);

        [Get("/movie/now_playing?language=en-US&page=1")]
        Task<MovieResult> GetNowPlayingMovies(string api_key);

        [Get("/movie/{id}?language=en-US")]
        Task<MovieInfo> GetMovieInfo(int id, string api_key);

        [Get("/search/movie?language=en-US&include_adult=false")]
        Task<MovieResult> SearchMovie(string api_key,string query);

        [Get("/movie/{movieId}/credits")]
        Task<CreditsResult> GetCast(int movieId, string api_key);

        [Get("/movie/{movieId}/credits")]
        Task<CreditsResult> GetCrew(int movieId, string api_key);

        [Get("/movie/{movieId}/images")]
        Task<ImageResult> GetMoviePosters(int movieId, string api_key);

        [Get("/movie/{movieId}/images")]
        Task<ImageResult> GetMovieBackdrops(int movieId, string api_key);

        [Get("/genre/movie/list?language=en-US")]
        Task<GenreResult> GetMovieGenres(string api_key);
        
        [Get("/movie/{movieId}/videos?language=en-US")]
        Task<VideoResult> GetMovieTrailer(int movieId, string api_key);

        [Get("/movie/{movieId}?append_to_response=images,credits")]
        Task<MovieInfoLong> GetMovieInfoLong(int movieId, string api_key);
    }
}
