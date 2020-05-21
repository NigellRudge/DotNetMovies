using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using DotNetMovieCore.config;
using DotNetMovies.Utils;
using Microsoft.Extensions.Options;

namespace DotNetMovieCore.Services
{
    public class ActorService : IActorService
    {
        private ApiOptions config;

        public ActorService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;

        }
        public ActorCreditResult GetActorCredits(int actorId)
        {
            try{
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return service.GetActorCredits(actorId,config.ApiKey).Result;
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<ActorImage> GetActorImages(int actorId)
        {
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return service.GetActorImages(actorId, config.ApiKey).Result.results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public ActorInfo GetActorInfo(int actorId)
        {
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return service.GetActorInfo(actorId, config.ApiKey).Result;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public IEnumerable<Actor> GetActors(int page = 1)
        {       
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return service.GetAllActors(page, config.ApiKey).Result.results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }
}
