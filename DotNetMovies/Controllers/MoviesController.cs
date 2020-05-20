using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Services;
using DotNetMovies.Models;
using Microsoft.AspNetCore.Cors;
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
                backdrops = this.MovieService.GetBackDrops(movieId).ToList(),
                posters = this.MovieService.GetMoviePosters(movieId).ToList(),
                trailer = this.MovieService.GetMovieTrailer(movieId)
             
            };
            return View(model);
        }
        [Route("Search")]
        public JsonResult Search(string query)
        {
            var result = this.MovieService.Search(query).ToList();
            return Json(result.Count > 10 ? result.GetRange(1, 10) : result);
        }
    }
}