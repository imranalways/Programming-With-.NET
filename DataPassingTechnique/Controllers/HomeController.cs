using DataPassingTechnique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingTechnique.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return RedirectToAction("Another");

            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                string name = Request["name"];
                string username = Request["username"];
                string password = Request["password"];
                string date = Request["date"];
                string blood = Request["blood"];
                string gender=Request["gender"];
                return Content("<h2>Name:"+name+" <br> " +
                    "Username:"+username+" <br> " +
                    "Password:"+password+" <br>" +
                    " Date:"+date+" <br> " +
                    "Blood:"+blood+" <br> " +
                    "Gender:"+gender+"</h2>");
            }
        }
        public ActionResult Another()
        {
            Person p = new Person() { Name = "Imran Hossain", Email = "imran@gmail.com" };
            //Session["name"] = "Imran";
            //ViewData["name"] = "Hossain";
            // ViewBag.name = "Imran Hossain";
            //TempData["name"] = "Hossain Imran";

            return View(p);
        }
    }
}