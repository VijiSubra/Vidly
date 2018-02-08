using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private MyDbContext _context;
        public MoviesController()
        {
            _context = new MyDbContext();
        }
                // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            var viewModel = new CustomerViewModel
            {
                Movies = movies
            };
            return View(movies);
        }
    }
}