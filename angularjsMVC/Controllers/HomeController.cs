using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace angularjsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Product()
        {
            return View();
        }
    }
}