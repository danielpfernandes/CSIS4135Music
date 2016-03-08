using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This music database is not just another music database";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact information";

            return View();
        }
    }
}