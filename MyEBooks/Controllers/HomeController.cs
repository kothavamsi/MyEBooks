using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;
using MyEBooks.DataBaseHandler;
using MyEBooks.WebApi;

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
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return View("ContactSuccess");
            }
            else
            {
                DBManager.SaveContact(contact);
                return View(contact);
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
            SiteMapData smd = new SiteMapData();
            smd.LoadSiteMapData();
            return View("sitemap", smd);
        }
    }
}
