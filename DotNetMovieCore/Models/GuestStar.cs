﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMovieCore.Models
{
    public class GuestStar
    {
        public int id { get; set; }
        public string name { get; set; }
        public string credit_id { get; set; }
        public string character { get; set; }
        public int order { get; set; }
        public int gender { get; set; }
        public string profile_path { get; set; }
    }
}
