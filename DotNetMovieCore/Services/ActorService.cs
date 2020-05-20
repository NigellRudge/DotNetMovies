using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using DotNetMovieCore.config;

namespace DotNetMovieCore.Services
{
    public class ActorService : IActorService
    {
        
        public ActorCreditResult GetActorCredits(int actorId)
        {
            var service = RestService.For<IRefitActorService>(Config.BASE_URL);
            return service.GetActorCredits(actorId).Result;
        }

        public IEnumerable<ActorImage> GetActorImages(int actorId)
        {
            var service = RestService.For<IRefitActorService>(Config.BASE_URL);
            return service.GetActorImages(actorId).Result.results;
        }

        public ActorInfo GetActorInfo(int actorId)
        {
            var service = RestService.For<IRefitActorService>(Config.BASE_URL);
            return service.GetActorInfo(actorId).Result;
        }

        public IEnumerable<Actor> GetActors(int page = 1)
        {
            var service = RestService.For<IRefitActorService>(Config.BASE_URL);
            return service.GetAllActors(page).Result.results;
        }
    }
}
