using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObservationBoard.Controllers
{
    public class HomeController : Controller
    {
        //TODO: Here we can lockdown the app to be only used on the domain.
        //[Authorize(Roles = "DOMAIN\\GROUP")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}