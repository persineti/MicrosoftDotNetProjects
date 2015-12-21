using MyFirstMVC4Application.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC4Application.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        //[HttpPost]
        //public ActionResult Search(string name)
        //{
        //    var message = Server.HtmlEncode(name);
        //    //return Content(message.ToString());
        //    //return RedirectPermanent("http://microsoft.com");
        //    //return RedirectToAction("About", "Home", new { name = "srinivas" });
        //    //return RedirectToRoute("Default", new { Controller = "Home", Action = "About", Name = name });
        //    //return File(Server.MapPath("~/content/site.css"), "text/css");
        //    return Json(new { Message = message, Name = "srinivas" }, JsonRequestBehavior.AllowGet);
        //}
        
        
        [HttpGet]
        public ActionResult Search()
        {
            //throw new Exception("Some thing went wrong");
            return Content("Hello world with anatations");
            
        }

    }
}
