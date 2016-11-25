using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactUs contacctUs)
        {
            if (ModelState.IsValid)
            {
                return View("ContactSuccess");
            }
            else
            {
                return View(contacctUs);
            }
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult RSS()
        {
            return View();
        }

        public ActionResult DMCA()
        {
            return View();
        }

        public ActionResult Donate()
        {
            return View();
        }

        public ActionResult Sitemap()
        {
            return View();
        }
    }
}
