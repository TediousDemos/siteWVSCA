﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is how you can conact us.";

            return View();
        }
        public ActionResult Gender()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Select Gender", Value = "0" });
            items.Add(new SelectListItem { Text = "Female", Value = "1" });
            items.Add(new SelectListItem { Text = "Male", Value = "2", Selected = true });
            items.Add(new SelectListItem { Text = "Other", Value = "3" });
            ViewBag.Gender = items;
            return View();
        }
    }
}