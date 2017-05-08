using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieShopXS_BornArnout
{
    public class MovieController : Controller
    {
        
        // GET: /<controller>/
        [Route("Movie")]
        public IActionResult Movie( )
        {
            Console.WriteLine( "succes?" );
            return View("Movie");
        }
        [Route("Year/{year}")]
        public IActionResult MoviesByYear( int year )
        {
            return View( );
        }
    }
}
