using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class MovieController : Controller
    {
        public Database db;
        public MovieController(MovieBaseContext context )
        {
            db = new Database( context );
        }
        // GET: /<controller>/
        [Route( "Movies" )]
        public IActionResult Index( )
        {
            return View( db.getAllMovies( ) );
        }

        [Route("Year/{year}")]
        public IActionResult years( int year )
        {
            return View(db.getMoviesByYear( year ));
        }
    }
}
