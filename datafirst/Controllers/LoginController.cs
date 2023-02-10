using datafirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace datafirst.Controllers
{
    public class LoginController : Controller
    {
        ErtuDBEntities db = new ErtuDBEntities();

        public ActionResult Index()
        {
            var model = db.Author.ToList();
            return View();
        }
    }
}