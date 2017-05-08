﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            Movie = new HashSet<Movie>();
        }

        public int GenreId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
