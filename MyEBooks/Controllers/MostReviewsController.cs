using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class MostReviewsController : Controller
    {
        //
        // GET: /MostReviews/

        public ActionResult Index()
        {
            var mostReviews = new MostReviews();
            mostReviews.NavBar.RenderSortBy = false;
            return View("Index", mostReviews);
        }

    }
}
