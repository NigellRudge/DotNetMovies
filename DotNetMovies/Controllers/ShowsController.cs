using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Services;
using DotNetMovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMovies.Controllers
{
    [Route("Shows")]
    public class ShowsController : Controller
    {
        public IShowService Service;

        public ShowsController(IShowService service)
        {
            Service = service;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var model = new ShowsViewModel()
            {
                TopRatedShows = this.Service.GetTopRatedShows(),
                NowAiringShows = this.Service.GetNowAiring(),
                genres = this.Service.GetGenres()
            };
            return View(model);
        }

        [Route("Details/{showId}")]
        public IActionResult Details(int showId)
        {
            var model = new ShowViewmodel()
            {
                show = this.Service.GetShowInfo(showId),
                cast = this.Service.GetShowCast(showId).ToList(),
                crew = this.Service.GetShowCrew(showId).ToList(),
                backdrops = this.Service.GetShowBackdrops(showId).ToList(),
                posters = this.Service.GetShowPosters(showId).ToList(),
                trailer = this.Service.GetShowTrailer(showId)
            };
            return View(model);
        }
    }
}