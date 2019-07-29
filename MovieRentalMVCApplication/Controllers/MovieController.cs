using MovieRentalMVCApplication.Models;
using MovieRentalMVCApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalMVCApplication.Controllers
{
    public class MovieController : Controller
    {
        ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movie
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            return View(movie);
        }

        public ActionResult New()
        {

            var genre = _context.Genres.ToList();
            var viewModel = new NewMovieViewModel
            {
                Genres = genre
            };
            return View(viewModel);
        }
    }
}