using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private MyDbContext _context;
        public CustomersController()
        {
            _context = new MyDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.ToList().SingleOrDefault(c => c.ID == id);
            return View(customer);
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            
            return View(viewModel);
        }
    }
}