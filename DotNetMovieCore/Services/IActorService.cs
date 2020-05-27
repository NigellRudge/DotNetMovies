using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNetMovieCore.Services
{
    public interface IActorService
    {
        Task<ActorInfo> GetActorInfo(int actorId);
        Task<IEnumerable<ActorImage>> GetActorImages(int actorId);
        Task<ActorCreditResult> GetActorCredits(int actorId);
        Task<IEnumerable<Actor>> GetActors(int page = 1);
    }
}
