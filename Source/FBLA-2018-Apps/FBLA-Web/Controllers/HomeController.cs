using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBLA_Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello World! This is my about page!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello World! This is my contact page!";

            return View();
        }
    }
}