using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller

    {
        // GET: Movies/Random
        public ActionResult Random(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //GET: Movies
        public ActionResult Index()
        {
            var moviesList = new List<Movie>
            {
                new Movie() { Name = "Shrek" },
                new Movie() { Name = "Wall-e" }
            };

            var movies = new MovieViewModel()
            {
                Movies = moviesList


            };
            return View(movies);
        }

        /*
         * instead of routes.MapRoute("MoviesByReleasedDate", "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },new {year = @"2015|2016",month = @"\d{2}"});
         */
        //GET: Movies/released/{year}/{month}
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }


}