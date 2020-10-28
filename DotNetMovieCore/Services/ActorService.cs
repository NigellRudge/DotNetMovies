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
        private readonly ApiOptions _config;

        public ActorService(IOptionsMonitor<ApiOptions> settings)
        {
            this._config = settings.CurrentValue;

        }
        public async Task<ActorCreditResult> GetActorCredits(int actorId)
        {
            try{
                var service = RestService.For<IRefitActorService>(_config.BaseUrl);
                return  await service.GetActorCredits(actorId,_config.ApiKey);
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
                var service = RestService.For<IRefitActorService>(_config.BaseUrl);
                var result = (await service.GetActorImages(actorId, _config.ApiKey)).results;
 
                foreach(var item in result)
                {
                    System.Diagnostics.Debug.WriteLine(result);
                }
                return (await service.GetActorImages(actorId, _config.ApiKey)).results;
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
                var service = RestService.For<IRefitActorService>(_config.BaseUrl);
                return await service.GetActorInfo(actorId, _config.ApiKey);
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
                var service = RestService.For<IRefitActorService>(_config.BaseUrl);
                return (await service.GetAllActors(page, _config.ApiKey)).results;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }
    }
}
