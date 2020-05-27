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

        //[ResponseCache(Duration =60*5)]
        [Route("index")]
        [Route("")]
        public async Task<IActionResult> Index()
        {
            var model = new HomeViewModel()
            {
                NowPlayingMovies = await this.MovieService.GetNowPlaying(),
                TopRatedMovies = await this.MovieService.GetTopMovies(),
                genres = await this.MovieService.GetMovieGenres()
            };
            return View(model);
        }
        //[ResponseCache(Duration = 60 * 5)]
        [Route("Details/{movieId}")]
        public async Task<IActionResult> Details(int movieId)
        {
            var model = new DetailViewModel()
            {
                movie =  await this.MovieService.GetMovieInfoLong(movieId),
                posters = (await this.MovieService.GetMoviePosters(movieId)).ToList(),
                trailer = await this.MovieService.GetMovieTrailer(movieId)
             
            };
            return View(model);
        }
        [Route("Search")]
        public async Task<JsonResult> Search(string query)
        {
            var result = (await this.MovieService.Search(query)).ToList();
            return Json(result.Count > 10 ? result.GetRange(1, 10) : result);
        }


    }
}