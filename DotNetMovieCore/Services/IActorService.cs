using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Services
{
    public interface IActorService
    {
         ActorInfo GetActorInfo(int actorId);
        IEnumerable<ActorImage> GetActorImages(int actorId);
        ActorCreditResult GetActorCredits(int actorId);
        IEnumerable<Actor> GetActors(int page = 1);
    }
}
