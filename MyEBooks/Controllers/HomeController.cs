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
    public class HomeController : MyBaseController
    {
        public ActionResult Index()
        {
            return View("Index", this.ViewModelBaseObj);
        }

        public ActionResult About()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("About", this.ViewModelBaseObj);
        }

        public ActionResult Contact()
        {
            var contact = new Contact();
            contact.NavigationBar.RenderSortByListMenu = false;
            return View("Contact", contact);
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
                return View("ContactSuccess", this.ViewModelBaseObj);
            }
            else
            {
                DBManager.SaveContact(contact);
                contact.NavigationBar.RenderSortByListMenu = false;
                return View("Contact", contact);
            }
        }

        public ActionResult PrivacyPolicy()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("PrivacyPolicy", this.ViewModelBaseObj);
        }

        public ActionResult FAQ()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("FAQ", this.ViewModelBaseObj);
        }

        public ActionResult RSS()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("RSS", this.ViewModelBaseObj);
        }

        public ActionResult DMCA()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("DMCA", this.ViewModelBaseObj);
        }

        public ActionResult Donate()
        {
            this.ViewModelBaseObj.NavigationBar.RenderSortByListMenu = false;
            return View("Donate", this.ViewModelBaseObj);
        }

        public ActionResult Sitemap()
        {
            var siteMapData = new SiteMapData();
            siteMapData.NavigationBar.RenderSortByListMenu = false;
            return View("Sitemap", siteMapData);
        }
    }
}
