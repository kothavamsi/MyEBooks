using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class NewReleaseController : Controller
    {
        //
        // GET: /NewRelease/

        public ActionResult Index()
        {
            var newRelease = new NewRelease();
            newRelease.NavBar.RenderSortBy = false;
            return View("Index", newRelease);
        }

    }
}
