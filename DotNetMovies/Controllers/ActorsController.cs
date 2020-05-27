using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Services;
using DotNetMovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMovies.Controllers
{
    [Route("Actors")]
    public class ActorsController : Controller
    {
        private IActorService service;

        public ActorsController(IActorService actorService)
        {
            service = actorService;
        }
        [Route("")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            var model = new ActorHomeViewmodel()
            {
                actors = (await this.service.GetActors()).ToList()
            };
            return View(model);
        }

        [Route("Details/{actorId}")]
        public async Task<IActionResult> Details(int actorId)
        {
            var count = (await this.service.GetActorCredits(actorId)).cast.Count;
            count = count >= 10 ? 10 : count;
            var model = new ActorDetailViewmodel()
            {
                actor = await this.service.GetActorInfo(actorId),
                images = await this.service.GetActorImages(actorId),
                roles = (await this.service.GetActorCredits(actorId)).cast.ToList().GetRange(0,count)
            };
            return View(model);
        }
    }
}