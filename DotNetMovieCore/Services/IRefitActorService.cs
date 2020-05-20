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

        [Get("/person/{actorId}/movie_credits?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ActorCreditResult> GetActorCredits(int actorId);

        [Get("/person/3223/tagged_images?api_key=a28d205a378cece6baa18ba20119765b&language=en-US&page=1")]
        Task<ActorImageResult> GetActorImages(int actorId);

        [Get("/person/{actorId}?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task<ActorInfo> GetActorInfo(int actorId);

        [Get("/person/popular?api_key=a28d205a378cece6baa18ba20119765b&language=en-US")]
        Task <ActorResult> GetAllActors(int page);
    }
}
