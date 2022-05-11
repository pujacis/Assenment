using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string? MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? DirectorName { get; set; }
    }
}
