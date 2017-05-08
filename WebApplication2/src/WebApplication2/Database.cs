using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Entities;
using WebApplication2.ViewModels;

namespace WebApplication2
{
    public class Database
    {
        private MovieBaseContext mbcontext;
        public Database( MovieBaseContext context )
        {
            mbcontext = context;
        }

        public ICollection<MovieViewModel> getAllMovies( )
        {

            ICollection<Movie> Movies = mbcontext.Movie.Select( m => m ).ToList();
            ICollection<MovieViewModel> mvms = new List<MovieViewModel>();;
            foreach (var item in Movies )
            {
                MovieViewModel mvm = new MovieViewModel();
                mvm.Description = item.Description;
                mvm.Director = mbcontext.Person.FirstOrDefault( p => p.PersonId == item.MovieId );
                mvm.title = item.Title;
                mvm.year = item.Year;
                mvm.actors = mbcontext.MovieActor.Where( ma => ma.MovieId == item.MovieId ).ToList();
                mvm.rating = item.Stars;
                mvms.Add( mvm );
            }



            return mvms;
        }

        internal ICollection<MovieViewModel> getMoviesByYear( int year )
        {
            ICollection<Movie> Movies = mbcontext.Movie.Select( m => m ).Where(m=> m.Year == year).ToList( );
            ICollection<MovieViewModel> mvms = new List<MovieViewModel>( );
            ;
            foreach( var item in Movies )
            {
                MovieViewModel mvm = new MovieViewModel( );
                mvm.Description = item.Description;
                mvm.Director = mbcontext.Person.FirstOrDefault( p => p.PersonId == item.MovieId );
                mvm.title = item.Title;
                mvm.year = item.Year;
                mvm.actors = mbcontext.MovieActor.Where( ma => ma.MovieId == item.MovieId ).ToList( );
                mvm.rating = item.Stars;
                mvms.Add( mvm );
            }
            return mvms;
        }
    }
}
