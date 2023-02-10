using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace datafirst.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Harail | Projeler";
            return View();
        }
    }
}