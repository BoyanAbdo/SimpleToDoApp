using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /movies/random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Top Gun" };

            return View(movie);
        }

 

        public IActionResult Demo()
        {
            var movie = new Movie() { Name = "Inception" };

            ViewData["Movie"] = movie;

            return View();
        }

        public IActionResult ByReleaseDate(int year, int month)
        {
            var movie = new Movie() { Name = "Inception" };

            return Content(year + "/" + month);
        }


    }
}
