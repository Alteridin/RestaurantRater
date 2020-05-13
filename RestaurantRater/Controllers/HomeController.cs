using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRater.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Restaurant Rater.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Restaurant Rater.";

            return View();
        }
    }
}