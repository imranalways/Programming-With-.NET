using FormProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace FormProcess.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Index(Person p)
        {
            TempData["person"] = p;
            return RedirectToAction("showData");
        }

        public ActionResult showData()
        {
            Person p = TempData["person"] as Person;
            return View(p);
        }
    }
}