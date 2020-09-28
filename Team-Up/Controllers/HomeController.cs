using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team_Up.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Reach out, create or join a team and start developing together!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to get in touch with any questions you have.";

            return View();
        }
        public ActionResult TermsOfService()
        {
            return View();
        }
    }
}