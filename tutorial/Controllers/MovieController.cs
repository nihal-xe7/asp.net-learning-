using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using tutorial.Models;
using tutorial.viewModels;

namespace tutorial.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Kono Su ba",Id = 1};
            var customer = new List<Customer>
            {
                new Customer() {Name = "Hasan"},
                new Customer() {Name = "Adnan"}
            };
            var viewModel = new RandomMovieById()
            {
                Movies = movie,
                Customers = customer
            };
            return View(viewModel);
            //return RedirectToAction("Index", "Home", new {page = 1, value = 0});
          
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //to make nullable use ? after type and before variable name
        //string is a refresnce type obj. default is null
        public ActionResult Index(int? page, string name)
        {
            if (!page.HasValue)
                page = 1;
            if (name.IsNullOrWhiteSpace())
                name = "No name given";

            return Content(string.Format("Page={0}\nName={1}", page, name));

        }
        [Route("movie/release/{year:regex(\\d{4}):range(2000,2018)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(string.Format("Year={0}  And  Month={1}", year, month));
        }
	}
}