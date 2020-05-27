using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Models;
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

        [ResponseCache(Duration = 60 * 5)]
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var model = new ShowsViewModel()
            {
                TopRatedShows = await this.Service.GetTopRatedShows(),
                NowAiringShows = await this.Service.GetNowAiring(),
                genres = await this.Service.GetGenres()
            };
            return View(model);
        }

        [ResponseCache(Duration = 60 * 5)]
        [Route("Details/{showId}")]
        public async Task<IActionResult> Details(int showId)
        {
            var model = new ShowViewmodel()
            {
                show = await this.Service.GetShowInfo(showId),
                cast = (await this.Service.GetShowCast(showId)).ToList(),
                crew = (await this.Service.GetShowCrew(showId)).ToList(),
                backdrops = (await this.Service.GetShowBackdrops(showId)).ToList(),
                posters = (await this.Service.GetShowPosters(showId)).ToList(),
                trailer = await this.Service.GetShowTrailer(showId)
            };
            return View(model);
        }

        [ResponseCache(Duration = 60 * 5)]
        [Route("{showId}/season/{seasonId}")]
        public async Task<IActionResult> Season(int showId, int seasonId)
        {
            var model = new SeasonInfoViewmodel()
            {
                season = await this.Service.GetSeasonInfo(showId,seasonId),
                show = await this.Service.GetShowInfo(showId),
                posters = (await this.Service.GetSeasonPosters(showId,seasonId)).ToList(),
                trailer = await this.Service.GetSeasonTrailer(showId),
            };
            return View(model);
        }

        [ResponseCache(Duration = 60 * 5)]
        [Route("{showId}/{seasonId}/episode/{episodeId}")]
        public async Task<IActionResult> Episode(int showId,int seasonId, int episodeId)
        {
            var model = new EpisodeViewmodel()
            {
                episode = await this.Service.GetEpisodeInfo(showId, seasonId, episodeId),
                images =  (await this.Service.GetEpisodeImages(showId,seasonId,episodeId)).ToList(),
                trailer = await this.Service.GetSeasonTrailer(showId)
            };
            return View(model);
        }
    }
}