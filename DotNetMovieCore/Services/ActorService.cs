using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using DotNetMovieCore.config;
using DotNetMovies.Utils;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public class ActorService : IActorService
    {
        private ApiOptions config;

        public ActorService(IOptionsMonitor<ApiOptions> settings)
        {
            this.config = settings.CurrentValue;

        }
        public async Task<ActorCreditResult> GetActorCredits(int actorId)
        {
            try{
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return  await service.GetActorCredits(actorId,config.ApiKey);
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<ActorImage>> GetActorImages(int actorId)
        {
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return (await service.GetActorImages(actorId, config.ApiKey)).results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<ActorInfo> GetActorInfo(int actorId)
        {
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return await service.GetActorInfo(actorId, config.ApiKey);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Actor>> GetActors(int page = 1)
        {       
            try
            {
                var service = RestService.For<IRefitActorService>(config.BaseUrl);
                return (await service.GetAllActors(page, config.ApiKey)).results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }
}
