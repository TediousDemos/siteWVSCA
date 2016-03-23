using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//This is where views are returned, there shoudl be acouple others that deal with linking within the site
namespace siteWVSCA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Register for an account to simplify torunament registration";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tournament Directors:";

            return View();
        }
    }
}