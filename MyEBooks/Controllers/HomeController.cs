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
            var viewModelBase = new ViewModelBase();
            return View("Index", viewModelBase);
        }

        public ActionResult About()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("About", viewModelBase);
        }

        public ActionResult Contact()
        {
            var contact = new Contact();
            contact.NavBar.RenderSortBy = false;
            return View("Contact", contact);
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var viewModelBase = new ViewModelBase();
                viewModelBase.NavBar.RenderSortBy = false;
                return View("ContactSuccess", viewModelBase);
            }
            else
            {
                DBManager.SaveContact(contact);
                contact.NavBar.RenderSortBy = false;
                return View("Contact", contact);
            }
        }

        public ActionResult PrivacyPolicy()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("PrivacyPolicy", viewModelBase);
        }

        public ActionResult FAQ()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("FAQ", viewModelBase);
        }

        public ActionResult RSS()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("RSS", viewModelBase);
        }

        public ActionResult DMCA()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("DMCA", viewModelBase);
        }

        public ActionResult Donate()
        {
            var viewModelBase = new ViewModelBase();
            viewModelBase.NavBar.RenderSortBy = false;
            return View("Donate", viewModelBase);
        }

        public ActionResult Sitemap()
        {
            var siteMapData = new SiteMapData();
            siteMapData.NavBar.RenderSortBy = false;
            return View("Sitemap", siteMapData);
        }
    }
}
