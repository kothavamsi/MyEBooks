using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class TopSellersController : MyBaseController
    {
        //
        // GET: /TopSellers/

        public ActionResult Index()
        {
            // Dependency Injection
            var topSellers = new TopSellers(_repository);
            topSellers.NavigationBar.RenderSortByListMenu = false;
            return View("Index", topSellers);
        }

    }
}
