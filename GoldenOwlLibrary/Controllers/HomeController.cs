using GoldenOwlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldenOwlLibrary.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext Context;

        public HomeController()
        {
            Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
        }

        public ActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
                return View("IndexLogged");

            return View();
        }
    }
}