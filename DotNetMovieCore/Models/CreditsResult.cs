using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    class CreditsResult
    {
        public int id { get; set; }
        public IList<Cast> cast { get; set; }
        public IList<Crew> crew { get; set; }
    }

}
