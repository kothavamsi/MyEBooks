﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class TopSellersController : Controller
    {
        //
        // GET: /TopSellers/

        public ActionResult Index()
        {
            var topSellers = new TopSellers();
            topSellers.NavBar.RenderSortBy = false;
            return View("Index", topSellers);
        }

    }
}