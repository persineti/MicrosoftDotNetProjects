//using MyFirstMVC4Application.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace MyFirstMVC4Application.Controllers
//{
//    public class ReviewController : Controller
//    {
//        //
//        // GET: /Review/
//        [ChildActionOnly]
//        public ActionResult BestReview()
//        {
//            var bestReview = from r in _reviews
//                        orderby r.Rating descending
//                        select r;
//            return PartialView("_Review",bestReview.First());
//        }

//        public ActionResult Index()
//        {
//            var model = from r in _reviews
//                        orderby r.Country
//                        select r;
//            return View(model);
//        }

//        //
//        // GET: /Review/Details/5

//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        //
//        // GET: /Review/Create

//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Review/Create

//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Review/Edit/5

//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            return View(review);
//        }

//        //
//        // POST: /Review/Edit/5

//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                var review = _reviews.Single(r => r.Id == id);
//                if (TryUpdateModel(review))
//                { 
//                       // TODO: Add update logic here
//                    return RedirectToAction("Index");
//                }

//                return View(review);
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Review/Delete/5

//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Review/Delete/5

//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        public List<RestaurantReview> _reviews = new List<RestaurantReview>()
//        {
//            new RestaurantReview
//            {
//                Id=1,
//                Name="Tabla",
//                City="hyderabad",
//                Country="india",
//                Rating=100
//            },

//            new RestaurantReview 
//            {
//                Id=2,
//                Name="Natanki",
//                City="hyderabad",
//                Country="<script>alert('xss');</script>",
//                Rating=200
//            },

//            new RestaurantReview
//            {
//                Id=3,
//                Name="Barbi",
//                City="hyderabad",
//                Country="india",
//                Rating=300
//            },

//            new RestaurantReview
//            {
//                Id=4,
//                Name="golkonda",
//                City="hyderabad",
//                Country="india",
//                Rating=400
//            }
//        };


//    }
//}
