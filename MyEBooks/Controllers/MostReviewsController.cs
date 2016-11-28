using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class MostReviewsController : MyBaseController
    {
        //
        // GET: /MostReviews/

        public ActionResult Index()
        {
            var mostReviews = new MostReviews();
            mostReviews.NavigationBar.RenderSortByListMenu = false;
            return View("Index", mostReviews);
        }

    }
}
