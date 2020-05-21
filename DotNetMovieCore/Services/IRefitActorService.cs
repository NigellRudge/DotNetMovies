using DotNetMovieCore.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IRefitActorService
    {

        [Get("/person/{actorId}/movie_credits?language=en-US")]
        Task<ActorCreditResult> GetActorCredits(int actorId,string api_key);

        [Get("/person/3223/tagged_imageslanguage=en-US&page=1")]
        Task<ActorImageResult> GetActorImages(int actorId, string api_key);

        [Get("/person/{actorId}?language=en-US")]
        Task<ActorInfo> GetActorInfo(int actorId, string api_key);

        [Get("/person/popular?language=en-US")]
        Task <ActorResult> GetAllActors(int page, string api_key);
    }
}
