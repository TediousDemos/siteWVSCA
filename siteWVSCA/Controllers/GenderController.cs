using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace siteWVSCA.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Select Gender", Value = "0" });
            items.Add(new SelectListItem { Text = "Female", Value = "1" });
            items.Add(new SelectListItem { Text = "Male", Value = "2", Selected = true });
            items.Add(new SelectListItem { Text = "Other", Value = "3" });
            ViewBag.MovieType = items;
            return View();
        }
    }
}