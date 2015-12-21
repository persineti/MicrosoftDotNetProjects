using MyFirstMVC4Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC4Application.Controllers
{
    public class HomeController : Controller
    {
        MyMVCDBContext _db = new MyMVCDBContext();

        public ActionResult Index(string SearchTerm=null)
        {
            //var controlloer = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];

            //ViewBag.Message = string.Format("{0}{1}{2}",controlloer,action,id);

            //var model = _db.Restaurants.ToList();

            // inline queries
            //var model = from r in _db.Restaurants
            //            orderby r.Reviews.Average(review => review.Rating) descending
            //            select new RestaurantsListViewModel
            //            {
            //                Id= r.Id,
            //                Name= r.Name,
            //                City= r.City,
            //                Country= r.Country,
            //                NumberOfReviews = r.Reviews.Count()
            //            }
            //            ;

            // using some lamda expression

            var model = _db.Restaurants
                        .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                        .Where(r => SearchTerm == null || r.Name.StartsWith(SearchTerm))
                        .Take(5)
                        .Select(r => new RestaurantsListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            NumberOfReviews = r.Reviews.Count()
                        });

            return View(model);
        }

        public ActionResult About(string name="srinivas")
        {
            AboutModel aboutModel = new AboutModel();
            aboutModel.MynName = name.ToString();
            aboutModel.Location = "southBrunswick";
            return View(aboutModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db !=null)
            {
                _db.Dispose(); 
            }
            base.Dispose(disposing);
        }
    }
}
