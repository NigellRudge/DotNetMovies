using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetMovieCore.Services;
using DotNetMovies.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetMovies.Controllers
{
    [Route("Actor")]
    public class ActorController : Controller
    {
        private IActorService service;

        public ActorController(IActorService actorService)
        {
            service = actorService;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            var model = new ActorHomeViewmodel()
            {
                actors = this.service.GetActors().ToList()
            };
            return View(model);
        }

        [Route("Details/{actorId}")]
        public IActionResult Details(int actorId)
        {
            return View();
        }
    }
}