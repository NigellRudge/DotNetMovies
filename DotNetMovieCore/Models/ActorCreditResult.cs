using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
   public class ActorCreditResult
    {
        public IList<ActorCastCredit> cast { get; set; }
        public IList<ActorCrewCredit> crew { get; set; }
        public int id { get; set; }
    }
}
