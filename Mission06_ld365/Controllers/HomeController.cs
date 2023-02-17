using Microsoft.AspNetCore.Mvc;
using Mission06_ld365.Models;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission06_ld365.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieContext _movieContext { get; set; }

        //constructor
        public HomeController( MovieContext movie)
        {

            _movieContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpGet]
        public IActionResult NewMovie()
        {
            //creating dynamic variable to hold seeded data in a list
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(MovieEntry movie)
        {
            if (ModelState.IsValid)
            {
                //adding mocies to the database that have been entered in the form
                _movieContext.Add(movie);
                _movieContext.SaveChanges();

                //reroute to a confirmation page after submitting the form
                return View("Confirmation", movie);
            }

            else //if invalid
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View();
            }

            
        }
        public IActionResult Podcast()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult MovieList()
        {

            //filtering data
            var movies = _movieContext.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Category.CategoryName)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            //populating field if the want to edit movie info
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Movies.Single(x => x.MovieId == movieid);

            return View("NewMovie", movie);

        }

        [HttpPost]
        public IActionResult Edit(MovieEntry movie)
        {
            _movieContext.Update(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Movies.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntry movie)
        {

            _movieContext.Movies.Remove(movie);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");

        }
    }
}
