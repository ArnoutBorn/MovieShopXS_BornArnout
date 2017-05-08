using System.Collections.Generic;
using WebApplication2.Entities;

namespace WebApplication2.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel( )
        {
        }

        public string title { get; set; }
        public int  year { get; set; }
        public string Description { get; set; }
        public Person Director { get; set; }
        public ICollection<MovieActor> actors { get; set; }
        public int rating { get; set; }
    }
}
