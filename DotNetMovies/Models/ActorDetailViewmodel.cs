using DotNetMovieCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMovies.Models
{
    public class ActorDetailViewmodel
    {
        public ActorInfo actor;
        public IEnumerable<ActorImage> images;
        public IEnumerable<ActorCastCredit> roles;
    }
}
