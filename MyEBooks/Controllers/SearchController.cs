using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;

namespace MyEBooks.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        public ActionResult Index(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return View("Error");
            }
            else
            {
                var result = FindBooks(keyword);
                return View("Result", result);
            }
        }

        private List<Book> FindBooks(string keyword)
        {
            throw new NotImplementedException();
        }

    }
}
