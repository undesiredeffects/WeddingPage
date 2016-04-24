using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeddingPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RSVP()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Photos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}