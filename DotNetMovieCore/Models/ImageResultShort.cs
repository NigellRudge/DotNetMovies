using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class ImageResultShort
    {
        public IList<Backdrop> backdrops { get; set; }
        public IList<Poster> posters { get; set; }
    }
}
