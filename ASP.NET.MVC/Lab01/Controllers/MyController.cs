using Lab01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class MyController : Controller
    {
        /*
        public ActionResult Index()
        {
            return View();
        }*/

        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}