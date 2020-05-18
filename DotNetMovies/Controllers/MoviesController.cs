using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Services;
using DotNetMovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMovies.Controllers
{
    [Route("/")]
    [Route("Movies")]
    public class MoviesController : Controller
    {
        private IMovieService MovieService;

        public MoviesController(IMovieService movieService)
        {
            MovieService = movieService;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var model = new HomeViewModel()
            {
                NowPlayingMovies = this.MovieService.GetNowPlaying(),
                TopRatedMovies = this.MovieService.GetTopMovies(),
                genres = this.MovieService.GetMovieGenres()
            };
            return View(model);
        }
        [Route("Details/{movieId}")]
        public IActionResult Details(int movieId)
        {
            var model = new DetailViewModel()
            {
                movie = this.MovieService.Get(movieId),
                cast = this.MovieService.GetCast(movieId).ToList().GetRange(0, 10),
                crew = this.MovieService.GetCrew(movieId).ToList().GetRange(0, 5),
                backdrops = this.MovieService.GetBackDrops(movieId).ToList().GetRange(0, 9),
                posters = this.MovieService.GetMoviePosters(movieId).ToList()
             
            };
            return View(model);
        }
    }
}