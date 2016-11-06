using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quizwanie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Projekt z przedmiotu SERWISY INTERNETOWE .NET - Serwis ASP.NET";

            return View();
        }
    }
}